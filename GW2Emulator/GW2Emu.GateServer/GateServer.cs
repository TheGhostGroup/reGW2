using System;
using System.Reflection;
using System.Threading;
using GW2Emu.Common;

namespace GW2Emu.GateServer
{
    sealed class GateServer 
    {
        public static Semaphore ShutdownSemaphore = new Semaphore(0, 1);

        static void Main()
        {
            Console.Title = "GateServer";

            NetworkEngine engine = new NetworkEngine();
            engine.StartTcpServer(6600);

            Console.WriteLine("Server started on port 6600");
            
            ShutdownSemaphore.WaitOne();
        }
    }
}