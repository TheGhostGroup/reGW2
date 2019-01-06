using System;
using System.Security.Cryptography;
using System.Text;

namespace GW2Emu.Common
{
    public class PacketHandler : APacketHandler<TlsConnection>
    {
        private readonly string[] _messageSeparators = new[] {"\r\n\r\n"};
        private readonly byte[] _headerEnd = new[] {(byte) '\r', (byte) '\n', (byte) '\r', (byte) '\n'};
        private readonly string[] _headerSeparators = new[] {"\r\n"};

        public override bool TryParsePacket(TlsConnection connection)
        {
            switch (connection.State)
            {
                case TlsConnection.ReadState.ReadHeader:
                    return ReadHeader(connection);
                case TlsConnection.ReadState.ReadBody:
                    return ReadBody(connection);
                case TlsConnection.ReadState.ReadTls:
                    return ReadTls(connection);
            }
            return false;
        }

        private bool ReadHeader(TlsConnection connection)
        {
            int headerEndIndex = connection.Buffer.FindSequence(_headerEnd);
            if (headerEndIndex != -1)
            {
                string header = Encoding.ASCII.GetString(connection.Buffer.Read(headerEndIndex));
                connection.Buffer.ReadIndex += _headerEnd.Length;
                connection.State = TlsConnection.ReadState.ReadBody;

                ProcessStsHeader(connection, header);

                return true;
            }

            return false;
        }

        private bool ReadBody(TlsConnection connection)
        {
            if (connection.Buffer.Avaliable < connection.BodyLength)
                return false;

            string body = Encoding.ASCII.GetString(connection.Buffer.Read(connection.BodyLength));
            connection.State = TlsConnection.ReadState.ReadHeader;

            GtSGlobal.AuthEngine.ProcessStsConnection(connection, connection.Request, body);

            return true;
        }

        private void ProcessStsHeader(TlsConnection connection, string header)
        {
            string[] headerLines = header.Split(_headerSeparators, StringSplitOptions.RemoveEmptyEntries);

            int len = headerLines[0].IndexOf(' ', 2) - 2;

            if (len <= 0)
            {
                return;
            }

            connection.Request = headerLines[0].Substring(2, headerLines[0].IndexOf(' ', 2) - 2);

            for (int i = 1; i < headerLines.Length; i++)
            {
                if (headerLines[i].IndexOf(';') != -1)
                    headerLines[i] = headerLines[i].Substring(0, headerLines[i].IndexOf(';'));

                if (headerLines[i][0] == 'l')
                    connection.BodyLength = Int32.Parse(headerLines[i].Substring(2));
                if (headerLines[i][0] == 's')
                    connection.StsSequence = Int32.Parse(headerLines[i].Substring(2));
            }
        }

        private bool ReadTls(TlsConnection connection)
        {
            if (connection.Buffer.Avaliable < 5) //Header
                return false;

            byte contentType = connection.Buffer.Read();
            connection.Buffer.ReadIndex += 2; //Version
            int length = connection.Buffer.ReadShort();

            if (connection.Buffer.Avaliable < length)
                return false;

            int packetEnd = connection.Buffer.ReadIndex + length;

            if (connection.RecvEncrypted)
            {
                var aes = new AesManaged
                    {
                        BlockSize = 128,
                        Key = connection.ClientWriteKey,
                        IV = connection.Buffer.Read(16),
                        Padding = PaddingMode.PKCS7
                    };

                byte[] data = aes.CreateDecryptor().TransformFinalBlock(connection.Buffer.Read(length - 16), 0,
                                                                        length - 16);

                length = data.Length - 21; //21 - Padding + Hash
                Buffer.BlockCopy(data, 0, connection.Buffer.Data, connection.Buffer.WriteIndex, length);
                connection.Buffer.WriteIndex += length;
                packetEnd = connection.Buffer.ReadIndex + length;
            }

            switch (contentType)
            {
                case 20: // ChangeCipherSpec
                    connection.InitCipher();
                    connection.RecvEncrypted = true;
                    break;
                case 21: // Alert
                    break;
                case 22: // Handshake
                    {
                        byte[] data = new byte[length];
                        Buffer.BlockCopy(connection.Buffer.Data, connection.Buffer.ReadIndex, data, 0, length);
                        connection.HandshakeMessages.AddRange(data);

                        byte handshakeType = connection.Buffer.Read();
                        int handshakeLength = connection.Buffer.ReadShortInt();

                        switch (handshakeType)
                        {
                            case 1:
                                HandshakeRequest.ClientHello(connection, handshakeLength);
                                break;
                            case 16:
                                HandshakeRequest.ClientKeyExchange(connection, handshakeLength);
                                break;
                            case 20:
                                HandshakeRequest.ClientFinish(connection, handshakeLength);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 23: // Message
                    {
                        string[] message = Encoding.ASCII.GetString(connection.Buffer.Read(length))
                            .Split(_messageSeparators, StringSplitOptions.RemoveEmptyEntries);

                        ProcessStsHeader(connection, message[0]);
                        GtSGlobal.AuthEngine.ProcessStsConnection(connection, connection.Request, message.Length > 1 ? message[1] : "");
                    }
                    break;
                default:
                    break;
            }

            connection.Buffer.ReadIndex += packetEnd - connection.Buffer.ReadIndex;

            return true;
        }
    }
}