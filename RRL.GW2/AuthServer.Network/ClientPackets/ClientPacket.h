#pragma once

/// <summary>
/// Author: Alehandr
/// </summary>

#include "../Macroses.h"
#include "../PacketHandler.h"

using log4net::ILog;

using ROOT_NAMESPACE::PacketHandler;

#undef LOG
#define LOG PacketHandler::log

using RRL::GW2::Common::Network::Connection;

#define CP(name) inline bool Cp##name##(Connection^ connection)

#define CHECK(size) if (READ_INDEX + size > WRITE_INDEX) return false;