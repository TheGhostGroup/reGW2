using GateServer.AuthEngine.Services;
using RRL.GW2.Common.Communications.GateServer.Interfaces;
using RRL.GW2.Common.Data.Account;
using RRL.GW2.Common.Network;
using log4net;

namespace GateServer.AuthEngine
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public class AuthEngine : IGtSAuthEngine
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof (AuthEngine));

        public void ProcessStsConnection(Connection connection, string header, string body)
        {
            switch (header)
            {
                case "/Sts/Ping":
                case "/Sts/Connect":
                    break;

                case "/Auth/GetHostname":
                    AuthService.HostNameRequest(connection, body);
                    break;
                case "/Auth/StartTls":
                    AuthService.StartTls(connection, body);
                    break;
                case "/Auth/LoginFinish":
                    AuthService.LoginFinish(connection, body);
                    break;
                case "/Auth/ListMyGameAccounts":
                    AuthService.ListMyGameAccounts(connection, body);
                    break;
                case "/Auth/RequestGameToken":
                    AuthService.RequestGameToken(connection, body);
                    break;
                case "/Auth/GetUserInfo":
                    AuthService.RequestUserInfo(connection, body);
                    break;
                case "/Presence/GetUserInfo":
                    PresenceService.GetUserInfo(connection, body);
                    break;
                case "/Presence/SetWatch":
                    PresenceService.SetWatch(connection, body);
                    break;
                case "/Session/CreateSession":
                    SessionService.CreateSession(connection, body);
                    break;

                default:
                    Log.ErrorFormat("Unknown request: {0}", header);
                    Log.ErrorFormat("Data: {0}", body.Replace('\n', ' '));
                    return;
            }

            Log.InfoFormat("Received {0}", header);
        }

        public Account ClientAuth(Connection connection, string login, string password)
        {
            //...ah...later ^_^
            return new Account
                       {
                           LoginName = "user@test.com",
                           UserName = ":User.0001",
                           LastPasswordChange = "2013-01-02T16:07:25Z",
                           UserCenter = 4,
                           HasPhone = 0,
                           EmailVerified = 1
                       };
        }
    }
}
