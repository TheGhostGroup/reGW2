using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using System.Threading;

namespace Portal_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            PortalServer server = new PortalServer();

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
