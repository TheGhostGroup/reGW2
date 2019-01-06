#pragma once

#include "ClientPacket.h"

/// <summary>
/// Author: Alehandr
/// </summary>
CP(Seed)
{
	CHECK(64);

	READ_DATA(seed, 64);

	LOG->InfoFormat("Recv CpSeed");

	PacketHandler::InitCipher(connection, seed);

	return true;
}