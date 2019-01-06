using System;
using System.IO;

namespace GW2Emu.Common
{
    public class Deserializer : BinaryReader
    {
        public Deserializer(byte[] data) : base(new MemoryStream(data))
        {
        }
    }
}
