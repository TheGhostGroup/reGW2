using RRL.GW2.Common.Data.Account;
using RRL.GW2.Common.Network;

namespace RRL.GW2.Common.Communications.GateServer.Interfaces
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public interface IGtSAuthEngine
    {
        void ProcessStsConnection(Connection connection, string header, string body);

        Account ClientAuth(Connection connection, string login, string password);
    }
}
