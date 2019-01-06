using System;
using GW2Emu.Common.Collections;
using GW2Emu.Common.Cryptography;
using MongoDB.Bson;

namespace GW2Emu.Common
{
    public class UID
    {
        public byte[] Data;

        public UID(byte[] data)
        {
            if (data.Length != 16)
            {
                throw new ArgumentOutOfRangeException();
            }

            Data = data;
        }

        public override string ToString()
        {
            string hex = string.Empty;

            hex += BytesToHex(new byte[] { Data[0], Data[1], Data[2], Data[3] }, true);
            hex += "-";
            hex += BytesToHex(new byte[] { Data[4], Data[5] }, true);
            hex += "-";
            hex += BytesToHex(new byte[] { Data[6], Data[7] }, true);
            hex += "-";
            hex += BytesToHex(new byte[] { Data[8], Data[9] }, false);
            hex += "-";
            hex += BytesToHex(new byte[] { Data[10], Data[11], Data[12], Data[13], Data[14], Data[15] }, false);

            return hex;
        }

        private string BytesToHex(byte[] input, bool reverse)
        {
            if (reverse)
            {
                Array.Reverse(input);
            }

            return BitConverter.ToString(input).Replace("-", string.Empty);
        }

        public static UID GenerateNewId()
        {
            byte[] bytes = new byte[16];
            new Random(DateTime.Now.Millisecond).NextBytes(bytes);
            return new UID(bytes);
        }
    }
}
