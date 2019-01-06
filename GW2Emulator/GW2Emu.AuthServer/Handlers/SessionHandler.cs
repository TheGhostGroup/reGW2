using System;
using GW2Emu.Common;
using GW2Emu.Common.MongoDB;
using In = GW2Emu.AuthServer.In;
using Out = GW2Emu.AuthServer.Out;

namespace GW2Emu.AuthServer.Handlers
{
    public class SessionHandler
    {
        private Database database;

        public SessionHandler(AuthServerPacketManager packetManager, Database database)
        {
            this.database = database;
            packetManager.P03_ComputerInfo += HandleComputerInfo;
            packetManager.P10_ClientSessionInfo += HandleClientSessionInfo;
        }

        private void HandleComputerInfo(SecurePacketBasedClient client, In.P03_ComputerInfo packet)
        {
            client.SendPacket(new Out.P02_ComputerInfoReply());
            client.SendPacket(new Out.P01_Unknown());
        }

        private void HandleClientSessionInfo(SecurePacketBasedClient client, In.P10_ClientSessionInfo packet)
        {
            UID accountId = packet.AccountId;
            Collection<Account> accounts = database.GetCollection<Account>("Accounts");
            Account account = accounts.FindById(accountId);

            if (account == null)
            {
                Account item = Account.NewEmpty();
                item.Id = packet.AccountId;
                accounts.Save(item);
                account = item;
            }

            AuthServerDataContainer.Data.Account = account;
            CharacterHandler.SendCharacters(client, database);
            AccountHandler.SendAccountInfo(client);
            GameServerHandler.SendGameServerInfo(client);
        }
    }
}