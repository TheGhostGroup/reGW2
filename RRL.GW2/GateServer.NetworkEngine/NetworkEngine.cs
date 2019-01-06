using GateServer.NetworkEngine.Responses;
using RRL.GW2.Common.Communications.GateServer.Interfaces;
using RRL.GW2.Common.Communications.GateServer.Messages;
using RRL.GW2.Common.Network;

namespace GateServer.NetworkEngine
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public class NetworkEngine : IGtSNetworkEngine
    {
        protected TcpServer<TlsConnection> Server;
        protected PacketHandler PacketHandler;

        public void StartTcpServer(int port)
        {
            PacketHandler = new PacketHandler();
            Server = new TcpServer<TlsConnection>(PacketHandler, port);
        }

        public void SendStsMessage(Connection connection, StsMessage message)
        {
            TlsConnection tlsConnection = connection as TlsConnection;

            if(tlsConnection == null)
                return;

            StsResponse.SendStsMessage(tlsConnection, message);
        }

        public void SendStsMessage(Connection connection, string header, string body)
        {
            TlsConnection tlsConnection = connection as TlsConnection;

            if (tlsConnection == null)
                return;

            StsResponse.SendStsMessage(tlsConnection, header, body);
        }

        public void StartTls(Connection connection)
        {
            TlsConnection tlsConnection = connection as TlsConnection;

            if(tlsConnection == null)
                return;

            tlsConnection.StartTls();
        }

        public void PostStsMessage(Connection connection, string header, string body)
        {
            TlsConnection tlsConnection = connection as TlsConnection;

            if (tlsConnection == null)
                return;

            StsResponse.Post(tlsConnection, header, body);
        }
    }
}
