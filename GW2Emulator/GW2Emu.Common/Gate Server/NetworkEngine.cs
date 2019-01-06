

namespace GW2Emu.Common
{
    public class NetworkEngine : IGtSNetworkEngine
    {
        protected TcpServer<TlsConnection> Server;
        protected PacketHandler PacketHandler;

        public void StartTcpServer(int port)
        {
            PacketHandler = new PacketHandler();
            Server = new TcpServer<TlsConnection>(PacketHandler, port);
            Log.Success("StartTcpServer", "Server started at port " + port);
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
