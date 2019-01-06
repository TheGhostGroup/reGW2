using System;
using GW2Emu.Common;
using GW2Emu.AuthServer.Out;

namespace GW2Emu.AuthServer.Handlers
{
    public class GameServerHandler
    {
        public static void SendGameServerInfo(SecurePacketBasedClient client)
        {
            P25_GameServerInfo gameServerInfo = new P25_GameServerInfo();
            gameServerInfo.Location = 2007;
            gameServerInfo.Population = 0;
            gameServerInfo.TransferCost = 100;
            gameServerInfo.Unknown3 = 168;
            client.SendPacket(gameServerInfo);

            P24_Unknown p24 = new P24_Unknown();
            client.SendPacket(p24);

            P04_ClientSync clientSync = new P04_ClientSync();
            clientSync.Unknown0 = AuthServerDataContainer.Data.SyncCount;
            clientSync.Unknown1 = 0;
            clientSync.Unknown2 = 49;
            clientSync.Unknown3 = 7004;
            clientSync.Unknown4 = 823;
            client.SendPacket(clientSync);
        }
    }
}
