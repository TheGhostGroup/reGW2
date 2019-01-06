using System;
using System.Net;
using System.Collections.Generic;


namespace GW2Emu.Common
{
    public class Server<T> where T : Client, new()
    {
        private Listener<T> listener;
        private Dictionary<int, T> clientList;
        private NetIDManager idManager;
        private object state;

        public void Start(string address, int port, int min, int max)
        {
            Start2(IPAddress.Parse(address), port, min, max);
        }

        public void Start2(IPAddress address, int port, int min, int max)
        {
            clientList = new Dictionary<int, T>();
            idManager = new NetIDManager(min, max);
            listener = new Listener<T>(address, port);
            listener.ClientConnected += ClientConnected;
            listener.Start();
            Log.Success("Start", "Successfully started the server!");
        }

        public void SetState(object state)
        {
            this.state = state;
        }

        private void ClientConnected(T client)
        {
            int id = idManager.Acquire();

            if (id < 0)
            {
                Console.WriteLine("The amount of connections has exceeded.");
                client.Stop();
            }
            else
            {
                client.SetState(state);
                client.Start();
                clientList.Add(id, client);
                OnClientConnected(client);
            }
        }

        protected virtual void OnClientConnected(T client) { }

        public void Stop()
        {
            listener.Stop();
        }

        public bool Running
        {
            get
            {
                return listener.Running;
            }
        }
    }
}