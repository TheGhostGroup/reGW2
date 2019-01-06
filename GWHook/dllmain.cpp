#include <winsock2.h>
#include <windows.h>
#include <malloc.h>
#include <string>
#include <sstream>
#include <iomanip>

#include "stdafx.h"
#include "keys.h"
#include "detours.h"
#include "Version.hpp"
#include "Encryption.hpp"
#include "Winsock.hpp"
#include "GuildWarsHook.hpp"
#include "PE.hpp"

#pragma comment(lib, "detours.lib")
#pragma comment(lib, "ws2_32.lib")
#pragma comment(lib, "Dbghelp.lib")

unsigned int beginConnectOffset = 0;

void FindFunctionOffsets()
{
	PE::ImageSectionInfo info = PE::FindSection(".text");
	std::ostringstream os;
	os << "[.text segment] Start : " << std::hex << info.start << " | Size : " << info.size;
	GuildWarsHook::GetInstance()->Log(os.str());

	BYTE* start = (BYTE*)info.start;
	BYTE* end = start + info.size;

	static const BYTE KeyGenCode[] = {0x55, 0x8B, 0xEC, 0x83, 0xEC, 0x78, 0x56, 0x8B, 0xF2, 0x81, 0xF9, 0x88, 0x00, 0x00, 0x00};
	static const BYTE RC4Code[] = {0x55, 0x8B, 0xEC, 0x83, 0x7D, 0x08, 0x00, 0x8B, 0x01, 0x56, 0x8B, 0x71, 0x04, 0x76, 0x5F};
	static const BYTE CBCEncryptCode[] = {0x55, 0x8B, 0xEC, 0x83, 0xEC, 0x1C, 0x53, 0x56, 0x8B, 0xF1, 0x83, 0x7E, 0x14, 0x00, 0x57, 0x75
		, 0x14, 0x68, 0x88, 0x00, 0x00, 0x00, 0xBA, 0xAC, 0xA0, 0x56, 0x01, 0xB9, 0x94, 0xA0, 0x56, 0x01, 0xE8, 0xDB, 0xA1, 0x4B, 0xFF};
	static const BYTE CBCDecryptCode[] = {0x55, 0x8B, 0xEC, 0x83, 0xEC, 0x1C, 0x53, 0x56, 0x8B, 0xF1, 0x83, 0x7E, 0x14, 0x00, 0x57, 0x75
		, 0x11, 0x6A, 0x60, 0xBA, 0xAC, 0xA0, 0x56, 0x01, 0xB9, 0x94, 0xA0, 0x56, 0x01, 0xE8, 0x5E, 0xA3, 0x4B, 0xFF};
	static BYTE BeginConnectCode[] = {0x68,0,0,0,0};

	*(unsigned*)(BeginConnectCode + 1) = beginConnectOffset;

	while(start != end)
	{
		if(!memcmp(start,KeyGenCode,sizeof(KeyGenCode)))
		{
			Encryption::KeyGenHookStart = start + 0x77;
			std::ostringstream os;
			os << "KeyGen addr : " << std::hex << (unsigned)Encryption::KeyGenHookStart;
			GuildWarsHook::GetInstance()->Log(os.str()); 
		}
		else if(!memcmp(start,RC4Code,sizeof(RC4Code)))
		{
			Encryption::p_rc4 = (t_rc4)start;
		}
		else if(!memcmp(start,CBCEncryptCode,sizeof(CBCEncryptCode)))
		{
			Encryption::p_cbc_encrypt = (t_CBC)start;
		}
		else if(!memcmp(start,CBCDecryptCode,sizeof(CBCDecryptCode)))
		{
			Encryption::p_cbc_decrypt = (t_CBC)start;
		}
		else if(!memcmp(start,BeginConnectCode,sizeof(BeginConnectCode)))
		{
			std::ostringstream os;
			os << "Found BeginConnect string offset : " << std::hex << (unsigned)start - 0x245;
			GuildWarsHook::GetInstance()->SetBeginConnect(start - 0x245);
			GuildWarsHook::GetInstance()->Log(os.str()); 
		}
		++start;
	}
}

void FindRDataOffsets()
{
	PE::ImageSectionInfo info = PE::FindSection(".rdata");
	std::ostringstream os;
	os << "[.rdata segment] Start : " << std::hex << info.start << " | Size : " << info.size;
	GuildWarsHook::GetInstance()->Log(os.str());

	BYTE* start = (BYTE*)info.start;
	BYTE* end = start + info.size;

	static const BYTE BeginConnect_data[] = {'B', 'e', 'g', 'i', 'n', 'C', 'o', 'n','n','e','c','t',':'};

	while(start != end)
	{
		if(!memcmp(start,BeginConnect_data,sizeof(BeginConnect_data)))
		{
			std::ostringstream os;
			os << "Found BeginConnect string : " << std::hex << (unsigned)start;
			beginConnectOffset = (unsigned int)start;
			GuildWarsHook::GetInstance()->Log(os.str()); 
		}
		++start;
	}
}



BOOL APIENTRY DllMain(HMODULE hModule,DWORD  ul_reason_for_call,LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
        DisableThreadLibraryCalls(hModule);

		GuildWarsHook::GetInstance(); // Force instanciation

		FindRDataOffsets();
		FindFunctionOffsets();
		
		GuildWarsHook::Commit();
		Version::Commit();
		Encryption::Commit();
		Winsock::Commit();
		
        break;
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}