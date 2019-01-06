using System;
using System.Threading;

namespace GW2Emu.AuthServer
{
    public static class AuthServerDataContainer
    {
        private static ThreadLocal<AuthServerData> data = new ThreadLocal<AuthServerData>();

        static AuthServerDataContainer()
        {
            data.Value = new AuthServerData();
        }

        public static AuthServerData Data
        {
            get
            {
                return data.Value;
            }
        }
    }
}
