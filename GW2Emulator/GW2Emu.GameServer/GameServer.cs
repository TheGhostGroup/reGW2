using System;
using System.Net;
using GW2Emu.Common;

namespace GW2Emu.GameServer
{
    public class GameServer : Server<SecurePacketBasedClient>
    {
        private readonly GameServerPacketManager packetManager = new GameServerPacketManager();

        public void Execute(string ipAddress, int port)
        {
            SetState(packetManager);
            Start2(IPAddress.Parse(ipAddress), port, 0, 100);
        }
    }
}