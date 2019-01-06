using System;
using System.IO;
using System.Net;
using GW2Emu.Common;
namespace GW2Emu.GameServer.In
{
    public class P001_Unknown
    {
        public P001_Unknown(PacketReader reader)
        {
        }
    }

    public class P002_Unknown
    {
        public int Unknown0;

        public P002_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P003_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public P003_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P004_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public Vector4 Unknown3;
        public int Unknown4;
        public Vector4 Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;

        public P004_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVector4();
            Unknown4 = reader.ReadVarint();
            Unknown5 = reader.ReadVector4();
            Unknown6 = reader.ReadByte();
            Unknown7 = reader.ReadByte();
            Unknown8 = reader.ReadByte();
        }
    }

    public class P005_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public short Unknown5;

        public P005_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadInt16();
        }
    }

    public class P006_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;
        public int Unknown6;
        public Optional<Vector4> Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        public short Unknown11;
        public short Unknown12;
        public short Unknown13;

        public P006_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadVector4();
            Unknown6 = reader.ReadVarint();
            if (reader.ReadBoolean())
            {
                Unknown7 = new Optional<Vector4>(reader.ReadVector4());
            }
            else
            {
                Unknown7 = null;
            }
            Unknown8 = reader.ReadByte();
            Unknown9 = reader.ReadByte();
            Unknown10 = reader.ReadByte();
            Unknown11 = reader.ReadInt16();
            Unknown12 = reader.ReadInt16();
            Unknown13 = reader.ReadInt16();
        }
    }

    public class P007_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;
        public int Unknown6;
        public Vector4 Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;

        public P007_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadVector4();
            Unknown6 = reader.ReadVarint();
            Unknown7 = reader.ReadVector4();
            Unknown8 = reader.ReadByte();
            Unknown9 = reader.ReadByte();
            Unknown10 = reader.ReadByte();
        }
    }

    public class P008_StartMovement
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;
        public int Unknown6;
        public Vector4 Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        public Vector3 Unknown11;
        public short Unknown12;
        public short Unknown13;
        public struct Struct14
        {
            public int Unknown15;
            public int Unknown16;
            public Optional<WorldPosition> Unknown17;

            public Struct14(PacketReader reader)
            {
                Unknown15 = reader.ReadVarint();
                Unknown16 = reader.ReadVarint();
                if (reader.ReadBoolean())
                {
                    Unknown17 = new Optional<WorldPosition>(reader.ReadWorldPosition());
                }
                else
                {
                    Unknown17 = null;
                }
            }
        }
        public Optional<Struct14> Unknown18;

        public P008_StartMovement(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadVector4();
            Unknown6 = reader.ReadVarint();
            Unknown7 = reader.ReadVector4();
            Unknown8 = reader.ReadByte();
            Unknown9 = reader.ReadByte();
            Unknown10 = reader.ReadByte();
            Unknown11 = reader.ReadVector3();
            Unknown12 = reader.ReadInt16();
            Unknown13 = reader.ReadInt16();
            if (reader.ReadBoolean())
            {
                Unknown18 = new Optional<Struct14>(new Struct14(reader));
            }
            else
            {
                Unknown18 = null;
            }
        }
    }

    public class P009_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public float Unknown5;
        public short Unknown6;
        public short Unknown7;

        public P009_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadSingle();
            Unknown6 = reader.ReadInt16();
            Unknown7 = reader.ReadInt16();
        }
    }

    public class P010_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public WorldPosition Unknown5;
        public short Unknown6;
        public short Unknown7;
        public byte Unknown8;

        public P010_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadWorldPosition();
            Unknown6 = reader.ReadInt16();
            Unknown7 = reader.ReadInt16();
            Unknown8 = reader.ReadByte();
        }
    }

    public class P011_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public float Unknown4;

        public P011_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
            Unknown4 = reader.ReadSingle();
        }
    }

    public class P012_Unknown
    {
        public short Unknown0;

        public P012_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
        }
    }

    public class P013_Move
    {
        public int MoveTimer1;
        public int MoveTimer2;
        public Vector3 NewPos;
        public int Unknown3;
        public byte ShouldSync;
        public byte Unknown5;

        public P013_Move(PacketReader reader)
        {
            MoveTimer1 = reader.ReadVarint();
            MoveTimer2 = reader.ReadVarint();
            NewPos = reader.ReadVector3();
            Unknown3 = reader.ReadVarint();
            ShouldSync = reader.ReadByte();
            Unknown5 = reader.ReadByte();
        }
    }

    public class P014_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public short Unknown5;
        public short Unknown6;

        public P014_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
            Unknown5 = reader.ReadInt16();
            Unknown6 = reader.ReadInt16();
        }
    }

    public class P015_Skill
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;

        public P015_Skill(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = reader.ReadByte();
            }
        }
    }

    public class P016_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;

        public P016_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadWorldPosition();
        }
    }

    public class P017_Unknown
    {
        public int Unknown0;

        public P017_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P018_Unknown
    {
        public int Unknown0;

        public P018_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P019_Unknown
    {
        public P019_Unknown(PacketReader reader)
        {
        }
    }

    public class P020_Unknown
    {
        public short Unknown0;
        public short Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public P020_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadInt16();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P021_Unknown
    {
        public short Unknown0;
        public short Unknown1;
        public byte Unknown2;
        public short Unknown3;
        public byte Unknown4;

        public P021_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadInt16();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadInt16();
            Unknown4 = reader.ReadByte();
        }
    }

    public class P022_Unknown
    {
        public short Unknown0;
        public short Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public P022_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadInt16();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P023_Unknown
    {
        public short Unknown0;
        public short Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public P023_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadInt16();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P024_Unknown
    {
        public P024_Unknown(PacketReader reader)
        {
        }
    }

    public class P025_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P025_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P026_Unknown
    {
        public P026_Unknown(PacketReader reader)
        {
        }
    }

    public class P028_Unknown
    {
        public int Unknown0;

        public P028_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P029_Unknown
    {
        public P029_Unknown(PacketReader reader)
        {
        }
    }

    public class P030_Unknown
    {
        public int[] Unknown0;
        public int Unknown1;

        public P030_Unknown(PacketReader reader)
        {
            Unknown0 = new int[4];
            for (int i = 0; i < Unknown0.Length; i++)
            {
                Unknown0[i] = reader.ReadVarint();
            }
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P031_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P031_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P032_Unknown
    {
        public byte Unknown0;
        public byte Unknown1;

        public P032_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P033_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public P033_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P034_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P034_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P035_Unknown
    {
        public byte Unknown0;

        public P035_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P036_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P036_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P037_Unknown
    {
        public int Unknown0;

        public P037_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P038_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public P038_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadVarint();
        }
    }

    public class P039_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P039_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P040_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public P040_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P041_Unknown
    {
        public int Unknown0;

        public P041_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P042_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P042_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P043_Unknown
    {
        public byte Unknown0;

        public P043_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P044_Unknown
    {
        public byte Unknown0;
        public int Unknown1;

        public P044_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P045_Unknown
    {
        public P045_Unknown(PacketReader reader)
        {
        }
    }

    public class P046_Unknown
    {
        public byte Unknown0;

        public P046_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P047_Unknown
    {
        public byte Unknown0;
        public int Unknown1;

        public P047_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P048_Unknown
    {
        public byte Unknown0;
        public string Unknown1;

        public P048_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P049_Unknown
    {
        public Vector2[] Unknown0;
        public int Unknown1;

        public P049_Unknown(PacketReader reader)
        {
            byte Unknown0Length = reader.ReadByte();
            if (Unknown0Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown0 = new Vector2[Unknown0Length];
            for (int i = 0; i < Unknown0.Length; i++)
            {
                Unknown0[i] = reader.ReadVector2();
            }
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P050_Unknown
    {
        public byte Unknown0;
        public Vector2[] Unknown1;
        public int Unknown2;

        public P050_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            byte Unknown1Length = reader.ReadByte();
            if (Unknown1Length > 255)
            {
                throw new InvalidDataException();
            }
            Unknown1 = new Vector2[Unknown1Length];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadVector2();
            }
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P051_Unknown
    {
        public int Unknown0;
        public byte Unknown1;

        public P051_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P052_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public P052_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P053_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;

        public P053_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
            Unknown4 = reader.ReadByte();
        }
    }

    public class P054_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public P054_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P055_Unknown
    {
        public P055_Unknown(PacketReader reader)
        {
        }
    }

    public class P056_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P056_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P057_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P057_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P058_Unknown
    {
        public int Unknown0;

        public P058_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P059_Unknown
    {
        public int Unknown0;

        public P059_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P060_Unknown
    {
        public int Unknown0;
        public int[] Unknown1;

        public P060_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = new int[4];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadVarint();
            }
        }
    }

    public class P061_Unknown
    {
        public P061_Unknown(PacketReader reader)
        {
        }
    }

    public class P062_Unknown
    {
        public int Unknown0;
        public WorldPosition Unknown1;
        public float Unknown2;

        public P062_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadWorldPosition();
            Unknown2 = reader.ReadSingle();
        }
    }

    public class P063_Unknown
    {
        public byte Unknown0;

        public P063_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P064_Unknown
    {
        public Vector2 Unknown0;
        public byte Unknown1;

        public P064_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVector2();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P065_Unknown
    {
        public byte[] Unknown0;

        public P065_Unknown(PacketReader reader)
        {
            ushort Unknown0Length = reader.ReadUInt16();
            if (Unknown0Length > 8066)
            {
                throw new InvalidDataException();
            }
            Unknown0 = new byte[Unknown0Length];
            for (int i = 0; i < Unknown0.Length; i++)
            {
                Unknown0[i] = reader.ReadByte();
            }
        }
    }

    public class P066_Unknown
    {
        public int Unknown0;

        public P066_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P067_Unknown
    {
        public byte Unknown0;

        public P067_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P068_Unknown
    {
        public int Unknown0;

        public P068_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P069_Unknown
    {
        public P069_Unknown(PacketReader reader)
        {
        }
    }

    public class P070_Unknown
    {
        public int Unknown0;

        public P070_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P071_Unknown
    {
        public int Unknown0;

        public P071_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P072_Unknown
    {
        public int Unknown0;

        public P072_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P073_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;

        public P073_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P074_Unknown
    {
        public int Unknown0;

        public P074_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P075_Unknown
    {
        public int Unknown0;

        public P075_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P076_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public P076_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P077_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public string Unknown3;

        public P077_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadUtf16String();
        }
    }

    public class P078_Unknown
    {
        public P078_Unknown(PacketReader reader)
        {
        }
    }

    public class P079_Unknown
    {
        public int Unknown0;

        public P079_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P080_Unknown
    {
        public int Unknown0;
        public byte Unknown1;

        public P080_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P081_Unknown
    {
        public byte Unknown0;
        public byte Unknown1;

        public P081_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P082_Unknown
    {
        public P082_Unknown(PacketReader reader)
        {
        }
    }

    public class P083_Unknown
    {
        public int Unknown0;
        public string Unknown1;

        public P083_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P084_Unknown
    {
        public string Unknown0;
        public byte Unknown1;

        public P084_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P085_Unknown
    {
        public byte Unknown0;

        public P085_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P086_Unknown
    {
        public string Unknown0;
        public int Unknown1;

        public P086_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P087_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P087_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P088_Unknown
    {
        public int Unknown0;

        public P088_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P089_Unknown
    {
        public int Unknown0;
        public int[] Unknown1;
        public UID Unknown2;
        public byte Unknown3;

        public P089_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            byte Unknown1Length = reader.ReadByte();
            if (Unknown1Length > 161)
            {
                throw new InvalidDataException();
            }
            Unknown1 = new int[Unknown1Length];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadVarint();
            }
            Unknown2 = reader.ReadUID();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P090_Unknown
    {
        public string Unknown0;

        public P090_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
        }
    }

    public class P091_Unknown
    {
        public byte Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public P091_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P092_Unknown
    {
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public P092_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P093_Unknown
    {
        public P093_Unknown(PacketReader reader)
        {
        }
    }

    public class P094_Unknown
    {
        public byte Unknown0;
        public string Unknown1;

        public P094_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P095_Unknown
    {
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public P095_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P096_Unknown
    {
        public byte Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public P096_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P097_Unknown
    {
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public P097_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P098_Unknown
    {
        public int Unknown0;
        public short Unknown1;

        public P098_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadInt16();
        }
    }

    public class P099_Unknown
    {
        public int Unknown0;
        public byte Unknown1;

        public P099_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P100_Unknown
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public string[] Unknown3;

        public P100_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUtf16String();
            Unknown2 = reader.ReadUtf16String();
            Unknown3 = new string[3];
            for (int i = 0; i < Unknown3.Length; i++)
            {
                Unknown3[i] = reader.ReadUtf16String();
            }
        }
    }

    public class P101_Unknown
    {
        public short Unknown0;
        public short Unknown1;
        public short[] Unknown2;
        public byte Unknown3;

        public P101_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadInt16();
            Unknown2 = new short[3];
            for (int i = 0; i < Unknown2.Length; i++)
            {
                Unknown2[i] = reader.ReadInt16();
            }
            Unknown3 = reader.ReadByte();
        }
    }

    public class P102_Unknown
    {
        public int Unknown0;
        public short Unknown1;

        public P102_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadInt16();
        }
    }

    public class P103_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public string Unknown2;
        public string Unknown3;

        public P103_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadUtf16String();
            Unknown3 = reader.ReadUtf16String();
        }
    }

    public class P104_Unknown
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public string Unknown3;

        public P104_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadUtf16String();
        }
    }

    public class P105_Unknown
    {
        public int Unknown0;
        public string Unknown1;

        public P105_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P106_Unknown
    {
        public int Unknown0;
        public short[] Unknown1;

        public P106_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            byte Unknown1Length = reader.ReadByte();
            if (Unknown1Length > 21)
            {
                throw new InvalidDataException();
            }
            Unknown1 = new short[Unknown1Length];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadInt16();
            }
        }
    }

    public class P107_Unknown
    {
        public byte Unknown0;
        public short Unknown1;
        public int Unknown2;

        public P107_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadInt16();
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P108_Unknown
    {
        public P108_Unknown(PacketReader reader)
        {
        }
    }

    public class P109_Unknown
    {
        public int Unknown0;

        public P109_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P110_Unknown
    {
        public int Unknown0;

        public P110_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P111_Unknown
    {
        public int Unknown0;

        public P111_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P112_Unknown
    {
        public P112_Unknown(PacketReader reader)
        {
        }
    }

    public class P113_Unknown
    {
        public int Unknown0;

        public P113_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P114_Unknown
    {
        public int Unknown0;

        public P114_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P115_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P115_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P116_Unknown
    {
        public int Unknown0;
        public byte Unknown1;

        public P116_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P117_Unknown
    {
        public P117_Unknown(PacketReader reader)
        {
        }
    }

    public class P118_Unknown
    {
        public P118_Unknown(PacketReader reader)
        {
        }
    }

    public class P119_Unknown
    {
        public P119_Unknown(PacketReader reader)
        {
        }
    }

    public class P120_Unknown
    {
        public byte Unknown0;
        public int Unknown1;
        public short Unknown2;
        public string Unknown3;
        public int Unknown4;
        public short Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public short Unknown9;
        public int Unknown10;
        public short Unknown11;
        public short Unknown12;
        public short Unknown13;
        public short Unknown14;
        public short Unknown15;
        public byte Unknown16;
        public UID Unknown17;
        public string Unknown18;

        public P120_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadInt16();
            Unknown3 = reader.ReadUtf16String();
            Unknown4 = reader.ReadVarint();
            Unknown5 = reader.ReadInt16();
            Unknown6 = reader.ReadVarint();
            Unknown7 = reader.ReadVarint();
            Unknown8 = reader.ReadVarint();
            Unknown9 = reader.ReadInt16();
            Unknown10 = reader.ReadVarint();
            Unknown11 = reader.ReadInt16();
            Unknown12 = reader.ReadInt16();
            Unknown13 = reader.ReadInt16();
            Unknown14 = reader.ReadInt16();
            Unknown15 = reader.ReadInt16();
            Unknown16 = reader.ReadByte();
            Unknown17 = reader.ReadUID();
            Unknown18 = reader.ReadUtf16String();
        }
    }

    public class P121_Unknown
    {
        public int Unknown0;

        public P121_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P122_Unknown
    {
        public byte Unknown0;

        public P122_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P123_Unknown
    {
        public byte Unknown0;
        public UID Unknown1;

        public P123_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadUID();
        }
    }

    public class P124_Unknown
    {
        public P124_Unknown(PacketReader reader)
        {
        }
    }

    public class P125_Unknown
    {
        public P125_Unknown(PacketReader reader)
        {
        }
    }

    public class P126_Unknown
    {
        public int Unknown0;

        public P126_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P127_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P127_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P128_Unknown
    {
        public int Unknown0;

        public P128_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P129_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P129_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P130_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P130_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P131_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P131_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P132_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P132_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P133_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P133_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P134_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public P134_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P135_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public short Unknown2;
        public int Unknown3;

        public P135_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadInt16();
            Unknown3 = reader.ReadVarint();
        }
    }

    public class P136_Unknown
    {
        public int Unknown0;
        public struct Struct1
        {
            public int Unknown2;
            public byte Unknown3;

            public Struct1(PacketReader reader)
            {
                Unknown2 = reader.ReadVarint();
                Unknown3 = reader.ReadByte();
            }
        }
        public Struct1[] Unknown4;

        public P136_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            byte Unknown4Length = reader.ReadByte();
            if (Unknown4Length > 31)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new Struct1[Unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = new Struct1(reader);
            }
        }
    }

    public class P137_Unknown
    {
        public string Unknown0;

        public P137_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
        }
    }

    public class P138_Unknown
    {
        public string Unknown0;
        public string Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public P138_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
            Unknown1 = reader.ReadUtf16String();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadByte();
        }
    }

    public class P139_Unknown
    {
        public P139_Unknown(PacketReader reader)
        {
        }
    }

    public class P140_Unknown
    {
        public byte Unknown0;

        public P140_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P141_Unknown
    {
        public P141_Unknown(PacketReader reader)
        {
        }
    }

    public class P142_Unknown
    {
        public byte Unknown0;

        public P142_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P143_Unknown
    {
        public P143_Unknown(PacketReader reader)
        {
        }
    }

    public class P144_Unknown
    {
        public P144_Unknown(PacketReader reader)
        {
        }
    }

    public class P145_Unknown
    {
        public P145_Unknown(PacketReader reader)
        {
        }
    }

    public class P146_Unknown
    {
        public P146_Unknown(PacketReader reader)
        {
        }
    }

    public class P147_Unknown
    {
        public string Unknown0;
        public byte[] Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public int Unknown4;
        public byte[] Unknown5;
        public int[] Unknown6;

        public P147_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
            Unknown1 = new byte[48];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadByte();
            }
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadByte();
            Unknown4 = reader.ReadVarint();
            byte Unknown5Length = reader.ReadByte();
            if (Unknown5Length > 33)
            {
                throw new InvalidDataException();
            }
            Unknown5 = new byte[Unknown5Length];
            for (int i = 0; i < Unknown5.Length; i++)
            {
                Unknown5[i] = reader.ReadByte();
            }
            Unknown6 = new int[24];
            for (int i = 0; i < Unknown6.Length; i++)
            {
                Unknown6[i] = reader.ReadVarint();
            }
        }
    }

    public class P148_Unknown
    {
        public P148_Unknown(PacketReader reader)
        {
        }
    }

    public class P149_Unknown
    {
        public P149_Unknown(PacketReader reader)
        {
        }
    }

    public class P150_Unknown
    {
        public string Unknown0;
        public string Unknown1;

        public P150_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P151_Unknown
    {
        public P151_Unknown(PacketReader reader)
        {
        }
    }

    public class P152_Unknown
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public Vector4 Unknown3;
        public int Unknown4;
        public Vector4 Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;

        public P152_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
            Unknown3 = reader.ReadVector4();
            Unknown4 = reader.ReadVarint();
            Unknown5 = reader.ReadVector4();
            Unknown6 = reader.ReadByte();
            Unknown7 = reader.ReadByte();
            Unknown8 = reader.ReadByte();
        }
    }

    public class P153_Unknown
    {
        public int Unknown0;

        public P153_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P154_Unknown
    {
        public byte Unknown0;
        public byte Unknown1;

        public P154_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadByte();
        }
    }

    public class P155_AccountEmail
    {
        public string Email;
        public byte Unknown1;
        public byte Unknown2;

        public P155_AccountEmail(PacketReader reader)
        {
            Email = reader.ReadUtf16String();
            Unknown1 = reader.ReadByte();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P156_Unknown
    {
        public byte Unknown0;

        public P156_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P157_Unknown
    {
        public byte Unknown0;

        public P157_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P158_Unknown
    {
        public UID Unknown0;

        public P158_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P159_Unknown
    {
        public P159_Unknown(PacketReader reader)
        {
        }
    }

    public class P160_Unknown
    {
        public byte Unknown0;

        public P160_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P161_Unknown
    {
        public byte Unknown0;

        public P161_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P162_Unknown
    {
        public short Unknown0;

        public P162_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
        }
    }

    public class P163_Unknown
    {
        public int Unknown0;
        public byte[] Unknown1;

        public P163_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = new byte[45];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadByte();
            }
        }
    }

    public class P164_Unknown
    {
        public UID Unknown0;

        public P164_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P165_Unknown
    {
        public byte Unknown0;

        public P165_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P166_Unknown
    {
        public int Unknown0;

        public P166_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P167_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P167_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P168_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P168_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P169_Unknown
    {
        public byte Unknown0;
        public string Unknown1;
        public byte Unknown2;

        public P169_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadUtf16String();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P170_Unknown
    {
        public P170_Unknown(PacketReader reader)
        {
        }
    }

    public class P171_Unknown
    {
        public UID Unknown0;
        public string Unknown1;

        public P171_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P172_Unknown
    {
        public UID[] Unknown0;

        public P172_Unknown(PacketReader reader)
        {
            byte Unknown0Length = reader.ReadByte();
            if (Unknown0Length > 49)
            {
                throw new InvalidDataException();
            }
            Unknown0 = new UID[Unknown0Length];
            for (int i = 0; i < Unknown0.Length; i++)
            {
                Unknown0[i] = reader.ReadUID();
            }
        }
    }

    public class P173_Unknown
    {
        public byte Unknown0;
        public UID Unknown1;

        public P173_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadUID();
        }
    }

    public class P174_Unknown
    {
        public UID Unknown0;

        public P174_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P175_Unknown
    {
        public UID Unknown0;

        public P175_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P176_Unknown
    {
        public UID Unknown0;
        public UID Unknown1;

        public P176_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
            Unknown1 = reader.ReadUID();
        }
    }

    public class P177_Unknown
    {
        public P177_Unknown(PacketReader reader)
        {
        }
    }

    public class P178_Unknown
    {
        public P178_Unknown(PacketReader reader)
        {
        }
    }

    public class P179_Unknown
    {
        public P179_Unknown(PacketReader reader)
        {
        }
    }

    public class P180_Unknown
    {
        public UID Unknown0;

        public P180_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P181_Unknown
    {
        public int Unknown0;

        public P181_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P182_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public P182_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadVarint();
            Unknown4 = reader.ReadVarint();
        }
    }

    public class P183_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public P183_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P184_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public P184_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadVarint();
            Unknown4 = reader.ReadVarint();
        }
    }

    public class P185_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P185_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P186_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public P186_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P187_Unknown
    {
        public int Unknown0;

        public P187_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P188_Unknown
    {
        public int Unknown0;

        public P188_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P189_Unknown
    {
        public P189_Unknown(PacketReader reader)
        {
        }
    }

    public class P190_Unknown
    {
        public short Unknown0;

        public P190_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
        }
    }

    public class P191_Unknown
    {
        public short Unknown0;

        public P191_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadInt16();
        }
    }

    public class P192_Unknown
    {
        public P192_Unknown(PacketReader reader)
        {
        }
    }

    public class P193_Unknown
    {
        public byte Unknown0;
        public int Unknown1;

        public P193_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P194_Unknown
    {
        public int Unknown0;
        public int Unknown1;

        public P194_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
        }
    }

    public class P195_Unknown
    {
        public P195_Unknown(PacketReader reader)
        {
        }
    }

    public class P196_Unknown
    {
        public int Unknown0;
        public UID Unknown1;

        public P196_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUID();
        }
    }

    public class P197_Unknown
    {
        public UID Unknown0;

        public P197_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P198_Unknown
    {
        public UID Unknown0;

        public P198_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadUID();
        }
    }

    public class P199_Unknown
    {
        public int Unknown0;
        public int[] Unknown1;
        public string Unknown2;
        public string Unknown3;
        public byte Unknown4;
        public byte Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public short Unknown9;
        public byte Unknown10;
        public byte Unknown11;

        public P199_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            byte Unknown1Length = reader.ReadByte();
            if (Unknown1Length > 51)
            {
                throw new InvalidDataException();
            }
            Unknown1 = new int[Unknown1Length];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadVarint();
            }
            Unknown2 = reader.ReadUtf16String();
            Unknown3 = reader.ReadUtf16String();
            Unknown4 = reader.ReadByte();
            Unknown5 = reader.ReadByte();
            Unknown6 = reader.ReadByte();
            Unknown7 = reader.ReadByte();
            Unknown8 = reader.ReadByte();
            Unknown9 = reader.ReadInt16();
            Unknown10 = reader.ReadByte();
            Unknown11 = reader.ReadByte();
        }
    }

    public class P200_Unknown
    {
        public P200_Unknown(PacketReader reader)
        {
        }
    }

    public class P201_Unknown
    {
        public int Unknown0;

        public P201_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P203_Unknown
    {
        public int Unknown0;

        public P203_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P204_Unknown
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;

        public P204_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUtf16String();
            Unknown2 = reader.ReadUtf16String();
        }
    }

    public class P205_Unknown
    {
        public P205_Unknown(PacketReader reader)
        {
        }
    }

    public class P206_Unknown
    {
        public int Unknown0;
        public byte Unknown1;

        public P206_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadByte();
        }
    }
}
