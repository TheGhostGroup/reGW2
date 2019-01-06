using System;
using Mono.Math;

namespace GW2Emu.Common.Cryptography
{
    public static class DiffieHellman
    {
        public static byte[] GenerateSharedKey(byte[] publicClientKey, byte[] privateServerKey, byte[] prime)
        {
            byte[] publicClientKeyReversed = Utilities.Reverse(publicClientKey);

            BigInteger a = new BigInteger(publicClientKeyReversed);
            BigInteger x = new BigInteger(privateServerKey);
            BigInteger p = new BigInteger(prime);

            BigInteger sharedKey = a.ModPow(x, p);
            byte[] sharedKeyBytes = sharedKey.GetBytes();
            byte[] sharedKeyBytesReversed = Utilities.Reverse(sharedKeyBytes);

            return sharedKeyBytesReversed;
        }
    }
}
