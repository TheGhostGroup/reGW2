using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

using GW2Emu.Common.Collections;

namespace GW2Emu.Common
{
    public class PacketReader : BinaryReader
    {
        private Client client;

        public PacketReader(Stream stream, Client client) : this(stream, client, Encoding.Unicode) { }
        public PacketReader(Stream stream, Client client, Encoding encoding) : base(stream, encoding)
        {
            this.client = client;
        }

        public override byte ReadByte()
        {
            CheckAndBlock(1);
            return base.ReadByte();
        }

        public override bool ReadBoolean()
        {
            CheckAndBlock(1);
            return base.ReadBoolean();
        }

        public override short ReadInt16()
        {
            CheckAndBlock(2);
            return base.ReadInt16();
        }

        public override int ReadInt32()
        {
            CheckAndBlock(4);
            return base.ReadInt32();
        }

        public override long ReadInt64()
        {
            CheckAndBlock(8);
            return base.ReadInt64();
        }

        public override ushort ReadUInt16()
        {
            CheckAndBlock(2);
            return base.ReadUInt16();
        }

        public override uint ReadUInt32()
        {
            CheckAndBlock(4);
            return base.ReadUInt32();
        }

        public override ulong ReadUInt64()
        {
            CheckAndBlock(8);
            return base.ReadUInt64();
        }

        public int ReadVarint()
        {
            bool more = true;
            int value = 0;
            int shift = 0;

            while (more)
            {
                byte lower7bits = ReadByte();
                more = (lower7bits & 128) != 0;
                value |= (lower7bits & 0x7f) << shift;
                shift += 7;
            }

            return value;
        }

        public long ReadVarbyte(int count)
        {
            DataCollection<byte> data = new DataCollection<byte>();
            data.WriteRange(ReadBytes(count));
            data.WriteRange(new byte[8 - data.Length]);
            return BitConverter.ToInt64(data.ToArray(), 0);
        }

        public new byte[] ReadBytes(int count)
        {
            CheckAndBlock(count);
            return base.ReadBytes(count);
        }

        public char ReadChar(Encoding encoding)
        {
            byte[] data = ReadBytes(2);
            return encoding.GetChars(data)[0];
        }

        public string ReadUtf16String()
        {
            DataCollection<char> charCollection = new DataCollection<char>();

            bool isDelimiter = false;

            while (!isDelimiter)
            {
                char tmp = ReadChar(Encoding.Unicode);

                if (tmp == '\0')
                {
                    isDelimiter = true;
                }
                else
                {
                    charCollection.Write(tmp);
                }
            }

            char[] chars = charCollection.ToArray();

            string result = new string(chars);

            return result;
        }

        public Vector2 ReadVector2()
        {
            CheckAndBlock(8);
            float x = base.ReadSingle();
            float y = base.ReadSingle();
            return new Vector2(x, y);
        }

        public Vector3 ReadVector3()
        {
            CheckAndBlock(12);
            float x = base.ReadSingle();
            float y = base.ReadSingle();
            float z = base.ReadSingle();
            return new Vector3(x, y, z);
        }

        public Vector4 ReadVector4()
        {
            CheckAndBlock(16);
            float x = base.ReadSingle();
            float y = base.ReadSingle();
            float z = base.ReadSingle();
            float w = base.ReadSingle();
            return new Vector4(x, y, z, w);
        }

        public WorldPosition ReadWorldPosition()
        {
            Vector3 vector = ReadVector3();
            int w = ReadVarint();
            return new WorldPosition(vector, w);
        }
        
        public UID ReadUID()
        {
            byte[] data = ReadBytes(16);
            return new UID(data);
        }

        public IPEndPoint ReadIPEndPoint()
        {
            SocketAddress socketAddress = new SocketAddress(AddressFamily.InterNetwork);
            byte[] socketAddressBytes = ReadBytes(28);

            for (int i = 0; i < socketAddressBytes.Length; i++)
            {
                socketAddress[i] = socketAddressBytes[i];
            }

            return (IPEndPoint)(new IPEndPoint(IPAddress.Any, 0).Create(socketAddress));
        }

        public void CheckAndBlock(int count)
        {
            if (BaseStream.Position + count > BaseStream.Length)
            {
                while (BaseStream.Position + count > BaseStream.Position)
                {
                    byte[] data = client.Receive();
                    BaseStream.Write(data, 0, data.Length);
                }
            }
        }
    }
}
