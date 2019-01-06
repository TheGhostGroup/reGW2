using System;

namespace GW2Emu.Common
{
    public abstract class PacketManager
    {
        public abstract bool OnPacketReceived(SecurePacketBasedClient client, Packet packet);

        protected void RaiseEvent<T>(PacketEventHandler<T> handler, SecurePacketBasedClient client, T packet)
        {
            if (handler != null)
            {
                handler(client, packet);
            }
            else
            {
                Console.WriteLine("Unhandled packet: " + packet.ToString());
            }
        }
    }
}