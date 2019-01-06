using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using log4net;

namespace RRL.GW2.Common.Network
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public class TcpServer<TConnection>
        where TConnection : Connection, new()
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (TcpServer<TConnection>));

        private readonly Socket _serverSocket;
        private readonly APacketHandler<TConnection> _packetHandler;
        private readonly List<TConnection> _connections = new List<TConnection>(1024);

        public TcpServer(APacketHandler<TConnection> packetHandler, int port, int acceptThreads = 10, int backlog = 100)
        {
            _packetHandler = packetHandler;

            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            _serverSocket.Listen(backlog);

            _log.InfoFormat("Start *:{0} with {1}.", port, packetHandler.GetType().FullName);

            for (uint i = 0; i < acceptThreads; i++)
                _serverSocket.BeginAccept(AcceptCallback, _serverSocket);
        }

        private void CloseConnection(TConnection connection)
        {
            _log.Info("Client disconnected.");
            connection.Socket.Disconnect(true);
            lock (_connections) _connections.Remove(connection);
        }

        private void AcceptCallback(IAsyncResult result)
        {
            TConnection connection = new TConnection();
            try
            {
                Socket s = (Socket) result.AsyncState;
                connection.Socket = s.EndAccept(result);
                lock (_connections) _connections.Add(connection);

                _log.Info("New client connected.");

                connection.Socket.BeginReceive(
                    connection.Buffer.Data, connection.Buffer.WriteIndex,
                    connection.Buffer.Data.Length - connection.Buffer.WriteIndex,
                    SocketFlags.None,
                    ReceiveCallback,
                    connection);

                _serverSocket.BeginAccept(AcceptCallback, result.AsyncState);
            }
            catch (SocketException)
            {
                CloseConnection(connection);
            }
            catch (Exception exc)
            {
                CloseConnection(connection);
                _log.Error("Exception", exc);
            }
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            TConnection connection = (TConnection) result.AsyncState;
            try
            {
                int readed = connection.Socket.EndReceive(result);
                if (0 != readed)
                {
                    if (connection.Decoder != null)
                        connection.Decoder.Process(ref connection.Buffer.Data,
                                                   connection.Buffer.WriteIndex,
                                                   connection.Buffer.WriteIndex + readed);

                    connection.Buffer.WriteIndex += readed;

                    _packetHandler.Process(connection);

                    connection.Socket.BeginReceive(
                        connection.Buffer.Data, connection.Buffer.WriteIndex,
                        connection.Buffer.Data.Length - connection.Buffer.WriteIndex,
                        SocketFlags.None,
                        ReceiveCallback,
                        connection);
                }
                else CloseConnection(connection);
            }
            catch (SocketException)
            {
                CloseConnection(connection);
            }
            catch (Exception exc)
            {
                CloseConnection(connection);
                _log.Error("Exception: ", exc);
            }
        }
    }
}