using System.Collections.Generic;


namespace GW2Emu.Common
{
    public class AuthService
    {
        public static void HostNameRequest(Connection connection, string body)
        {
            GtSGlobal.NetworkEngine.SendStsMessage(connection,
                                                   new HostnameMsg {Hostname = "cligate-lol.101.NCPlatform.net."});
            Log.Success("HostNameRequest", connection.Account.UserName);
        }

        public static void StartTls(Connection connection, string body)
        {
            GtSGlobal.NetworkEngine.StartTls(connection);

            GtSGlobal.NetworkEngine.SendStsMessage(connection, new ErrorMsg {Server = 1001, Module = 2, Line = 1185});
        }

        public static void LoginFinish(Connection connection, string body)
        {
            if (connection.Account == null)
                return;

            GtSGlobal.NetworkEngine.SendStsMessage(connection, new LoginMsg
                                                                   {
                                                                       UserId = connection.Account.UserId,
                                                                       UserCenter = connection.Account.UserCenter,
                                                                       HasPhone = connection.Account.HasPhone,
                                                                       EmailVerified = connection.Account.EmailVerified
                                                                   });
        }

        public static void ListMyGameAccounts(Connection connection, string body)
        {
            GtSGlobal.NetworkEngine.PostStsMessage(connection,
                                                   "/Presence/UserInfo",
                                                   "<Message>\n<Status>online</Status>\n<Aliases/>\n<AppData>\n<x_M scope=\"gw2\">15</x_M>\n<x_P scope=\"gw2\">6087,-30417</x_P>\n<x_S scope=\"gw2\">2006</x_S>\n<x_CS scope=\"gw2\">2,14,6,1,130,4,1,6,10</x_CS>\n<x_HS scope=\"gw2\">2006,2006</x_HS>\n<x_IE scope=\"gw2\">0</x_IE>\n</AppData>\n<Channels/>\n<Groups/>\n<Contacts/>\n<UserId>376830DD-E6ED-E111-BBF3-78E7D1936222</UserId>\n<UserCenter>4</UserCenter>\n<UserName>:User.0001</UserName>\n<ChangeId>532</ChangeId>\n<NewBeginning/>\n</Message>\n");

            GtSGlobal.NetworkEngine.SendStsMessage(connection, new GameAccountsMsg
                                                                   {
                                                                       Type = "array",
                                                                       AccsRows = new List<Row>
                                                                                      {
                                                                                          new Row
                                                                                              {
                                                                                                  Alias = "Guild Wars 2",
                                                                                                  GameCode = "gw2",
                                                                                                  Created =
                                                                                                      "2013-01-02T16:02:16Z",
                                                                                              }
                                                                                      }
                                                                   });
        }

        public static void RequestGameToken(Connection connection, string body)
        {
            if (connection.Account == null)
                return;

            GtSGlobal.NetworkEngine.SendStsMessage(connection,
                                                   new GameTokenMsg {Token = connection.Account.Token});
        }

        public static void RequestUserInfo(Connection connection, string body)
        {
            if (connection.Account == null)
                return;

            GtSGlobal.NetworkEngine.SendStsMessage(connection,
                                                   new UserInfoMsg
                                                       {
                                                           UserId = connection.Account.UserId,
                                                           UserCenter = connection.Account.UserCenter,
                                                           UserName = connection.Account.UserName,
                                                           LoginName = connection.Account.LoginName,
                                                           LastPasswordChange = connection.Account.LastPasswordChange
                                                       });
        }
    }
}
