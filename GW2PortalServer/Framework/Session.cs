using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;

namespace Framework
{
    public delegate void MessageReceived();

    public class Session
    {
        private bool sending;
        private Socket socket;
        private byte[] buffer = new byte[1024];
        private MemoryStream stream = new MemoryStream();
        private List<MemoryStream> outgoingQueue = new List<MemoryStream>();

        public event MessageReceived OnMessageReceived;


        public MemoryStream Stream
        {
            get { return stream; }
        }

        public Session(Socket s)
        {
            socket = s;
        }

        ~Session()
        {
        }

        public void Start()
        {
            try
            {
                socket.BeginReceive(buffer, 0, 1024, 0, new AsyncCallback(ReadCallback), this);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Delete(int bytes)
        {
            if (bytes <= 0)
                return;

            byte[] data = stream.ToArray().Skip((int)bytes).ToArray();
            stream = new MemoryStream();
            stream.Write(data, 0, data.Length);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            try
            {
                Session session = (Session)ar.AsyncState;

                int read = session.socket.EndReceive(ar);

                if (read > 0)
                {
                    session.stream.Write(session.buffer, 0, read);

                    if (session.OnMessageReceived != null)
                        session.OnMessageReceived();

                    session.Start();
                }
                else
                {
                    session.socket.Shutdown(SocketShutdown.Both);
                    session.socket.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        public void Send(MemoryStream str)
        {
            try
            {

                lock (this)
                {
                    outgoingQueue.Add(str);
                    if (!sending)
                    {
                        DoSend();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Send(string str)
        {
            try
            {
                MemoryStream mstr = new MemoryStream(Encoding.ASCII.GetBytes(str));
                Send(mstr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void DoSend()
        {
            try
            {
                if (outgoingQueue.Count() != 0)
                {
                    MemoryStream str = outgoingQueue.First();

                    byte[] data = new byte[str.Length];
                    str.Read(data, 0, (int)str.Length);

                    outgoingQueue.RemoveAt(0);
                    sending = true;

                    try
                    {
                        socket.BeginSend(data, 0, data.Length, 0,
                            new AsyncCallback(SendCallback), this);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else
                    sending = false;
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                sending = false;
            }
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Session session = (Session)ar.AsyncState;


                lock (session)
                {
                    int bytesSent = session.socket.EndSend(ar);
                    session.DoSend();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
