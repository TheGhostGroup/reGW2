using System;
using GW2Emu.Common;
using In = GW2Emu.AuthServer.In;
using Out = GW2Emu.AuthServer.In;

namespace GW2Emu.AuthServer.Handlers
{
    public class ClientDisconnectHandler
    {
        public ClientDisconnectHandler(AuthServerPacketManager packetManager)
        {
            packetManager.P11_ClientDisconnect += HandleClientDisconnect;
        }

        private void HandleClientDisconnect(SecurePacketBasedClient client, In.P11_ClientDisconnect packet)
        {
            client.Stop();
        }
    }
}
