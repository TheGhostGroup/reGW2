using System;

namespace GW2Emu.Common
{
    public delegate void PacketEventHandler<T>(SecurePacketBasedClient client, T packet);
}
