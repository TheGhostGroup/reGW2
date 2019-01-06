using System;
using System.Threading;
using RRL.GW2.AuthServer.Network;
using RRL.GW2.Common.Network;

namespace RRL.GW2.AuthServer
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    sealed class Program
    {
        public static Semaphore ShutdownSemaphore = new Semaphore(0, 1);

        static void Main()
        {
            Console.Title = "[Guild Wars 2] {Auth Server}";

            log4net.Config.XmlConfigurator.Configure();

            new TcpServer<Connection>(new PacketHandler(), 6110);

            ShutdownSemaphore.WaitOne();
        }
    }
}
