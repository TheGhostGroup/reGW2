using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Math;


namespace GW2Emu.Common
{
    internal static class HandshakeRequest
    {
        public static void ClientHello(TlsConnection connection, int length)
        {
            connection.Buffer.ReadIndex += 2;
            connection.ClientRandom = connection.Buffer.Read(32);
            connection.Buffer.ReadIndex++;
            int cipherSuitesLength = connection.Buffer.ReadShort();
            connection.Buffer.ReadIndex += cipherSuitesLength;
            connection.Buffer.ReadIndex += 2;

            string login = "";

            int extensionsLength = connection.Buffer.ReadShort();
            while (extensionsLength > 0)
            {
                int extensionId = connection.Buffer.ReadShort();
                byte[] extensionData = connection.Buffer.Read(connection.Buffer.ReadShort());

                if (extensionId == 12)
                {
                    login = Encoding.ASCII.GetString(extensionData, 1, extensionData[0]);
                    break;
                }
            }

            var ac = GtSGlobal.AuthEngine.ClientAuth(connection, login, "1");
            if(ac != null)
            {
                connection.Account = ac;

                connection.InitSrp(login);

                HandshakeResponse.ServerHello(connection);
                HandshakeResponse.ServerKeyExchange(connection);
                HandshakeResponse.ServerHelloDone(connection);
            }
        }

        public static void ClientKeyExchange(TlsConnection connection, int length)
        {
            connection.PreMasterSecret =
                connection.SrpServer.CalculateSecret(
                new BigInteger(1, connection.Buffer.Read(connection.Buffer.ReadShort())));
        }

        public static void ClientFinish(TlsConnection connection, int length)
        {
            Log.Success("ClientFinish", "Finished transaction!");
            var sha256 = SHA256.Create();
            var handshakeData = connection.HandshakeMessages.GetRange(0, connection.HandshakeMessages.Count - length - 4).ToArray();
            var handshakeHash = sha256.ComputeHash(handshakeData);

            var prfClient = new PseudoRandomFunction(connection.MasterSecretBytes, "client finished", handshakeHash);
            byte[] clientVerifyData = prfClient.GenerateBytes(12);

            byte[] data = connection.Buffer.Read(12);
            for (uint i = 0; i < 12; i++) if (clientVerifyData[i] != data[i]) return;

            HandshakeResponse.ServerChangeCipherSpec(connection);
            connection.SendEncrypted = true;
            HandshakeResponse.ServerServerFinish(connection);
        }
    }
}
