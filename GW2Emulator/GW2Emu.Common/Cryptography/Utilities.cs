using System;

namespace GW2Emu.Common.Cryptography
{
    public class Utilities
    {
        public static byte[] RandomBytes()
        {
            byte[] tmp = new byte[20];
            new Random().NextBytes(tmp);
            return tmp;
        }

        public static byte[] GetBytes(uint[] data)
        {
            byte[] tmp = new byte[20];

            tmp[0] = (byte)(data[0] & 0xFF);
            tmp[1] = (byte)(data[0] >> 8 & 0xFF);
            tmp[2] = (byte)(data[0] >> 16 & 0xFF);
            tmp[3] = (byte)(data[0] >> 24 & 0xFF);
            tmp[4] = (byte)(data[1] & 0xFF);
            tmp[5] = (byte)(data[1] >> 8 & 0xFF);
            tmp[6] = (byte)(data[1] >> 16 & 0xFF);
            tmp[7] = (byte)(data[1] >> 24 & 0xFF);
            tmp[8] = (byte)(data[2] & 0xFF);
            tmp[9] = (byte)(data[2] >> 8 & 0xFF);
            tmp[10] = (byte)(data[2] >> 16 & 0xFF);
            tmp[11] = (byte)(data[2] >> 24 & 0xFF);
            tmp[12] = (byte)(data[3] & 0xFF);
            tmp[13] = (byte)(data[3] >> 8 & 0xFF);
            tmp[14] = (byte)(data[3] >> 16 & 0xFF);
            tmp[15] = (byte)(data[3] >> 24 & 0xFF);
            tmp[16] = (byte)(data[4] & 0xFF);
            tmp[17] = (byte)(data[4] >> 8 & 0xFF);
            tmp[18] = (byte)(data[4] >> 16 & 0xFF);
            tmp[19] = (byte)(data[4] >> 24 & 0xFF);

            return tmp;
        }

        public static uint[] ToUintArray(byte[] data)
        {
            uint[] uints = new uint[5];

            uints[0] = data[0];
            uints[0] |= (uint)(data[1] << 8);
            uints[0] |= (uint)(data[2] << 16);
            uints[0] |= (uint)(data[3] << 24);
            uints[1] = data[4];
            uints[1] |= (uint)(data[5] << 8);
            uints[1] |= (uint)(data[6] << 16);
            uints[1] |= (uint)(data[7] << 24);
            uints[2] = data[8];
            uints[2] |= (uint)(data[9] << 8);
            uints[2] |= (uint)(data[10] << 16);
            uints[2] |= (uint)(data[11] << 24);
            uints[3] = data[12];
            uints[3] |= (uint)(data[13] << 8);
            uints[3] |= (uint)(data[14] << 16);
            uints[3] |= (uint)(data[15] << 24);
            uints[4] = data[16];
            uints[4] |= (uint)(data[17] << 8);
            uints[4] |= (uint)(data[18] << 16);
            uints[4] |= (uint)(data[19] << 24);

            return uints;
        }

        public static byte[] Reverse(byte[] data)
        {
            byte[] tmp = data;
            Array.Reverse(tmp);
            return tmp;
        }

        private static uint ROL(uint value, uint x)
        {
            return value << (int)x | value >> (int)(32 - x);
        }

        public static byte[] Hash(byte[] state)
        {
            uint[] tmpState = ToUintArray(state);

            uint eax, ebx, ecx, edx, edi;

            eax = tmpState[0];
            edx = tmpState[1];
            eax += 0x9FB498B3U;
            ecx = eax;
            ecx = ROL(ecx, 5);
            ecx = ecx + edx + 0x66B0CD0DU;
            edx = ecx;
            edx = ROL(edx, 5);
            edx += tmpState[2];
            edi = eax;
            edi &= 0x22222222U;
            edi = ~edi;
            edi &= 0x7BF36AE2U;
            eax = ROL(eax, 30);
            edx = edi + edx + 0xF33D5697U;
            edi = edx;
            edi = ROL(edi, 5);
            edi += tmpState[3];
            ebx = eax;
            ebx ^= 0x59D148C0U;
            ebx &= ecx;
            ebx ^= 0x59D148C0U;
            edi = ebx + edi + 0xD675E47BU;
            ecx = ROL(ecx, 0x1e);
            ebx = eax;
            ebx ^= ecx;
            ebx &= edx;
            ebx ^= eax;
            ebx += tmpState[4];
            tmpState[4] += eax;
            ebx += tmpState[0];
            eax = ecx;
            ecx = tmpState[1];
            ecx += edi;
            edi = ROL(edi, 5);
            edx = ROL(edx, 0x1e);
            tmpState[2] += edx;
            edx = eax;
            tmpState[3] += edx;
            edi = ebx + edi + 0xB453C259U;
            tmpState[0] = edi;
            tmpState[1] = ecx;

            return GetBytes(tmpState);
        }

        public static byte[] XOR(byte[] value, byte[] key)
        {
            byte[] xorValue = new byte[20];

            for (int i = 0; i < 20; i++)
            {
                xorValue[i] = (byte)(value[i] ^ key[i]);
            }

            return xorValue;
        }
    }
}