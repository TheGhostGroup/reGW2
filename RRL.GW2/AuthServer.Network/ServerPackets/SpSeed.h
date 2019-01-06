#include "ServerPacket.h"

/// <summary>
/// Author: Alehandr
/// </summary>
SP(Seed, (array<unsigned char>^ seed), {
	BUILDER(seed->Length + 2);

	WRITE_SHORT(0x1601);
	WRITE_DATA(seed);
	
	BUILD;
}); 