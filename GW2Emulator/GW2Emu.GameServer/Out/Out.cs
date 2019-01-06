using System;
using System.IO;
using System.Net;
using GW2Emu.Common;

namespace GW2Emu.GameServer.Out
{
    public class P001_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P001_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P002_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P002_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P003_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P003_Unknown);
        }
    }

    public class P004_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P004_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P005_Unknown : IPacketOut
    {
        public short Unknown0;
        public short Unknown1;
        public short Unknown2;
        public short Unknown3;
        public short Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P005_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P006_Unknown : IPacketOut
    {
        public long Unknown0;
        public long Unknown1;
        public long Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P006_Unknown);
            writer.WriteVarbyte(Unknown0, 2);
            writer.WriteVarbyte(Unknown1, 2);
            writer.WriteVarbyte(Unknown2, 2);
        }
    }

    public class P007_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P007_Unknown);
        }
    }

    public class P008_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P008_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P009_Unknown : IPacketOut
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

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P009_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVector4(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVector4(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
        }
    }

    public class P010_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public short Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P010_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
        }
    }

    public class P011_Unknown : IPacketOut
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

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P011_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
            writer.WriteVarint(Unknown6);
            if (Unknown7.IsPresent)
            {
                writer.WriteVector4(Unknown7.Value);
            }
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
            writer.Write(Unknown11);
            writer.Write(Unknown12);
            writer.Write(Unknown13);
        }
    }

    public class P012_AgentCreate : IPacketOut
    {
        public short AgentId;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public byte IsMonster;
        public int SpeciesId;
        public byte Unknown7;
        public byte Unknown8;
        public WorldPosition Unknown9;
        public short Unknown10;
        public short Unknown11;
        public float[] Unknown12;
        public float Unknown13;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P012_AgentCreate);
            writer.Write(AgentId);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(IsMonster);
            writer.WriteVarint(SpeciesId);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.WriteWorldPosition(Unknown9);
            writer.Write(Unknown10);
            writer.Write(Unknown11);
            for (int i = 0; i < Unknown12.Length; i++)
            {
                writer.Write(Unknown12[i]);
            }
            writer.Write(Unknown13);
        }
    }

    public class P013_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public byte Unknown5;
        public int Unknown6;
        public byte Unknown7;
        public float Unknown8;
        public WorldPosition Unknown9;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P013_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.WriteWorldPosition(Unknown9);
        }
    }

    public class P015_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public byte Unknown5;
        public int Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public Optional<long> Unknown9;
        public Vector4 Unknown10;
        public int Unknown11;
        public struct Struct12
        {
            public float Unknown13;
            public float Unknown14;
            public float Unknown15;
            public float Unknown16;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown13);
                writer.Write(Unknown14);
                writer.Write(Unknown15);
                writer.Write(Unknown16);
            }
        }
        public Optional<Struct12> Unknown17;
        public Optional<long> Unknown18;
        public Optional<long> Unknown19;
        public struct Struct20
        {
            public float Unknown21;
            public float Unknown22;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown21);
                writer.Write(Unknown22);
            }
        }
        public Optional<Struct20> Unknown23;
        public string Unknown24;
        public Optional<float> Unknown25;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P015_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            if (Unknown9.IsPresent)
            {
                writer.Write(Unknown9.Value);
            }
            writer.WriteVector4(Unknown10);
            writer.WriteVarint(Unknown11);
            if (Unknown17.IsPresent)
            {
                Unknown17.Value.Serialize(writer);
            }
            if (Unknown18.IsPresent)
            {
                writer.Write(Unknown18.Value);
            }
            if (Unknown19.IsPresent)
            {
                writer.Write(Unknown19.Value);
            }
            if (Unknown23.IsPresent)
            {
                Unknown23.Value.Serialize(writer);
            }
            writer.WriteUtf16String(Unknown24);
            if (Unknown25.IsPresent)
            {
                writer.Write(Unknown25.Value);
            }
        }
    }

    public class P016_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P016_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P017_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P017_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
        }
    }

    public class P018_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P018_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P019_AgentSpawn : IPacketOut
    {
        public short AgentId;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public WorldPosition Position;
        public short Unknown6;
        public short Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P019_AgentSpawn);
            writer.Write(AgentId);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteWorldPosition(Position);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
        }
    }

    public class P020_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;
        public WorldPosition Unknown4;
        public short Unknown5;
        public Vector3 Unknown6;
        public float Unknown7;
        public float Unknown8;
        public byte Unknown9;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P020_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteWorldPosition(Unknown3);
            writer.WriteWorldPosition(Unknown4);
            writer.Write(Unknown5);
            writer.WriteVector3(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
        }
    }

    public class P021_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P021_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P022_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P022_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P023_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P023_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P024_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P024_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P025_Unknown : IPacketOut
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

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P025_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteVector4(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
        }
    }

    public class P026_Unknown : IPacketOut
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
        public short Unknown11;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P026_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteVector4(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
            writer.Write(Unknown11);
        }
    }

    public class P027_Unknown : IPacketOut
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

            public void Serialize(PacketWriter writer)
            {
                writer.WriteVarint(Unknown15);
                writer.WriteVarint(Unknown16);
                if (Unknown17.IsPresent)
                {
                    writer.WriteWorldPosition(Unknown17.Value);
                }
            }
        }
        public Optional<Struct14> Unknown18;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P027_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteVector4(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
            writer.WriteVector3(Unknown11);
            writer.Write(Unknown12);
            writer.Write(Unknown13);
            if (Unknown18.IsPresent)
            {
                Unknown18.Value.Serialize(writer);
            }
        }
    }

    public class P028_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;
        public int Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public int Unknown10;
        public short Unknown11;
        public Optional<WorldPosition> Unknown12;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P028_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.WriteVarint(Unknown10);
            writer.Write(Unknown11);
            if (Unknown12.IsPresent)
            {
                writer.WriteWorldPosition(Unknown12.Value);
            }
        }
    }

    public class P029_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public WorldPosition Unknown5;
        public Vector4 Unknown6;
        public WorldPosition Unknown7;
        public Vector4 Unknown8;
        public int Unknown9;
        public byte Unknown10;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P029_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteWorldPosition(Unknown5);
            writer.WriteVector4(Unknown6);
            writer.WriteWorldPosition(Unknown7);
            writer.WriteVector4(Unknown8);
            writer.WriteVarint(Unknown9);
            writer.Write(Unknown10);
        }
    }

    public class P030_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;
        public Vector4 Unknown4;
        public byte Unknown5;
        public int Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P030_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteWorldPosition(Unknown3);
            writer.WriteVector4(Unknown4);
            writer.Write(Unknown5);
            writer.WriteVarint(Unknown6);
        }
    }

    public class P031_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public float Unknown5;
        public short Unknown6;
        public short Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P031_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
        }
    }

    public class P032_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public short Unknown5;
        public short Unknown6;
        public short Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P032_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
        }
    }

    public class P033_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P033_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteWorldPosition(Unknown3);
        }
    }

    public class P034_Unknown : IPacketOut
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

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P034_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteWorldPosition(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
        }
    }

    public class P035_Unknown : IPacketOut
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
        public WorldPosition Unknown11;
        public Vector3 Unknown12;
        public int Unknown13;
        public float Unknown14;
        public short Unknown15;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P035_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteVector4(Unknown7);
            writer.Write(Unknown8);
            writer.Write(Unknown9);
            writer.Write(Unknown10);
            writer.WriteWorldPosition(Unknown11);
            writer.WriteVector3(Unknown12);
            writer.WriteVarint(Unknown13);
            writer.Write(Unknown14);
            writer.Write(Unknown15);
        }
    }

    public class P036_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public WorldPosition Unknown5;
        public short Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P036_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteWorldPosition(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P037_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public WorldPosition Unknown5;
        public Vector4 Unknown6;
        public WorldPosition Unknown7;
        public Vector4 Unknown8;
        public int Unknown9;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P037_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteWorldPosition(Unknown5);
            writer.WriteVector4(Unknown6);
            writer.WriteWorldPosition(Unknown7);
            writer.WriteVector4(Unknown8);
            writer.WriteVarint(Unknown9);
        }
    }

    public class P038_Unknown : IPacketOut
    {
        public short Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P038_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P039_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public float Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P039_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P040_Unknown : IPacketOut
    {
        public short Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P040_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P044_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public short Unknown5;
        public short Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P044_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P045_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P045_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.WriteVector4(Unknown5);
        }
    }

    public class P046_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public long Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P046_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
            writer.Write(Unknown5);
        }
    }

    public class P047_LocalPlayerAgentId : IPacketOut
    {
        public short AgentId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P047_LocalPlayerAgentId);
            writer.Write(AgentId);
        }
    }

    public class P048_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P048_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
        }
    }

    public class P049_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P049_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteWorldPosition(Unknown3);
        }
    }

    public class P050_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P050_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P051_BankSlots : IPacketOut
    {
        public byte Slots;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P051_BankSlots);
            writer.Write(Slots);
        }
    }

    public class P052_BankGold : IPacketOut
    {
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P052_BankGold);
            writer.WriteVarint(Amount);
        }
    }

    public class P053_AccountGems : IPacketOut
    {
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P053_AccountGems);
            writer.WriteVarint(Amount);
        }
    }

    public class P054_Unknown : IPacketOut
    {
        public long Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P054_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P055_Unknown : IPacketOut
    {
        public short Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P055_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P056_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P056_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P057_CreatureAchievementPoints : IPacketOut
    {
        public int CreatureId;
        public int Points1;
        public int Points2;
        public int Points3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P057_CreatureAchievementPoints);
            writer.WriteVarint(CreatureId);
            writer.WriteVarint(Points1);
            writer.WriteVarint(Points2);
            writer.WriteVarint(Points3);
        }
    }

    public class P058_SkillPoints : IPacketOut
    {
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P058_SkillPoints);
            writer.WriteVarint(Amount);
        }
    }

    public class P059_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P059_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P060_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P060_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P061_AgentAttitude : IPacketOut
    {
        public int AgentId;
        public int AttitudeId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P061_AgentAttitude);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(AttitudeId);
        }
    }

    public class P062_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P062_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P063_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P063_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P064_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P064_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P065_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P065_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P066_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P066_Unknown);
        }
    }

    public class P067_AgentFinalize : IPacketOut
    {
        public int AgentId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P067_AgentFinalize);
            writer.WriteVarint(AgentId);
        }
    }

    public class P068_Unknown : IPacketOut
    {
        public short Unknown0;
        public short Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P068_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P069_Unknown : IPacketOut
    {
        public short Unknown0;
        public int[] Unknown1;
        public byte[] Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P069_Unknown);
            writer.Write(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
            writer.Write((byte)Unknown2.Length);
            for (int i = 0; i < Unknown2.Length; i++)
            {
                writer.Write(Unknown2[i]);
            }
        }
    }

    public class P070_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P070_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P071_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P071_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P072_AgentPlayerCoreStats : IPacketOut
    {
        public int AgentId;
        public byte[] Appearance;
        public byte Level;
        public byte ScaledLevel;
        public byte Profession;
        public int Experience;
        public int Karma;
        public struct Struct7
        {
            public short Unknown8;
            public short Unknown9;
            public short Unknown10;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown8);
                writer.Write(Unknown9);
                writer.Write(Unknown10);
            }
        }
        public Struct7[] Stats;
        public float Charisma;
        public float Dignity;
        public float Ferocity;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P072_AgentPlayerCoreStats);
            writer.WriteVarint(AgentId);
            for (int i = 0; i < Appearance.Length; i++)
            {
                writer.Write(Appearance[i]);
            }
            writer.Write(Level);
            writer.Write(ScaledLevel);
            writer.Write(Profession);
            writer.WriteVarint(Experience);
            writer.WriteVarint(Karma);
            for (int i = 0; i < Stats.Length; i++)
            {
                Stats[i].Serialize(writer);
            }
            writer.Write(Charisma);
            writer.Write(Dignity);
            writer.Write(Ferocity);
        }
    }

    public class P073_AgentNPCCoreStats : IPacketOut
    {
        public int AgentId;
        public byte[] Appearance;
        public byte ScaledLevel;
        public byte Level;
        public byte Profession;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P073_AgentNPCCoreStats);
            writer.WriteVarint(AgentId);
            for (int i = 0; i < Appearance.Length; i++)
            {
                writer.Write(Appearance[i]);
            }
            writer.Write(ScaledLevel);
            writer.Write(Level);
            writer.Write(Profession);
        }
    }

    public class P074_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P074_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P075_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P075_Unknown);
            writer.WriteVarint(Unknown0);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.Write(Unknown1[i]);
            }
        }
    }

    public class P076_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P076_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P077_AgentLevelUp : IPacketOut
    {
        public int AgentId;
        public byte NewLevel;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P077_AgentLevelUp);
            writer.WriteVarint(AgentId);
            writer.Write(NewLevel);
        }
    }

    public class P078_AgentModifyStat : IPacketOut
    {
        public int AgentId;
        public byte StatId;
        public short Overall;
        public short Bonus;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P078_AgentModifyStat);
            writer.WriteVarint(AgentId);
            writer.Write(StatId);
            writer.Write(Overall);
            writer.Write(Bonus);
        }
    }

    public class P079_AgentScaledLevel : IPacketOut
    {
        public int AgentId;
        public byte Level;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P079_AgentScaledLevel);
            writer.WriteVarint(AgentId);
            writer.Write(Level);
        }
    }

    public class P080_AgentExperience : IPacketOut
    {
        public int AgentId;
        public int OverallExperience;
        public short Bonus;
        public byte Type;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P080_AgentExperience);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(OverallExperience);
            writer.Write(Bonus);
            writer.Write(Type);
        }
    }

    public class P081_AgentKarma : IPacketOut
    {
        public int AgentId;
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P081_AgentKarma);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(Amount);
        }
    }

    public class P082_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P082_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P083_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P083_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P084_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P084_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P085_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P085_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P086_Unknown : IPacketOut
    {
        public int Unknown0;
        public int[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P086_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
        }
    }

    public class P087_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P087_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P088_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P088_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P089_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P089_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P090_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P090_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P091_AgentDownedPenalty : IPacketOut
    {
        public int AgentId;
        public byte Penalty;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P091_AgentDownedPenalty);
            writer.WriteVarint(AgentId);
            writer.Write(Penalty);
        }
    }

    public class P092_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P092_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P093_Unknown : IPacketOut
    {
        public short Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P093_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P094_UnlockedDyes : IPacketOut
    {
        public int[] DyeData;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P094_UnlockedDyes);
            writer.Write((byte)DyeData.Length);
            for (int i = 0; i < DyeData.Length; i++)
            {
                writer.WriteVarint(DyeData[i]);
            }
        }
    }

    public class P095_UnlockDye : IPacketOut
    {
        public short DyeId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P095_UnlockDye);
            writer.Write(DyeId);
        }
    }

    public class P096_AgentEndurance : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Endurance;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P096_AgentEndurance);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Endurance);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P097_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P097_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P098_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P098_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P099_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P099_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P100_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P100_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P102_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P102_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P103_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public int Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P103_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P104_AgentHealth : IPacketOut
    {
        public int AgentId;
        public byte Unknown1;
        public float Health1;
        public float Health2;
        public float HealthDiv10;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P104_AgentHealth);
            writer.WriteVarint(AgentId);
            writer.Write(Unknown1);
            writer.Write(Health1);
            writer.Write(Health2);
            writer.Write(HealthDiv10);
        }
    }

    public class P105_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P105_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P106_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P106_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P107_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P107_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P108_AgentHealth : IPacketOut
    {
        public int AgentId;
        public float HealthDiv10;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P108_AgentHealth);
            writer.WriteVarint(AgentId);
            writer.Write(HealthDiv10);
        }
    }

    public class P109_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P109_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P110_HintInfo : IPacketOut
    {
        public int[] HintInfo;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P110_HintInfo);
            writer.Write((byte)HintInfo.Length);
            for (int i = 0; i < HintInfo.Length; i++)
            {
                writer.WriteVarint(HintInfo[i]);
            }
        }
    }

    public class P111_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P111_Unknown);
        }
    }

    public class P112_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P112_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P113_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P113_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P114_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P114_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P115_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P115_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P116_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P116_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P117_InventoryItemReceived : IPacketOut
    {
        public int AgentId;
        public int ItemId;
        public byte Qty;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P117_InventoryItemReceived);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(ItemId);
            writer.Write(Qty);
        }
    }

    public class P118_AgentRegisterInventory : IPacketOut
    {
        public int AgentId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P118_AgentRegisterInventory);
            writer.WriteVarint(AgentId);
        }
    }

    public class P119_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P119_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P120_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P120_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P121_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P121_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P122_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P122_Unknown);
        }
    }

    public class P123_InventoryEquipItem : IPacketOut
    {
        public int AgentId;
        public int ItemId;
        public byte EquipmentSlot;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P123_InventoryEquipItem);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(ItemId);
            writer.Write(EquipmentSlot);
        }
    }

    public class P124_InventoryAddItem : IPacketOut
    {
        public int Unknown0;
        public int ItemId;
        public byte EquipmentIndex;
        public byte Slot;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P124_InventoryAddItem);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(ItemId);
            writer.Write(EquipmentIndex);
            writer.Write(Slot);
        }
    }

    public class P125_InventoryRemoveItem : IPacketOut
    {
        public int AgentId;
        public int ItemId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P125_InventoryRemoveItem);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(ItemId);
        }
    }

    public class P126_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P126_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P127_AgentWearingTownClothes : IPacketOut
    {
        public int AgentId;
        public byte isWearing;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P127_AgentWearingTownClothes);
            writer.WriteVarint(AgentId);
            writer.Write(isWearing);
        }
    }

    public class P128_AgentGatherSlot : IPacketOut
    {
        public int AgentId;
        public byte Slot;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P128_AgentGatherSlot);
            writer.WriteVarint(AgentId);
            writer.Write(Slot);
        }
    }

    public class P129_AgentCurrentEquippedWeaponset : IPacketOut
    {
        public int AgentId;
        public byte WeaponSet;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P129_AgentCurrentEquippedWeaponset);
            writer.WriteVarint(AgentId);
            writer.Write(WeaponSet);
        }
    }

    public class P130_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P130_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P131_AgentUnlockedBags : IPacketOut
    {
        public int AgentId;
        public byte Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P131_AgentUnlockedBags);
            writer.WriteVarint(AgentId);
            writer.Write(Amount);
        }
    }

    public class P132_AgentGold : IPacketOut
    {
        public int AgentId;
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P132_AgentGold);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(Amount);
        }
    }

    public class P133_AgentArmorVisibility : IPacketOut
    {
        public int AgentId;
        public int[] VisibilityData;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P133_AgentArmorVisibility);
            writer.WriteVarint(AgentId);
            writer.Write((byte)VisibilityData.Length);
            for (int i = 0; i < VisibilityData.Length; i++)
            {
                writer.WriteVarint(VisibilityData[i]);
            }
        }
    }

    public class P134_AgentDefaultWeaponset : IPacketOut
    {
        public int AgentId;
        public byte isUnderwater;
        public byte Weaponset;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P134_AgentDefaultWeaponset);
            writer.WriteVarint(AgentId);
            writer.Write(isUnderwater);
            writer.Write(Weaponset);
        }
    }

    public class P135_AgentInventorySlots : IPacketOut
    {
        public int AgentId;
        public int Slots;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P135_AgentInventorySlots);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(Slots);
        }
    }

    public class P136_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P136_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P137_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P137_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P138_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P138_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P139_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P139_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P140_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P140_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P141_InventoryItemConsumed : IPacketOut
    {
        public int AgentId;
        public int ItemDataId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P141_InventoryItemConsumed);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(ItemDataId);
        }
    }

    public class P142_AgentPetInfo : IPacketOut
    {
        public int AgentId;
        public byte Unknown1;
        public byte Unknown2;
        public int[] Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P142_AgentPetInfo);
            writer.WriteVarint(AgentId);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.WriteVarint(Unknown3[i]);
            }
        }
    }

    public class P143_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P143_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P144_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P144_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P145_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P145_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P146_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P146_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P147_AgentRegisterPet : IPacketOut
    {
        public int AgentId;
        public byte Slot;
        public string PetName;
        public int PetId;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P147_AgentRegisterPet);
            writer.WriteVarint(AgentId);
            writer.Write(Slot);
            writer.WriteUtf16String(PetName);
            writer.WriteVarint(PetId);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P148_AgentPetCombatState : IPacketOut
    {
        public int AgentId;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P148_AgentPetCombatState);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P149_AgentPetCooldown : IPacketOut
    {
        public int AgentId;
        public int Duration;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P149_AgentPetCooldown);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(Duration);
        }
    }

    public class P150_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P150_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P151_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P151_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P152_Unknown : IPacketOut
    {
        public byte[] Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P152_Unknown);
            writer.Write((byte)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.Write(Unknown0[i]);
            }
        }
    }

    public class P153_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P153_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P154_Unknown : IPacketOut
    {
        public Vector2[] Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P154_Unknown);
            writer.Write((byte)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.WriteVector2(Unknown0[i]);
            }
            writer.WriteVarint(Unknown1);
        }
    }

    public class P155_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public Vector2[] Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P155_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write((byte)Unknown2.Length);
            for (int i = 0; i < Unknown2.Length; i++)
            {
                writer.WriteVector2(Unknown2[i]);
            }
            writer.WriteVarint(Unknown3);
        }
    }

    public class P156_Unknown : IPacketOut
    {
        public Vector2 Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P156_Unknown);
            writer.WriteVector2(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P157_Unknown : IPacketOut
    {
        public float Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P157_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P158_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P158_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P159_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P159_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P160_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P160_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P161_AgentNPCStats : IPacketOut
    {
        public int AgentId;
        public string Name;
        public byte Unknown2;
        public struct Struct3
        {
            public long Unknown4;
            public long Unknown5;
            public long Unknown6;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown4);
                writer.Write(Unknown5);
                writer.Write(Unknown6);
            }
        }
        public Optional<Struct3> Appearance;
        public struct Struct8
        {
            public float Unknown9;
            public int Unknown10;
            public int Unknown11;
            public float Unknown12;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown9);
                writer.WriteVarint(Unknown10);
                writer.WriteVarint(Unknown11);
                writer.Write(Unknown12);
            }
        }
        public Optional<Struct8> Unknown13;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P161_AgentNPCStats);
            writer.WriteVarint(AgentId);
            writer.WriteUtf16String(Name);
            writer.Write(Unknown2);
            if (Appearance.IsPresent)
            {
                Appearance.Value.Serialize(writer);
            }
            if (Unknown13.IsPresent)
            {
                Unknown13.Value.Serialize(writer);
            }
        }
    }

    public class P162_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P162_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P163_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P163_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P164_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P164_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P165_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P165_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P166_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P166_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P167_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P167_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P168_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P168_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P169_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P169_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P170_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P170_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P171_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P171_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P172_AgentName : IPacketOut
    {
        public int AgentId;
        public string Name;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P172_AgentName);
            writer.WriteVarint(AgentId);
            writer.WriteUtf16String(Name);
        }
    }

    public class P173_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P173_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P175_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P175_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P176_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P176_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P177_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P177_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P178_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P178_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P179_CreatureCreate : IPacketOut
    {
        public int CreatureId;
        public string Name;
        public UID UserId;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P179_CreatureCreate);
            writer.WriteVarint(CreatureId);
            writer.WriteUtf16String(Name);
            writer.WriteUID(UserId);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P180_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P180_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P181_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P181_Unknown);
        }
    }

    public class P182_CreatureAssignToAgent : IPacketOut
    {
        public int CreatureId;
        public int AgentId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P182_CreatureAssignToAgent);
            writer.WriteVarint(CreatureId);
            writer.WriteVarint(AgentId);
        }
    }

    public class P183_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P183_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P184_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P184_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P185_CreatureApplyGuild : IPacketOut
    {
        public int CreatureId;
        public UID GuildUID;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P185_CreatureApplyGuild);
            writer.WriteVarint(CreatureId);
            writer.WriteUID(GuildUID);
        }
    }

    public class P186_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P186_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P187_CreatureTitle : IPacketOut
    {
        public int CreatureId;
        public int TitleId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P187_CreatureTitle);
            writer.WriteVarint(CreatureId);
            writer.WriteVarint(TitleId);
        }
    }

    public class P188_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P188_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P189_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P189_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P191_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P191_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P192_Unknown : IPacketOut
    {
        public byte Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P192_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P193_Unknown : IPacketOut
    {
        public int Unknown0;
        public Vector2 Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P193_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVector2(Unknown1);
        }
    }

    public class P194_Unknown : IPacketOut
    {
        public byte[] Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P194_Unknown);
            writer.Write((ushort)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.Write(Unknown0[i]);
            }
        }
    }

    public class P195_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P195_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P196_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P196_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P197_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;
        public long Unknown2;
        public long Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P197_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P198_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P198_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P199_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P199_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P200_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P200_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P201_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P201_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P202_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P202_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P203_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P203_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P204_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P204_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P205_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P205_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P206_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P206_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P207_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P207_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P208_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P208_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P209_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P209_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P210_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P210_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P211_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P211_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P212_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P212_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P213_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P213_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P214_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P214_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P215_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P215_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P216_AgentAttunement : IPacketOut
    {
        public int AgentId;
        public int Attunement;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P216_AgentAttunement);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(Attunement);
        }
    }

    public class P217_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P217_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P218_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P218_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P219_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public float Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P219_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P220_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P220_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P221_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P221_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P222_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P222_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P223_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P223_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P225_AchievementInfo : IPacketOut
    {
        public int AchievementId;
        public short Progress;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P225_AchievementInfo);
            writer.WriteVarint(AchievementId);
            writer.Write(Progress);
        }
    }

    public class P226_AchievementInfo : IPacketOut
    {
        public int AchievementId;
        public int[] Progress;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P226_AchievementInfo);
            writer.WriteVarint(AchievementId);
            writer.Write((byte)Progress.Length);
            for (int i = 0; i < Progress.Length; i++)
            {
                writer.WriteVarint(Progress[i]);
            }
        }
    }

    public class P227_AchievementInfo : IPacketOut
    {
        public int AchievementId;
        public int[] Progress;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P227_AchievementInfo);
            writer.WriteVarint(AchievementId);
            writer.Write((byte)Progress.Length);
            for (int i = 0; i < Progress.Length; i++)
            {
                writer.WriteVarint(Progress[i]);
            }
        }
    }

    public class P228_PersonalStoryCurrentQuest : IPacketOut
    {
        public int CreatureId;
        public int QuestId;
        public byte Step;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P228_PersonalStoryCurrentQuest);
            writer.WriteVarint(CreatureId);
            writer.WriteVarint(QuestId);
            writer.Write(Step);
        }
    }

    public class P229_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P229_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P230_Unknown : IPacketOut
    {
        public int Unknown0;
        public Vector3 Unknown1;
        public int Unknown2;
        public Vector3 Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P230_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVector3(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVector3(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P231_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P231_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P232_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P232_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P233_PersonalStoryQuestGoal : IPacketOut
    {
        public int CreatureId;
        public int Step;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P233_PersonalStoryQuestGoal);
            writer.WriteVarint(CreatureId);
            writer.WriteVarint(Step);
        }
    }

    public class P234_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P234_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P235_PersonalStoryQuests : IPacketOut
    {
        public int CreatureId;
        public short[] QuestList;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P235_PersonalStoryQuests);
            writer.WriteVarint(CreatureId);
            writer.Write((byte)QuestList.Length);
            for (int i = 0; i < QuestList.Length; i++)
            {
                writer.Write(QuestList[i]);
            }
        }
    }

    public class P236_ReportQuestManager : IPacketOut
    {
        public int CreatureId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P236_ReportQuestManager);
            writer.WriteVarint(CreatureId);
        }
    }

    public class P237_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P237_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P238_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P238_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P239_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P239_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P240_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P240_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P241_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P241_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P242_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P242_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P243_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P243_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P244_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public struct Struct7
        {
            public int Unknown8;
            public byte Unknown9;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteVarint(Unknown8);
                writer.Write(Unknown9);
            }
        }
        public Struct7[] Unknown10;
        public Optional<byte> Unknown11;
        public Optional<byte> Unknown12;
        public Optional<int> Unknown13;
        public Optional<byte> Unknown14;
        public struct Struct15
        {
            public UID Unknown16;
            public byte Unknown17;
            public int Unknown18;
            public int Unknown19;
            public long Unknown20;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteUID(Unknown16);
                writer.Write(Unknown17);
                writer.WriteVarint(Unknown18);
                writer.WriteVarint(Unknown19);
                writer.Write(Unknown20);
            }
        }
        public Optional<Struct15> Unknown21;
        public Optional<int> Unknown22;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P244_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write((byte)Unknown10.Length);
            for (int i = 0; i < Unknown10.Length; i++)
            {
                Unknown10[i].Serialize(writer);
            }
            if (Unknown11.IsPresent)
            {
                writer.Write(Unknown11.Value);
            }
            if (Unknown12.IsPresent)
            {
                writer.Write(Unknown12.Value);
            }
            if (Unknown13.IsPresent)
            {
                writer.WriteVarint(Unknown13.Value);
            }
            if (Unknown14.IsPresent)
            {
                writer.Write(Unknown14.Value);
            }
            if (Unknown21.IsPresent)
            {
                Unknown21.Value.Serialize(writer);
            }
            if (Unknown22.IsPresent)
            {
                writer.WriteVarint(Unknown22.Value);
            }
        }
    }

    public class P245_Unknown : IPacketOut
    {
        public byte Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P245_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P246_Unknown : IPacketOut
    {
        public int[] Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P246_Unknown);
            writer.Write((ushort)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.WriteVarint(Unknown0[i]);
            }
        }
    }

    public class P247_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public struct Struct2
        {
            public byte Unknown3;
            public byte Unknown4;
            public int Unknown5;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown3);
                writer.Write(Unknown4);
                writer.WriteVarint(Unknown5);
            }
        }
        public Struct2[] Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P247_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            for (int i = 0; i < Unknown6.Length; i++)
            {
                Unknown6[i].Serialize(writer);
            }
        }
    }

    public class P248_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P248_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P250_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P250_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P251_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P251_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P252_OpenUIWindow : IPacketOut
    {
        public int WindowId;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P252_OpenUIWindow);
            writer.WriteVarint(WindowId);
            writer.Write(Unknown1);
        }
    }

    public class P253_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P253_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P254_AgentOwner : IPacketOut
    {
        public int AgentId;
        public int OwnerAgentId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P254_AgentOwner);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(OwnerAgentId);
        }
    }

    public class P255_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P255_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P256_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P256_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P257_CreatureSkillPoints : IPacketOut
    {
        public short Amount;
        public int CreatureId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P257_CreatureSkillPoints);
            writer.Write(Amount);
            writer.WriteVarint(CreatureId);
        }
    }

    public class P258_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P258_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P259_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P259_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P260_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P260_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P261_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P261_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P262_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P262_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P263_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P263_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P264_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P264_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P265_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P265_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P266_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P266_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P267_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P267_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P268_AgentRegisterSkillBar : IPacketOut
    {
        public int AgentId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P268_AgentRegisterSkillBar);
            writer.WriteVarint(AgentId);
        }
    }

    public class P269_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P269_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P270_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P270_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P271_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P271_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P272_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P272_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P273_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P273_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P274_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P274_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P275_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P275_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P276_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P276_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P277_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P277_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P278_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P278_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P279_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P279_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P280_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public short Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P280_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P281_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public int[] Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P281_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.WriteVarint(Unknown3[i]);
            }
        }
    }

    public class P282_Unknown : IPacketOut
    {
        public int Unknown0;
        public int[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P282_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
        }
    }

    public class P283_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P283_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P284_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P284_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P285_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;
        public int Unknown2;
        public short Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P285_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P286_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P286_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P287_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P287_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P288_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int[] Unknown3;
        public string Unknown4;
        public string Unknown5;
        public short Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P288_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.WriteVarint(Unknown3[i]);
            }
            writer.WriteUtf16String(Unknown4);
            writer.WriteUtf16String(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P289_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P289_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P290_Unknown : IPacketOut
    {
        public WorldPosition Unknown0;
        public Vector3 Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P290_Unknown);
            writer.WriteWorldPosition(Unknown0);
            writer.WriteVector3(Unknown1);
        }
    }

    public class P291_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P291_Unknown);
        }
    }

    public class P292_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P292_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P293_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P293_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P294_UnlockedTitles : IPacketOut
    {
        public int[] TitleData;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P294_UnlockedTitles);
            writer.Write((byte)TitleData.Length);
            for (int i = 0; i < TitleData.Length; i++)
            {
                writer.WriteVarint(TitleData[i]);
            }
        }
    }

    public class P295_Unknown : IPacketOut
    {
        public int Unknown0;
        public int[] Unknown1;
        public int[] Unknown2;
        public byte[] Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P295_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
            writer.Write((byte)Unknown2.Length);
            for (int i = 0; i < Unknown2.Length; i++)
            {
                writer.WriteVarint(Unknown2[i]);
            }
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.Write(Unknown3[i]);
            }
        }
    }

    public class P296_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P296_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P297_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P297_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P298_Unknown : IPacketOut
    {
        public int Unknown0;
        public int[] Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P298_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
            writer.Write(Unknown2);
        }
    }

    public class P299_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P299_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P300_AgentTransformation : IPacketOut
    {
        public int AgentId;
        public int TransformationId;
        public byte Type;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P300_AgentTransformation);
            writer.WriteVarint(AgentId);
            writer.WriteVarint(TransformationId);
            writer.Write(Type);
        }
    }

    public class P301_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P301_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P305_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P305_Unknown);
        }
    }

    public class P307_ChatMessage : IPacketOut
    {
        public string Message;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P307_ChatMessage);
            writer.WriteUtf16String(Message);
        }
    }

    public class P308_ChatMessageOwner : IPacketOut
    {
        public byte Channel;
        public byte Color;
        public string Message;
        public UID PlayerUID;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P308_ChatMessageOwner);
            writer.Write(Channel);
            writer.Write(Color);
            writer.WriteUtf16String(Message);
            writer.WriteUID(PlayerUID);
        }
    }

    public class P309_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P309_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P310_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P310_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P311_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P311_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P312_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P312_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P313_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public byte Unknown5;
        public byte Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P313_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P314_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P314_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P315_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public byte Unknown7;
        public string Unknown8;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P315_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write(Unknown7);
            writer.WriteUtf16String(Unknown8);
        }
    }

    public class P316_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public byte Unknown5;
        public string Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P316_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.Write(Unknown5);
            writer.WriteUtf16String(Unknown6);
        }
    }

    public class P317_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;
        public string Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P317_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.WriteUtf16String(Unknown4);
        }
    }

    public class P318_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public string Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P318_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteUtf16String(Unknown6);
        }
    }

    public class P319_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public float Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public byte Unknown9;
        public int Unknown10;
        public int Unknown11;
        public string Unknown12;
        public string Unknown13;
        public string Unknown14;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P319_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteVarint(Unknown7);
            writer.WriteVarint(Unknown8);
            writer.Write(Unknown9);
            writer.WriteVarint(Unknown10);
            writer.WriteVarint(Unknown11);
            writer.WriteUtf16String(Unknown12);
            writer.WriteUtf16String(Unknown13);
            writer.WriteUtf16String(Unknown14);
        }
    }

    public class P320_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P320_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P321_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P321_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P322_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P322_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P323_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P323_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P324_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public Vector3 Unknown3;
        public Vector2 Unknown4;
        public float Unknown5;
        public float Unknown6;
        public float Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P324_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVector3(Unknown3);
            writer.WriteVector2(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
        }
    }

    public class P325_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public Vector2 Unknown3;
        public Vector2 Unknown4;
        public float Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P325_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVector2(Unknown3);
            writer.WriteVector2(Unknown4);
            writer.Write(Unknown5);
        }
    }

    public class P326_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public Vector2 Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P326_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVector2(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P327_Unknown : IPacketOut
    {
        public Vector2 Unknown0;
        public Vector2 Unknown1;
        public Vector2 Unknown2;
        public Vector2 Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P327_Unknown);
            writer.WriteVector2(Unknown0);
            writer.WriteVector2(Unknown1);
            writer.WriteVector2(Unknown2);
            writer.WriteVector2(Unknown3);
        }
    }

    public class P328_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public Vector3 Unknown3;
        public float Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P328_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVector3(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P329_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P329_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P331_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P331_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P332_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P332_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P333_Unknown : IPacketOut
    {
        public long Unknown0;
        public long Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P333_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P334_Unknown : IPacketOut
    {
        public long Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P334_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P335_Unknown : IPacketOut
    {
        public long Unknown0;
        public float Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P335_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P336_Unknown : IPacketOut
    {
        public long Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P336_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P337_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P337_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P338_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public byte Unknown4;
        public byte Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P338_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write(Unknown4);
            writer.Write(Unknown5);
        }
    }

    public class P339_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P339_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P340_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P340_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P341_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P341_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P342_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P342_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P343_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P343_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P344_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P344_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P345_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P345_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P346_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P346_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P347_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P347_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P348_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P348_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P349_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P349_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P350_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P350_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P351_Unknown : IPacketOut
    {
        public string Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P351_Unknown);
            writer.WriteUtf16String(Unknown0);
        }
    }

    public class P352_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P352_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P353_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P353_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P354_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public Vector2 Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P354_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVector2(Unknown2);
        }
    }

    public class P355_Unknown : IPacketOut
    {
        public Vector2 Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P355_Unknown);
            writer.WriteVector2(Unknown0);
        }
    }

    public class P356_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public Vector2 Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P356_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVector2(Unknown2);
        }
    }

    public class P357_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P357_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P358_Unknown : IPacketOut
    {
        public int Unknown0;
        public UID Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P358_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUID(Unknown1);
        }
    }

    public class P359_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P359_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P360_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P360_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P361_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P361_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P362_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public string Unknown2;
        public Vector3 Unknown3;
        public byte Unknown4;
        public string Unknown5;
        public string Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P362_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVector3(Unknown3);
            writer.Write(Unknown4);
            writer.WriteUtf16String(Unknown5);
            writer.WriteUtf16String(Unknown6);
        }
    }

    public class P363_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P363_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P364_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P364_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P365_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P365_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P366_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P366_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P367_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public UID Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public int Unknown8;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P367_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteUID(Unknown3);
            writer.Write(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
            writer.WriteVarint(Unknown8);
        }
    }

    public class P368_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P368_Unknown);
        }
    }

    public class P369_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P369_Unknown);
        }
    }

    public class P370_Unknown : IPacketOut
    {
        public byte Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P370_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P371_Unknown : IPacketOut
    {
        public byte Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P371_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P372_Unknown : IPacketOut
    {
        public byte Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public short Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P372_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P373_Unknown : IPacketOut
    {
        public byte Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P373_Unknown);
            writer.Write(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P374_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P374_Unknown);
        }
    }

    public class P375_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P375_Unknown);
        }
    }

    public class P376_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P376_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P377_Unknown : IPacketOut
    {
        public UID Unknown0;
        public short Unknown1;
        public short Unknown2;
        public short[] Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P377_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.Write(Unknown3[i]);
            }
            writer.Write(Unknown4);
        }
    }

    public class P378_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P378_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P379_Unknown : IPacketOut
    {
        public UID Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P379_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P380_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P380_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P381_Unknown : IPacketOut
    {
        public UID Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public short Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P381_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P382_Unknown : IPacketOut
    {
        public UID Unknown0;
        public string Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P382_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P383_Unknown : IPacketOut
    {
        public UID Unknown0;
        public short Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P383_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P384_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P384_Unknown);
        }
    }

    public class P385_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P385_Unknown);
        }
    }

    public class P386_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P386_Unknown);
        }
    }

    public class P387_Unknown : IPacketOut
    {
        public byte Unknown0;
        public short Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P387_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P388_Unknown : IPacketOut
    {
        public byte Unknown0;
        public WorldPosition Unknown1;
        public UID Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P388_Unknown);
            writer.Write(Unknown0);
            writer.WriteWorldPosition(Unknown1);
            writer.WriteUID(Unknown2);
        }
    }

    public class P389_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P389_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P390_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P390_Unknown);
        }
    }

    public class P391_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P391_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P392_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P392_Unknown);
        }
    }

    public class P393_Unknown : IPacketOut
    {
        public WorldPosition Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P393_Unknown);
            writer.WriteWorldPosition(Unknown0);
        }
    }

    public class P394_Unknown : IPacketOut
    {
        public byte Unknown0;
        public Vector2[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P394_Unknown);
            writer.Write(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVector2(Unknown1[i]);
            }
        }
    }

    public class P395_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P395_Unknown);
        }
    }

    public class P396_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P396_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P397_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P397_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P398_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P398_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P399_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P399_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P400_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P400_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P401_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P401_Unknown);
        }
    }

    public class P402_Unknown : IPacketOut
    {
        public int Unknown0;
        public short[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P402_Unknown);
            writer.WriteVarint(Unknown0);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.Write(Unknown1[i]);
            }
        }
    }

    public class P403_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P403_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P404_Unknown : IPacketOut
    {
        public int Unknown0;
        public UID Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P404_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUID(Unknown1);
        }
    }

    public class P405_InventoryItemQty : IPacketOut
    {
        public int ItemId;
        public int Qty;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P405_InventoryItemQty);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(Qty);
        }
    }

    public class P406_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P406_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P407_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P407_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P408_InventoryRegisterArmor : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;
        public int Unknown3;
        public short[] Dyes;
        public int RuneDataId;
        public int[] Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P408_InventoryRegisterArmor);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
            writer.WriteVarint(Unknown3);
            for (int i = 0; i < Dyes.Length; i++)
            {
                writer.Write(Dyes[i]);
            }
            writer.WriteVarint(RuneDataId);
            writer.Write((byte)Unknown6.Length);
            for (int i = 0; i < Unknown6.Length; i++)
            {
                writer.WriteVarint(Unknown6[i]);
            }
        }
    }

    public class P409_InventoryRegisterBackPiece : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;
        public int Unknown3;
        public int Unknown4;
        public int[] Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P409_InventoryRegisterBackPiece);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.Write((byte)Unknown5.Length);
            for (int i = 0; i < Unknown5.Length; i++)
            {
                writer.WriteVarint(Unknown5[i]);
            }
        }
    }

    public class P410_InventoryRegisterBag : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P410_InventoryRegisterBag);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
        }
    }

    public class P411_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P411_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P412_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P412_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P413_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P413_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P414_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P414_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P415_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P415_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P416_InventoryRegisterItem : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;
        public int Quantity;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P416_InventoryRegisterItem);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
            writer.WriteVarint(Quantity);
        }
    }

    public class P417_InventoryRegisterAccessory : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;
        public int UpgradeDataId;
        public int[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P417_InventoryRegisterAccessory);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
            writer.WriteVarint(UpgradeDataId);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.WriteVarint(Unknown4[i]);
            }
        }
    }

    public class P418_InventoryRegisterSalvageKit : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;
        public byte UsesRemaining;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P418_InventoryRegisterSalvageKit);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
            writer.Write(UsesRemaining);
        }
    }

    public class P419_InventoryRegisterWeapon : IPacketOut
    {
        public int ItemId;
        public int ItemDataId;
        public byte Flags;
        public int SkillSetDataId;
        public int SigilDataId;
        public byte Unknown5;
        public int Unknown6;
        public int[] Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P419_InventoryRegisterWeapon);
            writer.WriteVarint(ItemId);
            writer.WriteVarint(ItemDataId);
            writer.Write(Flags);
            writer.WriteVarint(SkillSetDataId);
            writer.WriteVarint(SigilDataId);
            writer.Write(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write((byte)Unknown7.Length);
            for (int i = 0; i < Unknown7.Length; i++)
            {
                writer.WriteVarint(Unknown7[i]);
            }
        }
    }

    public class P420_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P420_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P421_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P421_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P422_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int[] Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P422_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write((byte)Unknown2.Length);
            for (int i = 0; i < Unknown2.Length; i++)
            {
                writer.WriteVarint(Unknown2[i]);
            }
        }
    }

    public class P423_UnregisterItem : IPacketOut
    {
        public int ItemId;
        public byte Type;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P423_UnregisterItem);
            writer.WriteVarint(ItemId);
            writer.Write(Type);
        }
    }

    public class P424_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P424_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P425_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P425_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P426_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P426_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P427_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P427_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P428_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P428_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P429_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P429_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P430_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P430_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P431_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P431_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P432_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P432_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P433_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P433_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P434_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public short Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P434_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P435_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P435_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P436_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P436_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P437_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public string Unknown4;
        public string Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P437_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteUtf16String(Unknown4);
            writer.WriteUtf16String(Unknown5);
        }
    }

    public class P438_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P438_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P439_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P439_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P440_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P440_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P441_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P441_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P442_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P442_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P443_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P443_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P444_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P444_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P445_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public Vector3 Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P445_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVector3(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P446_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P446_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P447_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P447_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P448_Unknown : IPacketOut
    {
        public int Unknown0;
        public Vector3 Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P448_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVector3(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P449_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P449_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P450_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P450_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P451_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P451_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P452_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P452_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P453_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public struct Struct2
        {
            public string Unknown3;
            public int Unknown4;
            public struct Struct5
            {
                public int Unknown6;
                public byte Unknown7;
                public string Unknown8;
                public Vector2 Unknown9;

                public void Serialize(PacketWriter writer)
                {
                    writer.WriteVarint(Unknown6);
                    writer.Write(Unknown7);
                    writer.WriteUtf16String(Unknown8);
                    writer.WriteVector2(Unknown9);
                }
            }
            public Struct5[] Unknown10;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteUtf16String(Unknown3);
                writer.WriteVarint(Unknown4);
                writer.Write((byte)Unknown10.Length);
                for (int i = 0; i < Unknown10.Length; i++)
                {
                    Unknown10[i].Serialize(writer);
                }
            }
        }
        public Struct2[] Unknown11;
        public short[] Unknown12;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P453_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write((byte)Unknown11.Length);
            for (int i = 0; i < Unknown11.Length; i++)
            {
                Unknown11[i].Serialize(writer);
            }
            writer.Write((byte)Unknown12.Length);
            for (int i = 0; i < Unknown12.Length; i++)
            {
                writer.Write(Unknown12[i]);
            }
        }
    }

    public class P454_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P454_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P455_Unknown : IPacketOut
    {
        public struct Struct0
        {
            public int Unknown1;
            public int Unknown2;
            public Vector3 Unknown3;
            public Vector3 Unknown4;
            public byte Unknown5;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteVarint(Unknown1);
                writer.WriteVarint(Unknown2);
                writer.WriteVector3(Unknown3);
                writer.WriteVector3(Unknown4);
                writer.Write(Unknown5);
            }
        }
        public Struct0[] Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P455_Unknown);
            writer.Write((byte)Unknown6.Length);
            for (int i = 0; i < Unknown6.Length; i++)
            {
                Unknown6[i].Serialize(writer);
            }
        }
    }

    public class P456_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public int Unknown6;
        public string Unknown7;
        public Vector3 Unknown8;
        public int Unknown9;
        public int Unknown10;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P456_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteUtf16String(Unknown7);
            writer.WriteVector3(Unknown8);
            writer.WriteVarint(Unknown9);
            writer.WriteVarint(Unknown10);
        }
    }

    public class P457_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public int Unknown6;
        public string Unknown7;
        public Vector3 Unknown8;
        public int Unknown9;
        public byte Unknown10;
        public float Unknown11;
        public int Unknown12;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P457_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteUtf16String(Unknown7);
            writer.WriteVector3(Unknown8);
            writer.WriteVarint(Unknown9);
            writer.Write(Unknown10);
            writer.Write(Unknown11);
            writer.WriteVarint(Unknown12);
        }
    }

    public class P458_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P458_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P459_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P459_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P460_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P460_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P461_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P461_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P462_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public Vector3 Unknown2;
        public int Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P462_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVector3(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P463_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public WorldPosition Unknown3;
        public float Unknown4;
        public byte Unknown5;
        public long Unknown6;
        public byte Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P463_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteWorldPosition(Unknown3);
            writer.Write(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
        }
    }

    public class P464_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P464_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P465_MapLoadComplete : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P465_MapLoadComplete);
        }
    }

    public class P466_MapLoadHeader : IPacketOut
    {
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P466_MapLoadHeader);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P467_MapLoadPlayerName : IPacketOut
    {
        public string PlayerName;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P467_MapLoadPlayerName);
            writer.WriteUtf16String(PlayerName);
        }
    }

    public class P468_Unknown : IPacketOut
    {
        public UID Unknown0;
        public UID Unknown1;
        public string Unknown2;
        public short Unknown3;
        public byte[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P468_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteUID(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.Write(Unknown3);
            writer.Write((ushort)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
        }
    }

    public class P469_CharCreationInit : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P469_CharCreationInit);
        }
    }

    public class P470_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P470_Unknown);
        }
    }

    public class P471_DisplayError : IPacketOut
    {
        public int ErrorCode;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P471_DisplayError);
            writer.WriteVarint(ErrorCode);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P472_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P472_Unknown);
        }
    }

    public class P473_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P473_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P474_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P474_Unknown);
        }
    }

    public class P475_MapLoadPreviousMap : IPacketOut
    {
        public short MapId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P475_MapLoadPreviousMap);
            writer.Write(MapId);
        }
    }

    public class P476_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P476_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P477_MapInfo : IPacketOut
    {
        public Vector3 SpawnPoint;
        public Vector2 Unknown1;
        public Vector2 Unknown2;
        public short MapId;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P477_MapInfo);
            writer.WriteVector3(SpawnPoint);
            writer.WriteVector2(Unknown1);
            writer.WriteVector2(Unknown2);
            writer.Write(MapId);
            writer.Write(Unknown4);
        }
    }

    public class P478_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P478_Unknown);
        }
    }

    public class P479_SpawnInfoComplete : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P479_SpawnInfoComplete);
        }
    }

    public class P480_MapLoadServerInfo : IPacketOut
    {
        public int Unknown0;
        public int MapId;
        public int ServerId;
        public int Unknown3;
        public byte Unknown4;
        public byte isInstance;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P480_MapLoadServerInfo);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(MapId);
            writer.WriteVarint(ServerId);
            writer.WriteVarint(Unknown3);
            writer.Write(Unknown4);
            writer.Write(isInstance);
        }
    }

    public class P481_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P481_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P482_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P482_Unknown);
        }
    }

    public class P483_ReferToOtherGameServer : IPacketOut
    {
        public IPEndPoint ConnectionInfo;
        public int Unknown1;
        public int Unknown2;
        public short MapId;
        public int Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P483_ReferToOtherGameServer);
            writer.WriteIPEndPoint(ConnectionInfo);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(MapId);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P484_MapLoadSpawnPoint : IPacketOut
    {
        public Vector3 SpawnPoint;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P484_MapLoadSpawnPoint);
            writer.WriteVector3(SpawnPoint);
        }
    }

    public class P485_Unknown : IPacketOut
    {
        public string Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P485_Unknown);
            writer.WriteUtf16String(Unknown0);
        }
    }

    public class P486_Unknown : IPacketOut
    {
        public float Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P486_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P487_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P487_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P488_Unknown : IPacketOut
    {
        public short Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P488_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P489_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P489_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P490_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P490_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P491_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P491_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P492_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public float Unknown3;
        public string Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P492_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.WriteUtf16String(Unknown4);
        }
    }

    public class P493_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P493_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P494_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public float Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P494_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P495_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public string Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P495_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteUtf16String(Unknown3);
        }
    }

    public class P496_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P496_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P497_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P497_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P498_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P498_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P499_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P499_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P500_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P500_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P501_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P501_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P502_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P502_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P503_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P503_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P504_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P504_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P505_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P505_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P506_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P506_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P507_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public string Unknown3;
        public string Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P507_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteUtf16String(Unknown3);
            writer.WriteUtf16String(Unknown4);
        }
    }

    public class P508_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P508_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P509_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P509_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P510_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P510_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P511_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P511_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P512_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P512_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P513_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P513_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P514_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P514_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P515_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P515_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P516_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P516_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P517_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P517_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P518_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P518_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P519_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P519_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P520_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P520_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P521_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P521_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P522_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;
        public float Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P522_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P523_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P523_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P524_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public float Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P524_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P525_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P525_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P526_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P526_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P527_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public string Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P527_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteUtf16String(Unknown3);
        }
    }

    public class P528_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P528_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P529_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public int Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P529_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P530_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P530_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P531_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P531_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P532_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P532_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P533_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P533_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P534_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P534_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P535_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P535_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P536_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public byte Unknown5;
        public byte Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P536_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P537_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P537_Unknown);
        }
    }

    public class P538_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public UID Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public string Unknown5;
        public byte Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P538_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUID(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteUtf16String(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P539_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P539_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P540_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P540_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P541_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P541_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P542_Unknown : IPacketOut
    {
        public int Unknown0;
        public WorldPosition Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P542_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteWorldPosition(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P543_Unknown : IPacketOut
    {
        public int[] Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P543_Unknown);
            writer.Write((ushort)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.WriteVarint(Unknown0[i]);
            }
        }
    }

    public class P544_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P544_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P545_Unknown : IPacketOut
    {
        public byte Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P545_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P546_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P546_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P547_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P547_Unknown);
        }
    }

    public class P548_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P548_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P549_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P549_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P550_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P550_Unknown);
        }
    }

    public class P551_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P551_Unknown);
        }
    }

    public class P552_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P552_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P553_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P553_Unknown);
        }
    }

    public class P554_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P554_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P555_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P555_Unknown);
        }
    }

    public class P556_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P556_Unknown);
        }
    }

    public class P557_Unknown : IPacketOut
    {
        public byte Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public string Unknown4;
        public UID Unknown5;
        public byte Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P557_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteUtf16String(Unknown4);
            writer.WriteUID(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P558_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P558_Unknown);
        }
    }

    public class P559_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P559_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P560_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P560_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P561_Unknown : IPacketOut
    {
        public short Unknown0;
        public short Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P561_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P562_Unknown : IPacketOut
    {
        public short Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P562_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P563_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P563_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P564_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P564_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P565_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P565_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P566_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P566_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P567_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public UID Unknown5;
        public short Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P567_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.WriteUID(Unknown5);
            writer.Write(Unknown6);
        }
    }

    public class P568_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P568_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P569_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P569_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P570_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P570_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P571_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P571_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P572_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P572_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P573_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P573_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P574_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P574_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P575_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P575_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P576_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;
        public string Unknown3;
        public string Unknown4;
        public string Unknown5;
        public string Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P576_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteUtf16String(Unknown2);
            writer.WriteUtf16String(Unknown3);
            writer.WriteUtf16String(Unknown4);
            writer.WriteUtf16String(Unknown5);
            writer.WriteUtf16String(Unknown6);
        }
    }

    public class P577_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public string Unknown3;
        public Vector3 Unknown4;
        public float Unknown5;
        public float Unknown6;
        public string Unknown7;
        public int[] Unknown8;
        public int[] Unknown9;
        public byte[] Unknown10;
        public int[] Unknown11;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P577_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteUtf16String(Unknown3);
            writer.WriteVector3(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Unknown6);
            writer.WriteUtf16String(Unknown7);
            for (int i = 0; i < Unknown8.Length; i++)
            {
                writer.WriteVarint(Unknown8[i]);
            }
            writer.Write((byte)Unknown9.Length);
            for (int i = 0; i < Unknown9.Length; i++)
            {
                writer.WriteVarint(Unknown9[i]);
            }
            writer.Write((byte)Unknown10.Length);
            for (int i = 0; i < Unknown10.Length; i++)
            {
                writer.Write(Unknown10[i]);
            }
            writer.Write((byte)Unknown11.Length);
            for (int i = 0; i < Unknown11.Length; i++)
            {
                writer.WriteVarint(Unknown11[i]);
            }
        }
    }

    public class P578_AgentChatter : IPacketOut
    {
        public byte Unknown0;
        public byte Unknown1;
        public int SoundId;
        public float Unknown3;
        public int AgentId;
        public Vector3 Unknown5;
        public int Unknown6;
        public string Unknown7;
        public string Unknown8;
        public int Type;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P578_AgentChatter);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(SoundId);
            writer.Write(Unknown3);
            writer.WriteVarint(AgentId);
            writer.WriteVector3(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteUtf16String(Unknown7);
            writer.WriteUtf16String(Unknown8);
            writer.WriteVarint(Type);
        }
    }

    public class P579_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P579_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P580_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P580_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P581_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P581_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P582_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P582_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P583_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P583_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P584_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P584_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P585_CompassLocation : IPacketOut
    {
        public int LocationId;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P585_CompassLocation);
            writer.WriteVarint(LocationId);
        }
    }

    public class P586_Unknown : IPacketOut
    {
        public int[] Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P586_Unknown);
            writer.Write((ushort)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.WriteVarint(Unknown0[i]);
            }
        }
    }

    public class P587_Unknown : IPacketOut
    {
        public byte Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P587_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P588_StringEncryptionKeys : IPacketOut
    {
        public struct Struct0
        {
            public int StringId;
            public long Key;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteVarint(StringId);
                writer.Write(Key);
            }
        }
        public Struct0[] KeyData;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P588_StringEncryptionKeys);
            writer.Write((byte)KeyData.Length);
            for (int i = 0; i < KeyData.Length; i++)
            {
                KeyData[i].Serialize(writer);
            }
        }
    }

    public class P589_Unknown : IPacketOut
    {
        public int Unknown0;
        public float Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P589_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P590_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P590_Unknown);
        }
    }

    public class P591_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P591_Unknown);
        }
    }

    public class P592_Unknown : IPacketOut
    {
        public UID Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public byte Unknown5;
        public string Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P592_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.Write(Unknown5);
            writer.WriteUtf16String(Unknown6);
        }
    }

    public class P593_Unknown : IPacketOut
    {
        public long Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P593_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P594_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P594_Unknown);
        }
    }

    public class P595_Unknown : IPacketOut
    {
        public byte Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public UID Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P595_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteUID(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P596_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P596_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P597_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P597_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P598_Unknown : IPacketOut
    {
        public UID Unknown0;
        public UID Unknown1;
        public byte Unknown2;
        public UID[] Unknown3;
        public byte[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P598_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteUID(Unknown1);
            writer.Write(Unknown2);
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.WriteUID(Unknown3[i]);
            }
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
        }
    }

    public class P599_Unknown : IPacketOut
    {
        public UID Unknown0;
        public UID Unknown1;
        public UID Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P599_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteUID(Unknown1);
            writer.WriteUID(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P600_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P600_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P601_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P601_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P602_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P602_Unknown);
        }
    }

    public class P603_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P603_Unknown);
        }
    }

    public class P604_Unknown : IPacketOut
    {
        public UID Unknown0;
        public int Unknown1;
        public short Unknown2;
        public short Unknown3;
        public short Unknown4;
        public short Unknown5;
        public short Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public int[] Unknown9;
        public string Unknown10;
        public string Unknown11;
        public byte Unknown12;
        public struct Struct13
        {
            public byte Unknown14;
            public byte Unknown15;
            public int Unknown16;
            public int Unknown17;
            public int Unknown18;
            public int Unknown19;
            public struct Struct20
            {
                public byte Unknown21;
                public int Unknown22;

                public void Serialize(PacketWriter writer)
                {
                    writer.Write(Unknown21);
                    writer.WriteVarint(Unknown22);
                }
            }
            public Struct20[] Unknown23;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown14);
                writer.Write(Unknown15);
                writer.WriteVarint(Unknown16);
                writer.WriteVarint(Unknown17);
                writer.WriteVarint(Unknown18);
                writer.WriteVarint(Unknown19);
                writer.Write((byte)Unknown23.Length);
                for (int i = 0; i < Unknown23.Length; i++)
                {
                    Unknown23[i].Serialize(writer);
                }
            }
        }
        public Struct13[] Unknown24;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P604_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
            writer.Write(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.Write((byte)Unknown9.Length);
            for (int i = 0; i < Unknown9.Length; i++)
            {
                writer.WriteVarint(Unknown9[i]);
            }
            writer.WriteUtf16String(Unknown10);
            writer.WriteUtf16String(Unknown11);
            writer.Write(Unknown12);
            writer.Write((byte)Unknown24.Length);
            for (int i = 0; i < Unknown24.Length; i++)
            {
                Unknown24[i].Serialize(writer);
            }
        }
    }

    public class P605_Unknown : IPacketOut
    {
        public UID Unknown0;
        public short Unknown1;
        public short Unknown2;
        public short Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P605_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P606_Unknown : IPacketOut
    {
        public UID Unknown0;
        public string Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P606_Unknown);
            writer.WriteUID(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P607_Unknown : IPacketOut
    {
        public struct Struct0
        {
            public UID Unknown1;
            public UID Unknown2;
            public short Unknown3;
            public short Unknown4;
            public int Unknown5;
            public byte Unknown6;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteUID(Unknown1);
                writer.WriteUID(Unknown2);
                writer.Write(Unknown3);
                writer.Write(Unknown4);
                writer.WriteVarint(Unknown5);
                writer.Write(Unknown6);
            }
        }
        public Struct0[] Unknown7;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P607_Unknown);
            writer.Write((byte)Unknown7.Length);
            for (int i = 0; i < Unknown7.Length; i++)
            {
                Unknown7[i].Serialize(writer);
            }
        }
    }

    public class P608_Unknown : IPacketOut
    {
        public UID[] Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P608_Unknown);
            writer.Write((byte)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.WriteUID(Unknown0[i]);
            }
        }
    }

    public class P609_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P609_Unknown);
        }
    }

    public class P610_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public short Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P610_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P611_TradingPostGoldPickup : IPacketOut
    {
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P611_TradingPostGoldPickup);
            writer.WriteVarint(Amount);
        }
    }

    public class P612_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P612_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P613_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P613_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P614_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P614_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P615_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P615_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P616_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public string Unknown9;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P616_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
            writer.WriteUtf16String(Unknown9);
        }
    }

    public class P617_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P617_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P618_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P618_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P619_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P619_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P620_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P620_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P621_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P621_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P622_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P622_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P623_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P623_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P624_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P624_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P625_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P625_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P626_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P626_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P627_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P627_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P628_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P628_Unknown);
        }
    }

    public class P629_Unknown : IPacketOut
    {
        public byte Unknown0;
        public short Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P629_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P630_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P630_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P631_Unknown : IPacketOut
    {
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P631_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P632_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P632_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P633_Unknown : IPacketOut
    {
        public byte Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P633_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P634_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P634_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P635_Unknown : IPacketOut
    {
        public short Unknown0;
        public short Unknown1;
        public short[] Unknown2;
        public byte[] Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P635_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.Write((byte)Unknown2.Length);
            for (int i = 0; i < Unknown2.Length; i++)
            {
                writer.Write(Unknown2[i]);
            }
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.Write(Unknown3[i]);
            }
        }
    }

    public class P636_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P636_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write(Unknown3);
        }
    }

    public class P637_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P637_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P638_Unknown : IPacketOut
    {
        public int Unknown0;
        public long Unknown1;
        public long Unknown2;
        public long Unknown3;
        public long Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P638_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
            writer.Write(Unknown3);
            writer.Write(Unknown4);
        }
    }

    public class P639_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P639_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P640_Unknown : IPacketOut
    {
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P640_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P641_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P641_Unknown);
        }
    }

    public class P642_Unknown : IPacketOut
    {
        public UID Unknown0;
        public long Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P642_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P643_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P643_Unknown);
        }
    }

    public class P644_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P644_Unknown);
        }
    }

    public class P646_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P646_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P647_Unknown : IPacketOut
    {
        public UID Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P647_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P648_Unknown : IPacketOut
    {
        public short Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P648_Unknown);
            writer.Write(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P649_Unknown : IPacketOut
    {
        public short Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P649_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P650_Unknown : IPacketOut
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P650_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P651_Unknown : IPacketOut
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

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P651_Unknown);
            writer.Write(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
            writer.WriteVector4(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVector4(Unknown5);
            writer.Write(Unknown6);
            writer.Write(Unknown7);
            writer.Write(Unknown8);
        }
    }

    public class P652_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P652_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P653_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P653_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P655_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P655_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P656_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int[] Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P656_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.Write((byte)Unknown3.Length);
            for (int i = 0; i < Unknown3.Length; i++)
            {
                writer.WriteVarint(Unknown3[i]);
            }
        }
    }

    public class P657_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P657_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }

    public class P658_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P658_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P659_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P659_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P660_Unknown : IPacketOut
    {
        public byte Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P660_Unknown);
            writer.Write(Unknown0);
        }
    }

    public class P661_Unknown : IPacketOut
    {
        public int Unknown0;
        public UID Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P661_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUID(Unknown1);
        }
    }

    public class P662_Unknown : IPacketOut
    {
        public int Unknown0;
        public int[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P662_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
        }
    }

    public class P663_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P663_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P664_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P664_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
        }
    }

    public class P665_Unknown : IPacketOut
    {
        public UID Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P665_Unknown);
            writer.WriteUID(Unknown0);
        }
    }

    public class P666_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P666_Unknown);
        }
    }

    public class P667_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P667_Unknown);
        }
    }

    public class P668_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P668_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P669_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P669_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P670_PvPPoints : IPacketOut
    {
        public int QualifyingPoints;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P670_PvPPoints);
            writer.WriteVarint(QualifyingPoints);
        }
    }

    public class P671_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P671_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P672_Unknown : IPacketOut
    {
        public int[] Unknown0;
        public int[] Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P672_Unknown);
            writer.Write((byte)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                writer.WriteVarint(Unknown0[i]);
            }
            writer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                writer.WriteVarint(Unknown1[i]);
            }
        }
    }

    public class P673_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P673_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
        }
    }

    public class P674_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P674_Unknown);
        }
    }

    public class P676_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P676_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P677_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P677_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P678_AccountLaurels : IPacketOut
    {
        public int Amount;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P678_AccountLaurels);
            writer.WriteVarint(Amount);
        }
    }

    public class P679_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P679_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P680_Unknown : IPacketOut
    {
        public int Unknown0;
        public short Unknown1;
        public short Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P680_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P681_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P681_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P682_Unknown : IPacketOut
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P682_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUtf16String(Unknown1);
            writer.WriteUtf16String(Unknown2);
        }
    }

    public class P683_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P683_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P684_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P684_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P685_Unknown : IPacketOut
    {
        public int Unknown0;
        public byte Unknown1;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P685_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write(Unknown1);
        }
    }

    public class P686_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P686_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.Write(Unknown2);
        }
    }

    public class P687_Unknown : IPacketOut
    {
        public UID Unknown0;
        public byte Unknown1;
        public int Unknown2;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)GamePacketHeaderOut.P687_Unknown);
            writer.WriteUID(Unknown0);
            writer.Write(Unknown1);
            writer.WriteVarint(Unknown2);
        }
    }
}
