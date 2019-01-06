using System;


namespace GW2Emu.Common
{
    public class Item
    {
        public ushort ItemId;
        public ushort Flag;

        public virtual void Deserialize(Deserializer deserializer)
        {
            ItemId = deserializer.ReadUInt16();
            Flag = deserializer.ReadUInt16();
        }

        public virtual void Serialize(Serializer serializer)
        {
            serializer.Write(ItemId);
            serializer.Write(Flag);
        }
    }
}
