namespace GW2Emu.Common
{
    public class AuthEngine : IGtSAuthEngine
    {
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
                    Log.Error("ProccessStsConnection", "Invalid header: " + header);
                    return;
            }
        }

        public Account ClientAuth(Connection connection, string login, string password)
        {
            return new Account
                       {
                           LoginName = "user",
                           UserName = "test",
                           LastPasswordChange = "2013-01-02T16:07:25Z",
                           UserCenter = 4,
                           HasPhone = 0,
                           EmailVerified = 1
                       };
        }
    }
}
