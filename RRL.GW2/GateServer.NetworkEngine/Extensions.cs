using System;
using RRL.GW2.Common.Network;

namespace GateServer.NetworkEngine
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    internal static class Extensions
    {
        public static int FindSequence(this ConnectionBuffer buffer, byte[] sequence)
        {
            for (int i = buffer.ReadIndex; i < buffer.WriteIndex - sequence.Length + 1; i++)
            {
                bool contains = true;

                for (int j = 0; j < sequence.Length; j++)
                    if (buffer.Data[i + j] != sequence[j])
                    {
                        contains = false;
                        break;
                    }

                if (contains) return i - buffer.ReadIndex;
            }

            return -1;
        }

        public static byte Read(this ConnectionBuffer buffer)
        {
            return buffer.Data[buffer.ReadIndex++];
        }

        public static byte[] Read(this ConnectionBuffer buffer, int size)
        {
            byte[] result = new byte[size];
            Buffer.BlockCopy(buffer.Data, buffer.ReadIndex, result, 0, size);
            buffer.ReadIndex += size;
            return result;
        }

        public static int ReadShort(this ConnectionBuffer buffer)
        {
            int result = buffer.Data[buffer.ReadIndex++] << 8;
            result += buffer.Data[buffer.ReadIndex++];

            return result;
        }

        public static int ReadShortInt(this ConnectionBuffer buffer)
        {
            int result = buffer.Data[buffer.ReadIndex++] << 16;
            result += buffer.Data[buffer.ReadIndex++] << 8;
            result += buffer.Data[buffer.ReadIndex++];

            return result;
        }
    }
}
