namespace RRL.GW2.Common.Network
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
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