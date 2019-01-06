using System.IO;
using System.Text;
using RRL.GW2.Common.Communications.GateServer.Messages;
using log4net;

namespace GateServer.NetworkEngine.Responses
{
    /// <summary>
    /// Author: Alehandr, Ara(ra)gi
    /// </summary>
    internal static class StsResponse
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof (StsResponse));

        public static void Ok(TlsConnection connection, string response)
        {
            Send(connection, "STS/1.0 200 OK", response);
        }

        public static void Success(TlsConnection connection, string response)
        {
            Send(connection, "STS/1.0 400 Success", response);
        }

        public static void SendStsMessage(TlsConnection connection, StsMessage stsMessage)
        {
            Send(connection, stsMessage.MessageHeader, stsMessage.ToString());
        }

        public static void SendStsMessage(TlsConnection connection, string header, string body)
        {
            Send(connection, header, body);
        }

        public static void Post(TlsConnection connection, string request, string body)
        {
            StringBuilder builder = new StringBuilder("P ", request.Length + body.Length + 24);
            builder.Append(request);
            builder.Append(" STS/1.0\r\nl:");
            builder.Append(body.Length);
            builder.Append("\r\n\r\n");
            builder.Append(body);

            byte[] data = Encoding.ASCII.GetBytes(builder.ToString());

            if (connection.SendEncrypted)
                TlsResponse.Message(connection, ref data);
        }

        private static void Send(TlsConnection connection, string header, string response)
        {
            StringBuilder builder = new StringBuilder(header, header.Length + response.Length + 24);
            builder.Append("\r\nl:");
            builder.Append(response.Length);
            builder.Append("\r\ns:");
            builder.Append(connection.StsSequence);
            builder.Append("R\r\n\r\n");
            builder.Append(response);

            byte[] data = Encoding.ASCII.GetBytes(builder.ToString());

            if (connection.SendEncrypted)
                TlsResponse.Message(connection, ref data);
            else
                connection.Send(data);
        }
    }
}
