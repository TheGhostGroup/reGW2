using System;
using GW2Emu.Common;
using GW2Emu.AuthServer.In;

namespace GW2Emu.AuthServer
{
    public class AuthServerPacketManager : PacketManager
    {
        public event PacketEventHandler<P01_PingServer> P01_PingServer;
        public event PacketEventHandler<P02_ComputerUserName> P02_ComputerUserName;
        public event PacketEventHandler<P03_ComputerInfo> P03_ComputerInfo;
        public event PacketEventHandler<P04_Unknown> P04_Unknown;
        public event PacketEventHandler<P05_Unknown> P05_Unknown;
        public event PacketEventHandler<P10_ClientSessionInfo> P10_ClientSessionInfo;
        public event PacketEventHandler<P11_ClientDisconnect> P11_ClientDisconnect;
        public event PacketEventHandler<P12_Unknown> P12_Unknown;
        public event PacketEventHandler<P14_Unknown> P14_Unknown;
        public event PacketEventHandler<P15_Unknown> P15_Unknown;
        public event PacketEventHandler<P16_Unknown> P16_Unknown;
        public event PacketEventHandler<P20_CharacterDelete> P20_CharacterDelete;
        public event PacketEventHandler<P21_Unknown> P21_Unknown;
        public event PacketEventHandler<P22_CharacterSelect> P22_CharacterSelect;
        public event PacketEventHandler<P23_Unknown> P23_Unknown;
        public event PacketEventHandler<P24_Unknown> P24_Unknown;
        public event PacketEventHandler<P25_Unknown> P25_Unknown;
        public event PacketEventHandler<P26_Unknown> P26_Unknown;
        public event PacketEventHandler<P29_Unknown> P29_Unknown;
        public event PacketEventHandler<P34_Unknown> P34_Unknown;
        public event PacketEventHandler<P35_Unknown> P35_Unknown;
        public event PacketEventHandler<P36_Unknown> P36_Unknown;

        public override bool OnPacketReceived(SecurePacketBasedClient client, Packet packet)
        {
            AuthPacketHeaderIn header = (AuthPacketHeaderIn)packet.Reader.ReadUInt16();
            
            switch (header)
            {
                case AuthPacketHeaderIn.P01_PingServer:
                    RaiseEvent<P01_PingServer>(P01_PingServer, client, new P01_PingServer(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P02_ComputerUserName:
                    RaiseEvent<P02_ComputerUserName>(P02_ComputerUserName, client, new P02_ComputerUserName(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P03_ComputerInfo:
                    RaiseEvent<P03_ComputerInfo>(P03_ComputerInfo, client, new P03_ComputerInfo(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P04_Unknown:
                    RaiseEvent<P04_Unknown>(P04_Unknown, client, new P04_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P05_Unknown:
                    RaiseEvent<P05_Unknown>(P05_Unknown, client, new P05_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P10_ClientSessionInfo:
                    RaiseEvent<P10_ClientSessionInfo>(P10_ClientSessionInfo, client, new P10_ClientSessionInfo(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P11_ClientDisconnect:
                    RaiseEvent<P11_ClientDisconnect>(P11_ClientDisconnect, client, new P11_ClientDisconnect(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P12_Unknown:
                    RaiseEvent<P12_Unknown>(P12_Unknown, client, new P12_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P14_Unknown:
                    RaiseEvent<P14_Unknown>(P14_Unknown, client, new P14_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P15_Unknown:
                    RaiseEvent<P15_Unknown>(P15_Unknown, client, new P15_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P16_Unknown:
                    RaiseEvent<P16_Unknown>(P16_Unknown, client, new P16_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P20_CharacterDelete:
                    RaiseEvent<P20_CharacterDelete>(P20_CharacterDelete, client, new P20_CharacterDelete(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P21_Unknown:
                    RaiseEvent<P21_Unknown>(P21_Unknown, client, new P21_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P22_CharacterSelect:
                    RaiseEvent<P22_CharacterSelect>(P22_CharacterSelect, client, new P22_CharacterSelect(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P23_Unknown:
                    RaiseEvent<P23_Unknown>(P23_Unknown, client, new P23_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P24_Unknown:
                    RaiseEvent<P24_Unknown>(P24_Unknown, client, new P24_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P25_Unknown:
                    RaiseEvent<P25_Unknown>(P25_Unknown, client, new P25_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P26_Unknown:
                    RaiseEvent<P26_Unknown>(P26_Unknown, client, new P26_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P29_Unknown:
                    RaiseEvent<P29_Unknown>(P29_Unknown, client, new P29_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P34_Unknown:
                    RaiseEvent<P34_Unknown>(P34_Unknown, client, new P34_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P35_Unknown:
                    RaiseEvent<P35_Unknown>(P35_Unknown, client, new P35_Unknown(packet.Reader));
                    return true;
                case AuthPacketHeaderIn.P36_Unknown:
                    RaiseEvent<P36_Unknown>(P36_Unknown, client, new P36_Unknown(packet.Reader));
                    return true;
                default:
                    Console.WriteLine("Unhandled packet: " + header);
                    return false;
            }
        }
    }
}
