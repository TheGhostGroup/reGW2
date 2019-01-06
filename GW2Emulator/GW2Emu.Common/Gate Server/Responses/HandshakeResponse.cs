using System;
using System.Security.Cryptography;


namespace GW2Emu.Common
{
    internal static class HandshakeResponse
    {
        public static void ServerHello(TlsConnection connection)
        {
            byte[] data = new byte[]
                {
                    0x03, 0x03 // Version: TLS 1.2
                    , 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    , 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    , 0x00 // Session ID length: 0
                    , 0xc0, 0x1d // Cipher suite: TLS_SRP_SHA_WITH_AES_128_CBC_SHA
                    , 0x00 // Compression method: null
                };

            connection.ServerRandom = new byte[32];
            Utils.Random.NextBytes(connection.ServerRandom);
            Buffer.BlockCopy(connection.ServerRandom, 0, data, 2, 32);
            TlsResponse.Handshake(connection, 2, ref data);
        }

        public static void ServerKeyExchange(TlsConnection connection)
        {
            byte[] data = new byte[7 +
                                   TlsConnection.SrpNBytes.Length +
                                   TlsConnection.SrpGBytes.Length +
                                   TlsConnection.SrpSBytes.Length +
                                   connection.SrpB.Length];

            //N
            data[0] = (byte)(TlsConnection.SrpNBytes.Length >> 8);
            data[1] = (byte)TlsConnection.SrpNBytes.Length;
            Buffer.BlockCopy(TlsConnection.SrpNBytes, 0, data, 2, TlsConnection.SrpNBytes.Length);
            int offset = TlsConnection.SrpNBytes.Length + 2;

            //G
            data[offset] = (byte)(TlsConnection.SrpGBytes.Length >> 8);
            data[offset + 1] = (byte)TlsConnection.SrpGBytes.Length;
            Buffer.BlockCopy(TlsConnection.SrpGBytes, 0, data, offset + 2, TlsConnection.SrpGBytes.Length);
            offset += TlsConnection.SrpGBytes.Length + 2;

            //S
            data[offset] = (byte)TlsConnection.SrpSBytes.Length;
            Buffer.BlockCopy(TlsConnection.SrpSBytes, 0, data, offset + 1, TlsConnection.SrpSBytes.Length);
            offset += TlsConnection.SrpSBytes.Length + 1;

            //B
            data[offset] = (byte)(connection.SrpB.Length >> 8);
            data[offset + 1] = (byte)connection.SrpB.Length;
            Buffer.BlockCopy(connection.SrpB, 0, data, offset + 2, connection.SrpB.Length);
            TlsResponse.Handshake(connection, 12, ref data);
        }

        public static void ServerHelloDone(TlsConnection connection)
        {
            Log.Success("ServerHelloDone", "Finished server hello!");
            byte[] data = new byte[0];
            TlsResponse.Handshake(connection, 14, ref data);
        }

        public static void ServerChangeCipherSpec(TlsConnection connection)
        {
            byte[] data = new byte[] { 1 };
            TlsResponse.ChangeCipherSpec(connection, ref data);
        }

        public static void ServerServerFinish(TlsConnection connection)
        {
            Log.Success("ServerServerFinish", "Finished the transaction!");
            var sha256 = SHA256.Create();
            var handshakeHash = sha256.ComputeHash(connection.HandshakeMessages.ToArray());
            var prfClient = new PseudoRandomFunction(connection.MasterSecretBytes, "server finished", handshakeHash);
            byte[] servVerData = prfClient.GenerateBytes(12);

            TlsResponse.Handshake(connection, 20, ref servVerData);
        }
    }
}
