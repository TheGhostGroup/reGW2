#pragma once

#include "ClientPacket.h"

/// <summary>
/// Author: Alehandr
/// </summary>
CP(Version)
{
	CHECK(14);

	READ_INDEX += 2; //Unk
	READ_INT(clientVersion);
	READ_INT(clientType);
	READ_INDEX += 4; //Unk

	LOG->InfoFormat("Recv CpVersion: ClientVersion: {0} ClientType: {1}", clientVersion, clientType);

	return true;
}