using System;

namespace RRL.GW2.Common.Crypto
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public static class Gw2Hash
    {
        public static uint[] GenerateRandomIntArray()
        {
            return new[]
                {
                    (uint) Utils.Random.Next(),
                    (uint) Utils.Random.Next(),
                    (uint) Utils.Random.Next(),
                    (uint) Utils.Random.Next(),
                    (uint) Utils.Random.Next(),
                };
        }

        public static byte[] GetBytes(uint[] data)
        {
            var bytes = new byte[data.Length*4];

            for (int i = 0; i < data.Length; i++)
            {
                bytes[i*4] = (byte) data[i];
                bytes[i*4 + 1] = (byte) (data[i] >> 8);
                bytes[i*4 + 2] = (byte) (data[i] >> 16);
                bytes[i*4 + 3] = (byte) (data[i] >> 24);
            }

            return bytes;
        }

        public static uint[] Hash(uint[] state)
        {
            // ReSharper disable JoinDeclarationAndInitializer
            uint eax, ebx, ecx, edx, edi;
            // ReSharper restore JoinDeclarationAndInitializer

            eax = state[0];
            edx = state[1];
            eax += 0x9FB498B3u;
            ecx = Rol(eax, 5);
            ecx += edx + 0x66B0CD0Du;
            edx = Rol(ecx, 5);
            edx += state[2];
            edi = eax;
            edi &= 0x22222222u;
            edi = ~edi;
            edi &= 0x7BF36AE2u;
            eax = Rol(eax, 30);
            edx += edi + 0xF33D5697u;
            edi = Rol(edx, 5);
            edi += state[3];
            ebx = eax;
            ebx ^= 0x59D148C0u;
            ebx &= ecx;
            ebx ^= 0x59D148C0u;
            edi += ebx + 0xD675E47Bu;
            ecx = Rol(ecx, 0x1e);
            ebx = eax;
            ebx ^= ecx;
            ebx &= edx;
            ebx ^= eax;
            ebx += state[4];
            state[4] += eax;
            ebx += state[0];
            eax = ecx;
            ecx = state[1];
            ecx += edi;
            edi = Rol(edi, 5);
            edx = Rol(edx, 0x1e);
            state[2] += edx;
            edx = eax;
            state[3] += edx;
            state[0] = ebx + edi + 0xB453C259u;
            state[1] = ecx;

            return state;
        }

        public static byte[] Xor(byte[] value, byte[] key)
        {
            byte[] xorValue = new byte[Math.Min(value.Length, key.Length)];

            for (int i = 0; i < xorValue.Length; i++)
                xorValue[i] = (byte) (value[i] ^ key[i]);

            return xorValue;
        }

        private static uint Rol(uint value, uint x)
        {
            return value << (int) x | value >> (int) (32 - x);
        }
    }
}