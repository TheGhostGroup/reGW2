using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace GW2Emu.Common
{
    public class TcpServer<TConnection>
        where TConnection : Connection, new()
    {

        private readonly Socket _serverSocket;
        private readonly APacketHandler<TConnection> _packetHandler;
        private readonly List<TConnection> _connections = new List<TConnection>(1024);

        public TcpServer(APacketHandler<TConnection> packetHandler, int port, int acceptThreads = 10, int backlog = 100)
        {
            _packetHandler = packetHandler;

            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            _serverSocket.Listen(backlog);

            for (uint i = 0; i < acceptThreads; i++)
                _serverSocket.BeginAccept(AcceptCallback, _serverSocket);
            Log.Success("TcpServer", "Server created!");
        }

        private void CloseConnection(TConnection connection)
        {
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
            catch (Exception)
            {
                CloseConnection(connection);
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
                if(connection != null) CloseConnection(connection);
            }
            catch (Exception)
            {
                if (connection != null) CloseConnection(connection);
            }
        }
    }
}