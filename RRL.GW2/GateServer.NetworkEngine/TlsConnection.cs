using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using RRL.GW2.Common.Network;
using RRL.GW2.GateServer.Networking.Tools;

namespace GateServer.NetworkEngine
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public class TlsConnection : Connection
    {
        public static BigInteger SrpN = new BigInteger("EEAF0AB9ADB38DD69C33F80AFA8FC5E86072618775FF3C0B9EA2314C9C256576D674DF7496EA81D3383B4813D692C6E0E0D5D8E250B98BE48E495C1D6089DAD15DC7D7B46154D6B6CE8EF4AD69B15D4982559B297BCF1885C529F566660E57EC68EDBC3C05726CC02FD4CBF4976EAA9AFD5138FE8376435B9FC61D2FC0EB06E3", 16);

        public static byte[] SrpNBytes = SrpN.ToByteArrayUnsigned();
        public static BigInteger SrpG = new BigInteger("2");
        public static byte[] SrpGBytes = SrpG.ToByteArrayUnsigned();
        public static BigInteger SrpS = new BigInteger("BEB25379D1A8581E", 16);
        public static byte[] SrpSBytes = SrpS.ToByteArrayUnsigned();

        public static Srp6VerifierGenerator VerifierGenerator = new Srp6VerifierGenerator();

        static TlsConnection()
        {
            VerifierGenerator.Init(SrpN, SrpG, new Sha1Digest());
        }

        public enum ReadState
        {
            ReadHeader,
            ReadBody,
            ReadTls,
        }

        public ReadState State = ReadState.ReadHeader;

        public int StsSequence;
        public ulong TlsSequence;

        public int BodyLength;

        public string Request;

        public bool RecvEncrypted = false;
        public bool SendEncrypted = false;

        #region SRP

        public List<byte> HandshakeMessages = new List<byte>();

        public byte[] ClientRandom;
        public byte[] ServerRandom;

        public Srp6Server SrpServer;

        public byte[] SrpB;

        public BigInteger PreMasterSecret;
        public byte[] MasterSecretBytes;

        public byte[] ClientWriteMacKey;
        public byte[] ServerWriteMacKey;
        public byte[] ClientWriteKey;
        public byte[] ServerWriteKey;

        #endregion

        public void InitSrp(string login)
        {
            const string password = "1"; //TODO: Get account password

            BigInteger srpV = VerifierGenerator.GenerateVerifier(
                SrpSBytes,
                Encoding.ASCII.GetBytes(login),
                Encoding.ASCII.GetBytes(password));

            SrpServer = new Srp6Server();
            SrpServer.Init(SrpN, SrpG, srpV, new Sha1Digest(), new SecureRandom());
            SrpB = SrpServer.GenerateServerCredentials().ToByteArrayUnsigned();
        }

        public void InitCipher()
        {
            byte[] preMasterSecretBytes = PreMasterSecret.ToByteArrayUnsigned();

            var prf = new PseudoRandomFunction(preMasterSecretBytes, "master secret", ClientRandom.Concat(ServerRandom));

            MasterSecretBytes = prf.GenerateBytes(48);

            prf = new PseudoRandomFunction(MasterSecretBytes, "key expansion", ServerRandom.Concat(ClientRandom));
            byte[] keyBlock = prf.GenerateBytes(72);

            using (var memoryStream = new MemoryStream(keyBlock))
            {
                using (var reader = new BinaryReader(memoryStream))
                {
                    ClientWriteMacKey = reader.ReadBytes(20);
                    ServerWriteMacKey = reader.ReadBytes(20);
                    ClientWriteKey = reader.ReadBytes(16);
                    ServerWriteKey = reader.ReadBytes(16);
                }
            }
        }

        public void StartTls()
        {
            State = ReadState.ReadTls;
        }
    }
}