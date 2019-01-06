using System;
using System.Net;
using GW2Emu.Common;
using GW2Emu.Common.MongoDB;
using In = GW2Emu.AuthServer.In;
using Out = GW2Emu.AuthServer.In;

namespace GW2Emu.AuthServer.Handlers
{
    public class CharacterSelectionHandler
    {
        public CharacterSelectionHandler(AuthServerPacketManager packetManager)
        {
            packetManager.P29_Unknown += HandleCreateCharacter;
        }

        private void HandleCreateCharacter(SecurePacketBasedClient client, In.P29_Unknown packet)
        {
            Out.P20_ReferToGameServer referToGameServer = new Out.P20_ReferToGameServer();
            referToGameServer.ConnectionInfo = new IPEndPoint(IPAddress.Loopback, 0);
            referToGameServer.Unknown0 = 3;
            referToGameServer.Unknown1 = 1;
            client.SendPacket(referToGameServer);
        }
    }
}
