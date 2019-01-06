using System;

namespace GW2Emu.AuthServer.In
{
    public enum AuthPacketHeaderIn : ushort
    {
        P01_PingServer = 1,
        P02_ComputerUserName = 2,
        P03_ComputerInfo = 3,
        P04_Unknown = 4,
        P05_Unknown = 5,
        P10_ClientSessionInfo = 10,
        P11_ClientDisconnect = 11,
        P12_Unknown = 12,
        P14_Unknown = 14,
        P15_Unknown = 15,
        P16_Unknown = 16,
        P20_CharacterDelete = 20,
        P21_Unknown = 21,
        P22_CharacterSelect = 22,
        P23_Unknown = 23,
        P24_Unknown = 24,
        P25_Unknown = 25,
        P26_Unknown = 26,
        P29_Unknown = 29,
        P34_Unknown = 34,
        P35_Unknown = 35,
        P36_Unknown = 36
    }
}
