using System;

namespace GW2Emu.AuthServer.Out
{
    public enum AuthPacketHeaderOut : ushort
    {
        P01_Unknown = 1,
        P02_ComputerInfoReply = 2,
        P03_Unknown = 3,
        P04_ClientSync = 4,
        P07_Unknown = 7,
        P08_AccountInfo = 8,
        P10_AccountMedals = 10,
        P13_Unknown = 13,
        P16_Unknown = 16,
        P17_CharacterInfo = 17,
        P18_Unknown = 18,
        P20_Unknown = 20,
        P23_Unknown = 23,
        P24_Unknown = 24,
        P25_GameServerInfo = 25,
        P26_Unknown = 26,
        P27_Unknown = 27,
        P28_Unknown = 28
    }
}
