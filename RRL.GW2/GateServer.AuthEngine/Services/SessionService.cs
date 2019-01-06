using RRL.GW2.Common.Communications.GateServer;
using RRL.GW2.Common.Communications.GateServer.Messages.Session;
using RRL.GW2.Common.Network;

namespace GateServer.AuthEngine.Services
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    class SessionService
    {
        public static void CreateSession(Connection connection, string body)
        {
            if(connection.Account == null)
                return;

            GtSGlobal.NetworkEngine.SendStsMessage(connection, new CreateSessionMsg
                                                                   {
                                                                       SessionId = connection.Account.SessionId
                                                                   });
        }
    }
}
