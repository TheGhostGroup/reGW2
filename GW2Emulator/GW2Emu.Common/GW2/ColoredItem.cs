using System;


namespace GW2Emu.Common
{
    public class ColoredItem : Item
    {
        public ushort Color1;
        public ushort Color2;
        public ushort Color3;
        public ushort Color4;

        public override void Deserialize(Deserializer deserializer)
        {
            base.Deserialize(deserializer);
            Color1 = deserializer.ReadUInt16();
            Color2 = deserializer.ReadUInt16();
            Color3 = deserializer.ReadUInt16();
            Color4 = deserializer.ReadUInt16();
        }

        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write(Color1);
            serializer.Write(Color2);
            serializer.Write(Color3);
            serializer.Write(Color4);
        }
    }
}
