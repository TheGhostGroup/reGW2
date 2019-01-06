namespace GW2Emu.Common
{
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
