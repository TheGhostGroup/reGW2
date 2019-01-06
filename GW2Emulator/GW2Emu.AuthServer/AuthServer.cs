using System;
using System.Net;
using GW2Emu.Common;
using GW2Emu.Common.MongoDB;
using GW2Emu.AuthServer.Handlers;

namespace GW2Emu.AuthServer
{
    public class AuthServer : Server<SecurePacketBasedClient>
    {
        private readonly AuthServerPacketManager packetManager = new AuthServerPacketManager();

        private ClientDisconnectHandler clientDisconnectHandler;
        private SessionHandler sessionHandler;
        private CharacterSelectionHandler characterSelectionHandler;

        public void Execute(string ipAddress, int port)
        {
            Database database = new Database("localhost", "gw2emu");

            clientDisconnectHandler = new ClientDisconnectHandler(packetManager);
            sessionHandler = new SessionHandler(packetManager, database);
            characterSelectionHandler = new CharacterSelectionHandler(packetManager);

            SetState(packetManager);
            Start2(IPAddress.Parse(ipAddress), port, 0, 100);
        }
    }
}