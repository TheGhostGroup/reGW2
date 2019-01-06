using System;
using System.IO;
using System.Net;
using System.Text;

using GW2Emu.Common.Collections;

namespace GW2Emu.Common
{
    public class PacketWriter : BinaryWriter
    {
        public PacketWriter(Stream stream) : this(stream, Encoding.Unicode) { }
        public PacketWriter(Stream stream, Encoding encoding) : base(stream, encoding) { }

        public void WriteVarint(int value)
        {
            bool first = true;

            while (first || value > 0)
            {
                first = false;
                byte lower7bits = (byte)(value & 0x7f);
                value >>= 7;
                if (value > 0)
                    lower7bits |= 128;
                Write(lower7bits);
            }
        }

        public void WriteVarbyte(long value, int count)
        {
            DataCollection<byte> data = new DataCollection<byte>(BitConverter.GetBytes(value));
            Write(data.ReadRange(count));
        }

        public void WriteBytes(byte[] value)
        {
            Write(value);
        }

        public void WriteChar(char value, Encoding encoding)
        {
            char[] data = new char[] { value };
            Write(encoding.GetBytes(data));
        }

        public void WriteUtf16String(string value)
        {
            foreach (char tmp in value)
            {
                WriteChar(tmp, Encoding.Unicode);
            }

            WriteChar('\0', Encoding.Unicode);
        }

        public void WriteVector2(Vector2 value)
        {
            Write(value.X);
            Write(value.Y);
        }

        public void WriteVector3(Vector3 value)
        {
            Write(value.X);
            Write(value.Y);
            Write(value.Z);
        }

        public void WriteVector4(Vector4 value)
        {
            Write(value.X);
            Write(value.Y);
            Write(value.Z);
            Write(value.W);
        }

        public void WriteWorldPosition(WorldPosition value)
        {
            WriteVector3(value.Vector);
            WriteVarint(value.W);
        }

        public void WriteUID(UID value)
        {
            Write(value.Data);
        }

        public void WriteIPEndPoint(IPEndPoint value)
        {
            SocketAddress socketAddress = value.Serialize();
            byte[] socketAddressBytes = new byte[28];

            for (int i = 0; i < socketAddress.Size; i++)
            {
                socketAddressBytes[i] = socketAddress[i];
            }

            WriteBytes(socketAddressBytes);
        }
    }
}