namespace GW2Emu.Common
{
    public interface IGtSNetworkEngine
    {
        void StartTcpServer(int port);

        void SendStsMessage(Connection connection, StsMessage message);

        void SendStsMessage(Connection connection, string header, string body);

        void StartTls(Connection connection);

        void PostStsMessage(Connection connection, string header, string body);
    }
}
