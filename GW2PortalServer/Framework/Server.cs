using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Framework
{
    public delegate void SessionAccepted(Session session);

    public class Server
    {
        public event SessionAccepted OnSessionAccepted;

        private struct State
        {
            public State(Server pThis, Socket pListener)
            {
                _this = pThis;
                _listener = pListener;
            }

            public Server _this;
            public Socket _listener;
        }

        public Server(short port)
        {
            IPAddress ipAddress = new IPAddress(0);
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);

            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                listener.BeginAccept(new AsyncCallback(AcceptCallback), new State(this, listener));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            State state = (State)ar.AsyncState;
            Socket handler = state._listener.EndAccept(ar);

            Session sess = new Session(handler);
            
            if (state._this.OnSessionAccepted != null)
            {
                state._this.OnSessionAccepted(sess);
            }

            sess.Start();

            state._listener.BeginAccept(new AsyncCallback(AcceptCallback), state);
        }
    }
}
