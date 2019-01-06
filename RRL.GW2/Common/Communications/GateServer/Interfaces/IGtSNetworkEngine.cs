using RRL.GW2.Common.Communications.GateServer.Messages;
using RRL.GW2.Common.Network;

namespace RRL.GW2.Common.Communications.GateServer.Interfaces
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public interface IGtSNetworkEngine
    {
        void StartTcpServer(int port);

        void SendStsMessage(Connection connection, StsMessage message);

        void SendStsMessage(Connection connection, string header, string body);

        void StartTls(Connection connection);

        void PostStsMessage(Connection connection, string header, string body);
    }
}
