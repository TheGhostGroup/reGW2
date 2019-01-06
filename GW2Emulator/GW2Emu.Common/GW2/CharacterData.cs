using System;


namespace GW2Emu.Common
{
    public class CharacterData
    {
        public byte Unknown0 = 0x07; // Always 07
        public ushort MapId; // Character background
        public byte MapCompletion;
        public byte Level;
        public byte Class; // 01 - Gardian, 05 - Thief, 06 - Elementalist, 08 Necro
        public Appearance Appearance = new Appearance();
        public Equipment Equipment = new Equipment();
        public float Unknown1; // 1,2,3,4 = All at 0 on creation
        public float Unknown2;
        public float Unknown3;
        public float Unknown4;
        public float Unknown5; // Not 0 on creation

        public void Deserialize(Deserializer deserializer)
        {
            Unknown0 = deserializer.ReadByte();
            MapId = deserializer.ReadUInt16();
            MapCompletion = deserializer.ReadByte();
            Level = deserializer.ReadByte();
            Class = deserializer.ReadByte();
            Appearance.Deserialize(deserializer);
            Equipment.Deserialize(deserializer);
            Unknown1 = deserializer.ReadSingle();
            Unknown2 = deserializer.ReadSingle();
            Unknown3 = deserializer.ReadSingle();
            Unknown4 = deserializer.ReadSingle();
            Unknown5 = deserializer.ReadSingle();
        }

        public void Serialize(Serializer serializer)
        {
            serializer.Write(Unknown0);
            serializer.Write(MapId);
            serializer.Write(MapCompletion);
            serializer.Write(Level);
            serializer.Write(Class);
            Appearance.Serialize(serializer);
            Equipment.Serialize(serializer);
            serializer.Write(Unknown1);
            serializer.Write(Unknown2);
            serializer.Write(Unknown3);
            serializer.Write(Unknown4);
            serializer.Write(Unknown5);
        }
    }
}
