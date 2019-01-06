using System;
using System.IO;

namespace GW2Emu.Common
{
    public class Packet
    {
        public static Packet Create()
        {
            return new Packet();
        }

        private MemoryStream stream;
        private PacketReader reader;
        private PacketWriter writer;

        public Packet()
        {
            stream = new MemoryStream();
            reader = new PacketReader(stream, null);
            writer = new PacketWriter(stream);
        }

        public Packet(Client client)
        {
            stream = new MemoryStream();
            reader = new PacketReader(stream, client);
            writer = new PacketWriter(stream);
        }

        public Packet(Client client, byte[] data)
        {
            stream = new MemoryStream();
            stream.Write(data, 0, data.Length);
            stream.Position = 0;
            reader = new PacketReader(stream, client);
            writer = new PacketWriter(stream);
        }

        public PacketReader Reader
        {
            get
            {
                return reader;
            }
        }

        public PacketWriter Writer
        {
            get
            {
                return writer;
            }
        }

        public Stream Stream
        {
            get
            {
                return stream;
            }
        }

        public byte[] Data
        {
            get
            {
                return stream.ToArray();
            }
        }
    }
}
