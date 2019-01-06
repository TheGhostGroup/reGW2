using System;
using System.IO;
using System.Net;
using GW2Emu.Common;

namespace GW2Emu.AuthServer.In
{
    public class P01_PingServer
    {
        public int Unknown0;

        public P01_PingServer(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P02_ComputerUserName
    {
        public string Unknown0;
        public string Unknown1;

        public P02_ComputerUserName(PacketReader reader)
        {
            Unknown0 = reader.ReadUtf16String();
            Unknown1 = reader.ReadUtf16String();
        }
    }

    public class P03_ComputerInfo
    {
        public int Unknown0;
        public byte[] Unknown1;

        public P03_ComputerInfo(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = new byte[16];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadByte();
            }
        }
    }

    public class P04_Unknown
    {
        public byte[] Unknown0;
        public UID Unknown1;

        public P04_Unknown(PacketReader reader)
        {
            byte Unknown0Length = reader.ReadByte();
            if (Unknown0Length > 97)
            {
                throw new InvalidDataException();
            }
            Unknown0 = new byte[Unknown0Length];
            for (int i = 0; i < Unknown0.Length; i++)
            {
                Unknown0[i] = reader.ReadByte();
            }
            Unknown1 = reader.ReadUID();
        }
    }

    public class P05_Unknown
    {
        public int Unknown0;

        public P05_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P10_ClientSessionInfo
    {
        public int Unknown0;
        public UID AccountId;
        public UID VerificationKey;
        public string Unknown3;

        public P10_ClientSessionInfo(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            AccountId = reader.ReadUID();
            VerificationKey = reader.ReadUID();
            Unknown3 = reader.ReadUtf16String();
        }
    }

    public class P11_ClientDisconnect
    {
        public int Unknown0;

        public P11_ClientDisconnect(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P12_Unknown
    {
        public int Unknown0;
        public byte[] Unknown1;

        public P12_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            ushort Unknown1Length = reader.ReadUInt16();
            if (Unknown1Length > 4098)
            {
                throw new InvalidDataException();
            }
            Unknown1 = new byte[Unknown1Length];
            for (int i = 0; i < Unknown1.Length; i++)
            {
                Unknown1[i] = reader.ReadByte();
            }
        }
    }

    public class P14_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;

        public P14_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadByte();
        }
    }

    public class P15_Unknown
    {
        public byte Unknown0;

        public P15_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadByte();
        }
    }

    public class P16_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;

        public P16_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
        }
    }

    public class P20_CharacterDelete
    {
        public int Unknown0;
        public string CharacterName;

        public P20_CharacterDelete(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            CharacterName = reader.ReadUtf16String();
        }
    }

    public class P21_Unknown
    {
        public int Unknown0;
        public UID Unknown1;
        public string Unknown2;

        public P21_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUID();
            Unknown2 = reader.ReadUtf16String();
        }
    }

    public class P22_CharacterSelect
    {
        public int Unknown0;
        public string CharacterName;

        public P22_CharacterSelect(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            CharacterName = reader.ReadUtf16String();
        }
    }

    public class P23_Unknown
    {
        public int Unknown0;
        public string Unknown1;
        public byte[] Unknown2;

        public P23_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUtf16String();
            byte Unknown2Length = reader.ReadByte();
            if (Unknown2Length > 255)
            {
                throw new InvalidDataException();
            }
            Unknown2 = new byte[Unknown2Length];
            for (int i = 0; i < Unknown2.Length; i++)
            {
                Unknown2[i] = reader.ReadByte();
            }
        }
    }

    public class P24_Unknown
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;

        public P24_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadUtf16String();
            Unknown2 = reader.ReadUtf16String();
        }
    }

    public class P25_Unknown
    {
        public int Unknown0;

        public P25_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P26_Unknown
    {
        public int Unknown0;

        public P26_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P29_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;

        public P29_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadVarint();
            Unknown3 = reader.ReadVarint();
            Unknown4 = reader.ReadVarint();
        }
    }

    public class P34_Unknown
    {
        public int Unknown0;

        public P34_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
        }
    }

    public class P35_Unknown
    {
        public P35_Unknown(PacketReader reader)
        {
        }
    }

    public class P36_Unknown
    {
        public int Unknown0;
        public int Unknown1;
        public string Unknown2;

        public P36_Unknown(PacketReader reader)
        {
            Unknown0 = reader.ReadVarint();
            Unknown1 = reader.ReadVarint();
            Unknown2 = reader.ReadUtf16String();
        }
    }
}
