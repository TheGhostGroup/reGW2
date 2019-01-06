using RRL.GW2.Common.Communications.GateServer;
using RRL.GW2.Common.Communications.GateServer.Messages.Presence;
using RRL.GW2.Common.Network;

namespace GateServer.AuthEngine.Services
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public class PresenceService
    {
        public static void GetUserInfo(Connection connection, string body)
        {
            if(connection.Account == null)
                return;

            GtSGlobal.NetworkEngine.SendStsMessage(connection,
                                                   new AccountUserInfoMsg
                                                       {
                                                           UserId = connection.Account.UserId,
                                                           UserCenter = connection.Account.UserCenter,
                                                           UserName = connection.Account.UserName,
                                                           Logins = new Logins
                                                                        {
                                                                            Type = "array",
                                                                            Location = "*10.51.69.34:6600 1001 1 17 376544805 1417841"
                                                                        },
                                                           ChangeId = 628,
                                                       });
        }

        public static void SetWatch(Connection connection, string body)
        {
            if(connection.Account == null)
                return;

            GtSGlobal.NetworkEngine.SendStsMessage(connection, new SetWatch
                                                                   {
                                                                       UserId = connection.Account.UserId,
                                                                       UserCenter = connection.Account.UserCenter,
                                                                       UserName = connection.Account.UserName,
                                                                       Parts = new Parts()
                                                                   });
        }
    }
}
