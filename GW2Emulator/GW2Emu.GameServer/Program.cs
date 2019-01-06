using System;

namespace GW2Emu.GameServer
{
    public static class Program
    {
        private const string IPAddress = "127.0.0.1";
        private const int Port = 7112; // this port sets redirect packet

        public static void Main()
        {
            Console.Title = "GameServer";
            Console.WriteLine("Starting server on IP - " + IPAddress + ":" + Port + "...");

            GameServer gameServer = new GameServer();
            gameServer.Execute(IPAddress, Port);
        }
    }
}