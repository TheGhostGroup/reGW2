using System;

namespace RRL.GW2.Common.Network
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public abstract class APacketHandler<TConnection>
        where TConnection : Connection, new()
    {
        public abstract bool TryParsePacket(TConnection connection);

        public void Process(TConnection connection)
        {
            while (true)
            {
                int readIndex = connection.Buffer.ReadIndex;
                if (!TryParsePacket(connection))
                {
                    connection.Buffer.ReadIndex = readIndex;
                    break;
                }
            }

            if (connection.Buffer.ReadIndex == 0)
                return;

            if (connection.Buffer.ReadIndex == connection.Buffer.WriteIndex)
            {
                connection.Buffer.ReadIndex = connection.Buffer.WriteIndex = 0;
                return;
            }

            Buffer.BlockCopy(
                connection.Buffer.Data,
                connection.Buffer.ReadIndex,
                connection.Buffer.Data, 0,
                connection.Buffer.WriteIndex - connection.Buffer.ReadIndex);

            connection.Buffer.WriteIndex -= connection.Buffer.ReadIndex;
            connection.Buffer.ReadIndex = 0;
        }
    }
}
