#pragma once

#include "Macroses.h"

using RRL::GW2::Common::Network::APacketHandler;
using RRL::GW2::Common::Network::Connection;

START_NAMESPACE

	/// <summary>
    /// Author: Alehandr
    /// </summary>
	public ref class PacketHandler : APacketHandler<Connection^>
	{

	public:

		LOG(PacketHandler);

		virtual bool TryParsePacket(Connection^ connection) override;

		static void InitCipher(Connection^ connection, array<unsigned char>^ clientSeed);

	};

END_NAMESPACE