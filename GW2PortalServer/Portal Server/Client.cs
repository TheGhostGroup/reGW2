using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Portal_Server
{
    class Client
    {
        private Session session;
        private StringBuilder str = new StringBuilder();

        public Client(Session session)
        {
            this.session = session;
            session.OnMessageReceived += OnMessageReceived;
            Console.WriteLine("Client");
        }

        private void OnMessageReceived()
        {
            
            byte[] arr = new byte[session.Stream.Length];

            session.Stream.Seek(0, System.IO.SeekOrigin.Begin);
            session.Stream.Read(arr, 0, (int)session.Stream.Length);
            
            str.Append(Encoding.ASCII.GetString(arr));

            int offset;
            var transaction = StsTransaction.Build(str.ToString(), out offset);
            if (transaction != null)
            {
                str.Clear();
                
                Console.WriteLine(transaction.Method);
                if (transaction.Method == "/Auth/GetHostname")
                {
                    SendHostName(transaction);
                }

                session.Delete(offset);
            }
            else
                session.Delete((int)session.Stream.Length);
        }

        private void SendHostName(StsTransaction transaction)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<Reply>\n");
            builder.Append("<Local/>\n");
            builder.Append("<Hostname>127.0.0.1</Hostname>\n");
            builder.Append("</Reply>");

            StsTransaction trans = new StsTransaction(null, "STS/1.0 200 OK", builder.ToString(), new Dictionary<string, string>());
            trans.Headers["s"] = transaction.Headers["s"] + "R";
            session.Send(trans.ToString());
        }
    }
}
