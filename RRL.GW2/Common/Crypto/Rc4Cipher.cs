using RRL.GW2.Common.Network;

namespace RRL.GW2.Common.Crypto
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public class Rc4Cipher : ICipher
    {
        private readonly byte[] _sBox = new byte[256];
        private byte _i;
        private byte _j;

        public Rc4Cipher(ref byte[] key)
        {
            for (int i = 0; i < 256; i++)
                _sBox[i] = (byte) i;

            byte j = 0;

            for (int i = 0; i < 256; i++)
            {
                j += (byte) (_sBox[i] + key[i%key.Length]);

                byte c = _sBox[i];
                _sBox[i] = _sBox[j];
                _sBox[j] = c;
            }
        }

        public void Process(ref byte[] data, int fromIndex, int toIndex)
        {
            for (int n = fromIndex; n < toIndex; n++)
            {
                _i++;
                _j += _sBox[_i];

                byte c = _sBox[_i];
                _sBox[_i] = _sBox[_j];
                _sBox[_j] = c;

                data[n] = (byte)(_sBox[(_sBox[_i] + _sBox[_j]) % 256] ^ data[n]);
            }
        }
    }
}