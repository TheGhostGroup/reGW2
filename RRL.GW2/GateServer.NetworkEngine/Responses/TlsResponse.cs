using System;
using System.Linq;
using System.Security.Cryptography;

namespace GateServer.NetworkEngine.Responses
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    internal static class TlsResponse
    {
        public static void Handshake(TlsConnection connection, byte type, ref byte[] data)
        {
            byte[] resultData = new byte[data.Length + 4];
            resultData[0] = type;
            resultData[1] = (byte)(data.Length >> 16);
            resultData[2] = (byte)(data.Length >> 8);
            resultData[3] = (byte)data.Length;
            Buffer.BlockCopy(data, 0, resultData, 4, data.Length);

            if (connection.HandshakeMessages != null)
                connection.HandshakeMessages.AddRange(resultData);

            Send(connection, 22, ref resultData);
        }

        public static void ChangeCipherSpec(TlsConnection connection, ref byte[] data)
        {
            Send(connection, 20, ref data);
        }

        public static void Message(TlsConnection connection, ref byte[] data)
        {
            Send(connection, 23, ref data);
        }

        private static void Send(TlsConnection connection, byte type, ref byte[] data)
        {
            if (connection.SendEncrypted)
                data = Encrypt(connection, type, ref data);

            byte[] resultData = new byte[data.Length + 5];
            resultData[0] = type;
            resultData[1] = 3;
            resultData[2] = 3;
            resultData[3] = (byte)(data.Length >> 8);
            resultData[4] = (byte)data.Length;
            Buffer.BlockCopy(data, 0, resultData, 5, data.Length);

            connection.Send(resultData);
        }

        private static byte[] Encrypt(TlsConnection connection, byte type, ref byte[] data)
        {
            byte[] toHash = new byte[13 + data.Length];

            toHash[0] = (byte)(connection.TlsSequence >> 56);
            toHash[1] = (byte)(connection.TlsSequence >> 48);
            toHash[2] = (byte)(connection.TlsSequence >> 40);
            toHash[3] = (byte)(connection.TlsSequence >> 32);
            toHash[4] = (byte)(connection.TlsSequence >> 24);
            toHash[5] = (byte)(connection.TlsSequence >> 16);
            toHash[6] = (byte)(connection.TlsSequence >> 8);
            toHash[7] = (byte)connection.TlsSequence;

            connection.TlsSequence++;

            toHash[8] = type;
            toHash[9] = 3;
            toHash[10] = 3;
            toHash[11] = (byte)(data.Length >> 8);
            toHash[12] = (byte)data.Length;

            Buffer.BlockCopy(data, 0, toHash, 13, data.Length);

            var mac = new HMACSHA1(connection.ServerWriteMacKey);
            byte[] hash = mac.ComputeHash(toHash, 0, toHash.Length);

            var aes = new AesManaged();
            aes.GenerateIV();
            aes.Key = connection.ServerWriteKey;
            aes.Padding = PaddingMode.PKCS7;

            byte padding = (byte)(((((data.Length + 20) >> 4) + 1) << 4) - data.Length - 21);
            byte[] toCipher = data.Concat(hash).Concat(new[] { padding }).ToArray();
            byte[] encrypted = aes.CreateEncryptor().TransformFinalBlock(toCipher, 0, toCipher.Length);

            return aes.IV.Concat(encrypted).ToArray();
        }
    }
}
