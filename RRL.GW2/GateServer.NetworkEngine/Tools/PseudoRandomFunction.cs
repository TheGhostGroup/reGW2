using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RRL.GW2.GateServer.Networking.Tools
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    internal class PseudoRandomFunction
    {
        private readonly HMACSHA256 _hmac;
        private readonly byte[] _seed;

        public PseudoRandomFunction(byte[] secret, string label, IEnumerable<byte> seed)
        {
            _seed = Encoding.ASCII.GetBytes(label).Concat(seed).ToArray();

            _hmac = new HMACSHA256(secret);
        }

        public byte[] GenerateBytes(int outputLength)
        {
            return PHash(outputLength);
        }

        private byte[] PHash(int outputLength)
        {
            List<byte> result = new List<byte>(outputLength);

            int i = 1;
            do
            {
                byte[] hash = _hmac.ComputeHash(A(i).Concat(_seed).ToArray());
                result.AddRange(hash);
                i++;
            } while (result.Count < outputLength);

            return result.Take(outputLength).ToArray();
        }

        private byte[] A(int i)
        {
            return i == 0 ? _seed : _hmac.ComputeHash(A(i - 1));
        }
    }
}