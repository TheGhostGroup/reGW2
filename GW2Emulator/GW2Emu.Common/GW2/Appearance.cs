using System;


namespace GW2Emu.Common
{
    public class Appearance
    {
        public byte[] Appearance1 = new byte[29];
        public byte Gender;
        public byte[] Appearance2 = new byte[15];

        public void Deserialize(Deserializer deserializer)
        {
            Appearance1 = deserializer.ReadBytes(Appearance1.Length);
            Gender = deserializer.ReadByte();
            Appearance2 = deserializer.ReadBytes(Appearance2.Length);
        }

        public void Serialize(Serializer serializer)
        {
            serializer.Write(Appearance1);
            serializer.Write(Gender);
            serializer.Write(Appearance2);
        }
    }
}
