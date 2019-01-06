using System;
using System.Net;
using System.Net.Sockets;



namespace GW2Emu.Common
{
    public class Client
    {
        public Socket Socket { get; private set; }
        public event Action<byte[]> Received;
        public Account Account;

        protected ThreadExecutor threadExecutor;
        protected object state;

        public static T CreateCustomClient<T>(Socket socket) where T : Client, new()
        {
            T client = new T();
            client.Socket = socket;
            client.threadExecutor = new ThreadExecutor();
            client.threadExecutor.Tick += client.ReceiveTick;
            return client;
        }

        public Client()
        {
        }

        public Client(IPAddress address, int port)
        {
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            threadExecutor = new ThreadExecutor();
            threadExecutor.Tick += ReceiveTick;
        }

        public Client(Socket socket)
        {
            Socket = socket;
            threadExecutor = new ThreadExecutor();
            threadExecutor.Tick += ReceiveTick;
        }

        public virtual void SetState(object state)
        {
            this.state = state;
        }

        public virtual void Start()
        {
            threadExecutor.Start();
        }

        public virtual void Stop()
        {
            threadExecutor.Stop();

            if (Connected)
            {
                Socket.Disconnect(false);
            }
        }

        protected virtual void ReceiveTick()
        {
            if (Connected)
            {
                if (Socket.Available > 0)
                {
                    byte[] buffer = new byte[Socket.Available];
                    Socket.Receive(buffer);
                    OnReceived(ProcessIncomingData(buffer));
                }
            }
            else
            {
                Stop();
                Dispose();
            }
        }

        public virtual byte[] Receive()
        {
            while (Connected)
            {
                if (Socket.Available > 0)
                {
                    byte[] buffer = new byte[Socket.Available];
                    Socket.Receive(buffer);
                    return ProcessIncomingData(buffer);
                }
            }

            return new byte[0];
        }

        protected virtual byte[] ProcessIncomingData(byte[] data)
        {
            return data;
        }

        protected virtual byte[] ProcessOutgoingData(byte[] data)
        {
            return data;
        }

        public void OnReceived(byte[] data)
        {
            if (Received != null) Received.Invoke(data);
        }

        public virtual void Send(byte[] data)
        {
            if (Connected)
            {
                Socket.Send(ProcessOutgoingData(data));
            }
        }

        public virtual void Dispose()
        {
            Socket.Close();
            Socket.Dispose();
        }

        public bool Connected
        {
            get
            {
                return Socket.Poll(1, SelectMode.SelectRead | SelectMode.SelectWrite);
            }
        }


    }
}
