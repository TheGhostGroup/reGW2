using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using GW2Emu.Common.Cryptography;
using LZ4Sharp;

namespace GW2Emu.Common
{
    public class SecurePacketBasedClient : Client
    {
        private enum UnencryptedPacket : byte
        {
            ClientVersionLength = 0x04,
            VerifyClientLength = 0x05,
            PublicClientKeyLength = 0x42,
            RC4SeedHeader = 0x01,
            RC4SeedLength = 0x16
        }

        public uint ClientVersion { get; private set; }

        private readonly ILZ4Compressor compressor = new LZ4Compressor32();

        private PacketManager packetManager;
        private RC4 rc4In;
        private RC4 rc4Out;

        public SecurePacketBasedClient()
        {
            Received += Handshake;
        }

        public SecurePacketBasedClient(IPAddress address, int port) : base(address, port)
        {
        }

        public SecurePacketBasedClient(Socket socket) : base(socket)
        {
            Received += Handshake;
        }

        public override void SetState(object state)
        {
            packetManager = (PacketManager)state;
        }

        protected override byte[] ProcessIncomingData(byte[] data)
        {
            if (RC4Initialized)
            {
                return rc4In.Process(data);
            }

            return data;
        }

        protected override byte[] ProcessOutgoingData(byte[] data)
        {
            if (RC4Initialized)
            {
                return rc4Out.Process(data);
            }

            return data;
        }

        public void SendPacket(IPacketOut packetTemplate)
        {
            MemoryStream stream = new MemoryStream();
            PacketWriter writer = new PacketWriter(stream);
            packetTemplate.Serialize(writer);

            byte[] uncompressed = stream.ToArray();
            byte[] compressed = compressor.Compress(uncompressed);

            Packet packet = Packet.Create();
            packet.Writer.Write((short)compressed.Length);
            packet.Writer.Write((short)uncompressed.Length);
            packet.Writer.Write(compressed);
            Send(packet.Data);
        }

        private void Handshake(byte[] data)
        {
            Packet packet = new Packet(this, data);
            while (packet.Stream.Position < packet.Stream.Length)
            {
                byte header = packet.Reader.ReadByte();
                UnencryptedPacket length = (UnencryptedPacket)packet.Reader.ReadByte();

                switch (length)
                {
                    case UnencryptedPacket.ClientVersionLength:
                        packet.Reader.BaseStream.Position += 2;
                        ClientVersion = packet.Reader.ReadUInt32();
                        packet.Reader.BaseStream.Position += 8;
                        break;
                    case UnencryptedPacket.VerifyClientLength:
                        Console.WriteLine("VerifyClient");
                        break;
                    case UnencryptedPacket.PublicClientKeyLength:
                        byte[] publicClientKey = packet.Reader.ReadBytes(64);
                        byte[] sharedKey = DiffieHellman.GenerateSharedKey(publicClientKey, Keys.PrivateKey, Keys.Prime);
                        byte[] randomBytes = Utilities.RandomBytes();
                        byte[] hashedRandomBytes = Utilities.Hash(randomBytes);
                        byte[] xoredRandomBytes = Utilities.XOR(randomBytes, sharedKey);
                        SendRC4Seed(xoredRandomBytes);
                        SetRC4Key(hashedRandomBytes);
                        Received -= Handshake;
                        Received += PacketReceived;
                        break;
                    default:
                        Console.WriteLine("Unhandled unencrypted packet!"); /* 0x" + length.ToString("X2")); - with this addition to WriteLine, server fails*/
                        return;
                }
            }
        }

        private void SendRC4Seed(byte[] xoredRandomBytes)
        {
            Packet packet = Packet.Create();
            packet.Writer.Write((byte)UnencryptedPacket.RC4SeedHeader);
            packet.Writer.Write((byte)UnencryptedPacket.RC4SeedLength);
            packet.Writer.WriteBytes(xoredRandomBytes);
            Send(packet.Data);
        }

        private void PacketReceived(byte[] data)
        {
            Packet packet = new Packet(this, data);
            while (packet.Stream.Position < packet.Stream.Length)
            {
                if (!packetManager.OnPacketReceived(this, packet))
                {
                    return;
                }
            }
        }

        public void SetRC4Key(byte[] key)
        {
            rc4In = new RC4(key);
            rc4Out = new RC4(key);
        }

        public bool RC4Initialized
        {
            get
            {
                return (rc4In.Initialized() && rc4Out.Initialized());
            }
        }
    }
}
