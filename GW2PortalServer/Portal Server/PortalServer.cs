using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Portal_Server
{
    public class PortalServer
    {
        private Server server;
        private List<Client> clients = new List<Client>();

        public PortalServer()
        {
            server = new Server(6112);
            server.OnSessionAccepted += OnAccept;
        }

        private void OnAccept(Session session)
        {
            Client client = new Client(session);
            clients.Add(client);
        }
    }
}
