using System;
using System.Net;
using System.Net.Sockets;


namespace GW2Emu.Common
{
    public class Listener<T> where T : Client, new()
    {
        public const int Backlog = 100;
        public event Action<T> ClientConnected;

        private Socket socket;
        private EndPoint endPoint;
        private ThreadExecutor threadExecutor;

        public Listener(IPAddress address, int port)
        {
            try
            {
                endPoint = new IPEndPoint(address, port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(endPoint);
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.AddressAlreadyInUse)
                {
                    Console.Write("Address and/or port is already in use.");
                    Console.ReadKey(true);
                    Environment.Exit(1);
                }
            }

            threadExecutor = new ThreadExecutor();
            threadExecutor.Tick += ListenTick;
        }

        public void Start()
        {
            socket.Listen(Backlog);
            threadExecutor.Start();
        }

        private void ListenTick()
        {
            if (Pending)
            {
                T client = Client.CreateCustomClient<T>(socket.Accept());
                OnClientConnected(client);
            }
        }

        private void OnClientConnected(T client)
        {
            if (ClientConnected != null)
            {
                ClientConnected(client);
            }
        }

        public void Stop()
        {
            threadExecutor.Stop();
        }

        public void Dispose()
        {
            socket.Dispose();
        }

        public Socket Socket
        {
            get
            {
                return socket;
            }
        }

        public EndPoint EndPoint
        {
            get
            {
                return endPoint;
            }
        }

        public bool Pending
        {
            get
            {
                return socket.Poll(0, SelectMode.SelectRead);
            }
        }

        public bool Running
        {
            get
            {
                return threadExecutor.Running;
            }
        }
    }
}
