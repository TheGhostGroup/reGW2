using System;
using System.IO;
using System.Net;
using GW2Emu.Common;

namespace GW2Emu.AuthServer.Out
{
    public class P01_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P01_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P02_ComputerInfoReply : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P02_ComputerInfoReply);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P03_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public IPEndPoint ConnectionInfo;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P03_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteIPEndPoint(ConnectionInfo);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
        }
    }

    public class P04_ClientSync : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P04_ClientSync);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }

    public class P07_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P07_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
        }
    }

    public class P08_AccountInfo : IPacketOut
    {
        public int SyncCount;
        public UID Unknown1;
        public UID Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public byte[] Unknown9;
        public struct Struct10
        {
            public short Unknown11;
            public short Unknown12;
            public int Unknown13;
            public int Unknown14;
            public int Unknown15;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown11);
                writer.Write(Unknown12);
                writer.WriteVarint(Unknown13);
                writer.WriteVarint(Unknown14);
                writer.WriteVarint(Unknown15);
            }
        }
        public Struct10[] Unknown16;
        public byte[] Unknown17;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P08_AccountInfo);
            writer.WriteVarint(SyncCount);
            writer.WriteUID(Unknown1);
            writer.WriteUID(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
            writer.WriteVarint(Unknown7);
            writer.WriteVarint(Unknown8);
            for (int i = 0; i < Unknown9.Length; i++)
            {
                writer.Write(Unknown9[i]);
            }
            writer.Write((byte)Unknown16.Length);
            for (int i = 0; i < Unknown16.Length; i++)
            {
                Unknown16[i].Serialize(writer);
            }
            for (int i = 0; i < Unknown17.Length; i++)
            {
                writer.Write(Unknown17[i]);
            }
        }
    }

    public class P10_AccountMedals : IPacketOut
    {
        public int SyncCount;
        public byte[] MedalData;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P10_AccountMedals);
            writer.WriteVarint(SyncCount);
            writer.Write((ushort)MedalData.Length);
            for (int i = 0; i < MedalData.Length; i++)
            {
                writer.Write(MedalData[i]);
            }
        }
    }

    public class P13_Unknown : IPacketOut
    {
        public struct Struct0
        {
            public short Unknown1;
            public short Unknown2;
            public int Unknown3;
            public int Unknown4;
            public int Unknown5;

            public void Serialize(PacketWriter writer)
            {
                writer.Write(Unknown1);
                writer.Write(Unknown2);
                writer.WriteVarint(Unknown3);
                writer.WriteVarint(Unknown4);
                writer.WriteVarint(Unknown5);
            }
        }
        public Struct0[] Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P13_Unknown);
            writer.Write((byte)Unknown6.Length);
            for (int i = 0; i < Unknown6.Length; i++)
            {
                Unknown6[i].Serialize(writer);
            }
        }
    }

    public class P16_Unknown : IPacketOut
    {
        public int SyncCount;
        public UID Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P16_Unknown);
            writer.WriteVarint(SyncCount);
            writer.WriteUID(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
            writer.WriteVarint(Unknown5);
            writer.WriteVarint(Unknown6);
        }
    }

    public class P17_CharacterInfo : IPacketOut
    {
        public int SyncCount;
        public UID CharacterId;
        public int Unknown2;
        public string CharacterName;
        public byte[] CharacterData;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P17_CharacterInfo);
            writer.WriteVarint(SyncCount);
            writer.WriteUID(CharacterId);
            writer.WriteVarint(Unknown2);
            writer.WriteUtf16String(CharacterName);
            writer.Write((ushort)CharacterData.Length);
            for (int i = 0; i < CharacterData.Length; i++)
            {
                writer.Write(CharacterData[i]);
            }
        }
    }

    public class P18_Unknown : IPacketOut
    {
        public int Unknown0;
        public UID Unknown1;
        public int Unknown2;
        public string Unknown3;
        public byte[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P18_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteUID(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteUtf16String(Unknown3);
            writer.Write((ushort)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                writer.Write(Unknown4[i]);
            }
        }
    }

    public class P20_ReferToGameServer : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public IPEndPoint ConnectionInfo;
        public int Unknown5;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P20_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteIPEndPoint(ConnectionInfo);
            writer.WriteVarint(Unknown5);
        }
    }

    public class P23_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P23_Unknown);
        }
    }

    public class P24_Unknown : IPacketOut
    {
        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P24_Unknown);
        }
    }

    public class P25_GameServerInfo : IPacketOut
    {
        public int Location;
        public int Population;
        public int TransferCost;
        public int Unknown3;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P25_GameServerInfo);
            writer.WriteVarint(Location);
            writer.WriteVarint(Population);
            writer.WriteVarint(TransferCost);
            writer.WriteVarint(Unknown3);
        }
    }

    public class P26_Unknown : IPacketOut
    {
        public int Unknown0;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P26_Unknown);
            writer.WriteVarint(Unknown0);
        }
    }

    public class P27_Unknown : IPacketOut
    {
        public int Unknown0;
        public struct Struct1
        {
            public int Unknown2;
            public int Unknown3;

            public void Serialize(PacketWriter writer)
            {
                writer.WriteVarint(Unknown2);
                writer.WriteVarint(Unknown3);
            }
        }
        public Struct1[] Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P27_Unknown);
            writer.WriteVarint(Unknown0);
            writer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i].Serialize(writer);
            }
        }
    }

    public class P28_Unknown : IPacketOut
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public void Serialize(PacketWriter writer)
        {
            writer.Write((ushort)AuthPacketHeaderOut.P28_Unknown);
            writer.WriteVarint(Unknown0);
            writer.WriteVarint(Unknown1);
            writer.WriteVarint(Unknown2);
            writer.WriteVarint(Unknown3);
            writer.WriteVarint(Unknown4);
        }
    }
}
