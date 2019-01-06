using System;
using GW2Emu.Common;

namespace GW2Emu.AuthServer
{
    public class AuthServerData
    {
        public AuthServerData()
        {
            Account = new Account();
            Characters = new Character[0];
            SyncCount = 1;
        }

        public Account Account;
        public Character[] Characters;
        public int SyncCount;
    }
}
