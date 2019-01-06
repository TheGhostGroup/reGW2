using System;


namespace GW2Emu.Common
{
    public class Account
    {
        public UID Id;
        public Connection connection = new Connection();
        public byte[] Info;
        public byte[] Medals;
        public string LoginName;
        public string UserName;
        public string Password;
        public byte UserCenter;
        public byte HasPhone;
        public byte EmailVerified;
        public string Created;
        public string LastPasswordChange;
        public string LastIp;
        public byte ForceIpEnter;
        public string UserId = "376830DD-E6ED-E111-BBF3-78E7D1936222";
        public string SessionId = "7C8D83CE-727C-4E03-981A-154CC4D5DE71";
        public string Token = "CC66A8B0-B24E-41D1-B018-51B66DA0B4B0";

        public static Account NewEmpty()
        {
            return new Account() 
            { 
                Id = new UID(new byte[16]), 
                Info = new byte[0], 
                Medals = new byte[0],
                LoginName = "",
                UserName  = "",
                Password = "",
                UserCenter = 0,
                HasPhone = 0,
                EmailVerified = 0,
                Created = "",
                LastPasswordChange = "",
                LastIp = "",
                ForceIpEnter = 0,
                UserId = "",
                SessionId = "",
                Token = ""
            };
        }
    }
}
