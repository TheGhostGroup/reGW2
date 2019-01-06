namespace RRL.GW2.Common.Crypto
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public interface ICipher
    {
        void Process(ref byte[] data, int fromIndex, int toIndex);
    }
}
