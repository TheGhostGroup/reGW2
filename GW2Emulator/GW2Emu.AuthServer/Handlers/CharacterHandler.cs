using System;
using GW2Emu.Common;
using GW2Emu.Common.MongoDB;

namespace GW2Emu.AuthServer.Handlers
{
    public static class CharacterHandler
    {
        public static void SendCharacters(SecurePacketBasedClient client, Database database)
        {
            Collection<Character> collection = database.GetCollection<Character>("Characters");

            AuthServerDataContainer.Data.Characters = collection.FindAllByIdQuery("AccountId", AuthServerDataContainer.Data.Account.Id);

            foreach (Character character in AuthServerDataContainer.Data.Characters)
            {
                Serializer serializer = new Serializer();
                character.Data.Serialize(serializer);

                Out.P17_CharacterInfo characterInfo = new Out.P17_CharacterInfo();
                characterInfo.SyncCount = AuthServerDataContainer.Data.SyncCount;
                characterInfo.CharacterId = character.Id;
                characterInfo.CharacterName = character.Name;
                characterInfo.CharacterData = serializer.Data;
                client.SendPacket(characterInfo);
            }
        }
    }
}
