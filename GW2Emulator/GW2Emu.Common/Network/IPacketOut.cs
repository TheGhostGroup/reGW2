using System;

namespace GW2Emu.Common
{
    public interface IPacketOut
    {
        void Serialize(PacketWriter writer);
    }
}
