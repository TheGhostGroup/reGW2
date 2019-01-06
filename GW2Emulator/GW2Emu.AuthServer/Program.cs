using System;

namespace GW2Emu.AuthServer
{
    public static class Program
    {
        private const string IPAddress = "127.0.0.1";
        private const int Port = 6110;

        public static void Main()
        {
            Console.Title = "AuthServer";
            Console.WriteLine("Starting server on IP - " + IPAddress + ":" + Port + "...");

            AuthServer authServer = new AuthServer();
            authServer.Execute(IPAddress, Port);
        }
    }
}
