using System;
using GW2Emu.Common;
using GW2Emu.AuthServer.Out;

namespace GW2Emu.AuthServer.Handlers
{
    public static class AccountHandler
    {
        public static void SendAccountInfo(SecurePacketBasedClient client)
        {
            P10_AccountMedals accountMedals = new P10_AccountMedals();
            accountMedals.SyncCount = AuthServerDataContainer.Data.SyncCount;
            accountMedals.MedalData = new byte[0];
            client.SendPacket(accountMedals);

            P08_AccountInfo accountInfo = new P08_AccountInfo();
            accountInfo.SyncCount = AuthServerDataContainer.Data.SyncCount;
            accountInfo.Unknown1 = new UID(new byte[16]);
            accountInfo.Unknown2 = new UID(new byte[16]);
            accountInfo.Unknown3 = 2;
            accountInfo.Unknown4 = 5;
            accountInfo.Unknown5 = 387914393;
            accountInfo.Unknown6 = 2007;
            accountInfo.Unknown7 = 2007;
            accountInfo.Unknown8 = 3;
            accountInfo.Unknown9 = new byte[] { 0x94, 0xD7, 0x7F, 0x77, 0xB1, 0x26, 0x56, 0xCF, 0x9D, 0xCD, 0x19, 0x3D, 0xC4, 0xFB, 0x2B, 0xC2, 0x1A, 0xB2, 0xFB, 0x0A, 0xEF, 0x40, 0x60, 0x16, 0x04, 0xC1, 0x90, 0x7C, 0xDB, 0x78, 0x07, 0x97 };
            accountInfo.Unknown16 = new P08_AccountInfo.Struct10[0];
            accountInfo.Unknown17 = new byte[32];
            client.SendPacket(accountInfo);

            P16_Unknown p16 = new P16_Unknown();
            p16.SyncCount = AuthServerDataContainer.Data.SyncCount;
            p16.Unknown1 = new Common.UID(new byte[16]);
            p16.Unknown2 = 0;
            p16.Unknown2 = 8753153;
            p16.Unknown2 = 168;
            p16.Unknown2 = 1800;
            p16.Unknown2 = 0;
            client.SendPacket(p16);

            P23_Unknown p23 = new P23_Unknown();
            client.SendPacket(p23);
        }
    }
}
