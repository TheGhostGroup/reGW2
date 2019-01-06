using System;
using System.IO;

namespace GW2Emu.Common
{
    public class Serializer : BinaryWriter
    {
        public Serializer() : base(new MemoryStream())
        {
        }

        public byte[] Data
        {
            get
            {
                return ((MemoryStream)BaseStream).ToArray();
            }
        }
    }
}
