using System;


namespace GW2Emu.Common
{
    public class Equipment
    {
        public Item MainHand = new Item();
        public Item OffHand = new Item();
        public byte Unknown0;
        public byte Unknown1;
        public ColoredItem Chest = new ColoredItem();
        public ColoredItem Boots = new ColoredItem();
        public ColoredItem Hands = new ColoredItem();
        public ColoredItem Legs = new ColoredItem();
        public ColoredItem Shoulders = new ColoredItem();
        public ColoredItem Mask = new ColoredItem();

        public void Deserialize(Deserializer deserializer)
        {
            MainHand.Deserialize(deserializer);
            OffHand.Deserialize(deserializer);
            Unknown0 = deserializer.ReadByte();
            Unknown1 = deserializer.ReadByte();
            Chest.Deserialize(deserializer);
            Boots.Deserialize(deserializer);
            Hands.Deserialize(deserializer);
            Legs.Deserialize(deserializer);
            Shoulders.Deserialize(deserializer);
            Mask.Deserialize(deserializer);
        }

        public void Serialize(Serializer serializer)
        {
            MainHand.Serialize(serializer);
            OffHand.Serialize(serializer);
            serializer.Write(Unknown0);
            serializer.Write(Unknown1);
            Chest.Serialize(serializer);
            Boots.Serialize(serializer);
            Hands.Serialize(serializer);
            Legs.Serialize(serializer);
            Shoulders.Serialize(serializer);
            Mask.Serialize(serializer);
        }
    }
}
