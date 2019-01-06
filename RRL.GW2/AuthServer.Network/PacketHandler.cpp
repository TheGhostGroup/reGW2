#include "PacketHandler.h"

#include "ClientPackets/CpVersion.h"
#include "ClientPackets/CpSeed.h"

#include "ServerPackets/SpSeed.h"

using ROOT_NAMESPACE::PacketHandler;
using RRL::GW2::Common::Crypto::DiffieHellman;
using RRL::GW2::Common::Crypto::Gw2Hash;
using RRL::GW2::Common::Crypto::Rc4Cipher;

using RRL::GW2::AuthServer::Network::ServerPackets::SpSeed;

#define PACKET(op_code, function) if (opCode == op_code) return function##(connection);

bool PacketHandler::TryParsePacket(Connection^ connection)
{
	if (connection->Buffer->Avaliable < 2)
		return false;

	READ_SHORT(opCode);

	// ########## CLIENT PACKETS ##########

	PACKET(0x0400, CpVersion);
	PACKET(0x4200, CpSeed);

	// ########## CLIENT PACKETS END ##########

	log->InfoFormat("Unknown packet: 0x{0:X2}{1:X2}", (unsigned char) (opCode >> 8), (unsigned char) opCode);

	connection->Buffer->ReadIndex = connection->Buffer->WriteIndex;

	return true;
}

void PacketHandler::InitCipher(Connection^ connection, array<unsigned char>^ clientSeed)
{
	array<unsigned char>^ key = DiffieHellman::GenerateSharedKey(clientSeed);
    array<unsigned int>^ tmpArray = Gw2Hash::GenerateRandomIntArray();
    array<unsigned char>^ seed = Gw2Hash::Xor(Gw2Hash::GetBytes(tmpArray), key);
    array<unsigned char>^ tmpSeed = Gw2Hash::GetBytes(Gw2Hash::Hash(tmpArray));

	connection->Decoder = gcnew Rc4Cipher(tmpSeed);

	connection->Send(SpSeed::Build(seed));

    connection->Encoder = gcnew Rc4Cipher(tmpSeed);
}