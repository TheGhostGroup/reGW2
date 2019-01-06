#pragma once

//
// Author: Alehandr
//

#define ROOT_NAMESPACE RRL::GW2::AuthServer::Network

#define START_NAMESPACE namespace RRL { namespace GW2 { namespace AuthServer { namespace Network {

#define END_NAMESPACE } } } }


#define LOG(name) static log4net::ILog^ log = log4net::LogManager::GetLogger(#name)


#define DATA connection->Buffer->Data

#define READ_INDEX (connection->Buffer->ReadIndex)

#define WRITE_INDEX (connection->Buffer->WriteIndex)

#define READ_INDEX_CHECK if (READ_INDEX > WRITE_INDEX) return false;

// Read

#define READ_BYTE(var) unsigned char var = DATA[READ_INDEX]; READ_INDEX++; READ_INDEX_CHECK

#define READ_DATA(var, size) array<unsigned char>^ var = gcnew array<unsigned char>(size); \
	System::Buffer::BlockCopy(DATA, READ_INDEX, var, 0, size); READ_INDEX += size; READ_INDEX_CHECK

#define READ_SHORT(var) unsigned short var = DATA[READ_INDEX] + (DATA[READ_INDEX+1] << 8); READ_INDEX+=2; READ_INDEX_CHECK

#define READ_INT(var) int var = DATA[READ_INDEX] + (DATA[READ_INDEX+1] << 8) + (DATA[READ_INDEX+2] << 16) + (DATA[READ_INDEX+3] << 24); READ_INDEX+=4; READ_INDEX_CHECK

#define READ_LONG(var) long var = DATA[READ_INDEX] + (DATA[READ_INDEX+1] << 8) + (DATA[READ_INDEX+2] << 16) + (DATA[READ_INDEX+3] << 24) \
	+ (DATA[READ_INDEX+5] << 32) + (DATA[READ_INDEX+6] << 40) + (DATA[READ_INDEX+7] << 48) + (DATA[READ_INDEX+8] << 56); READ_INDEX+=8; READ_INDEX_CHECK

#define READ_VAR_INT(var) long var = 0; \
	bool more = true; \
	unsigned short shift = 0; \
	while (more) \
	{ \
	unsigned short now = DATA[READ_INDEX++]; \
		\
		more = (now & 128) != 0; \
		var |= (now & 127) << shift; \
		shift += 7; \
		\
		READ_INDEX_CHECK; \
    }