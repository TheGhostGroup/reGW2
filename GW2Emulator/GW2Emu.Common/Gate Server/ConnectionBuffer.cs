namespace GW2Emu.Common
{
    public class ConnectionBuffer
    {
        public byte[] Data = new byte[4068];

        public int ReadIndex;

        public int WriteIndex;

        public int Avaliable
        {
            get { return WriteIndex - ReadIndex; }
        }
    }
}