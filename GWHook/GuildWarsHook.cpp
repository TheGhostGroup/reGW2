#include "stdafx.h"
#include "detours.h"
#include "GuildWarsHook.hpp"

GuildWarsHook* GuildWarsHook::instance = nullptr;

GuildWarsHook::GuildWarsHook()
	:mLogFile("emu.log", std::ios::trunc),
	mState(kNone)
{
	Log("GuildWars Hook Attached.");
	ReadRealmlist();
}

GuildWarsHook::~GuildWarsHook()
{

}

GuildWarsHook* GuildWarsHook::GetInstance()
{
	if(instance == nullptr)
		instance = new GuildWarsHook;

	return instance;
}

void GuildWarsHook::Log(const std::string& pStr)
{
	mLogFile << pStr << std::endl;
}

void GuildWarsHook::SetMeta(const std::string& pKey, const std::string& pValue)
{
	mMeta[pKey] = pValue;
}

std::string GuildWarsHook::GetMeta(const std::string& pKey)
{
	return mMeta[pKey];
}

void GuildWarsHook::ReadRealmlist()
{
	std::ifstream realmlist("realmlist.wtf");
	if(realmlist.is_open())
	{
		std::string addr;
		std::getline(realmlist, addr);

		if(addr.empty())
			return;

		SetMeta("realm", addr);

		Log(std::string("Using realm : ") + addr);
	}
}

int GuildWarsHook::GetState()
{
	return mState;
}

void GuildWarsHook::SetState(int pState)
{
	mState = pState;
}

typedef BOOL (__thiscall *t_BeginConnect)(void *dwCompletionKey, DWORD cbBytesReturned, sockaddr_in *addr, DWORD *a4, DWORD a5, signed int vOutBuffer, int a7, void *hostshort);
t_BeginConnect r_BeginConnect;

BOOL __fastcall BeginConnect(void *dwCompletionKey, void* fc, DWORD cbBytesReturned, sockaddr_in *addr, DWORD *a4, DWORD a5, signed int vOutBuffer, int a7, void *hostshort)
{
	std::ostringstream os;

	char* remoteIP = inet_ntoa(addr->sin_addr);

	os << "BeginConnect to : " << remoteIP << ":" << ntohs(addr->sin_port);
	
	if(GuildWarsHook::GetInstance()->GetMeta("realm").size())
	{
		if(GuildWarsHook::GetInstance()->GetState() == GuildWarsHook::kPortalServer)
		{
			if(addr->sin_port == htons(6112))
			{
				os << " - Redirect to port : " << 6600;
				addr->sin_port = htons(6600);
			}
		}
		if(GuildWarsHook::GetInstance()->GetState() == GuildWarsHook::kLoginServer)
		{
			if(addr->sin_port == htons(6112))
			{
				os << " - Redirect to port : " << 6110;
				addr->sin_port = htons(6110);
			}
		}
	}

	GuildWarsHook::GetInstance()->Log(os.str());

	return r_BeginConnect(dwCompletionKey, cbBytesReturned, addr, a4, a5, vOutBuffer, a7, hostshort);
}


void GuildWarsHook::Commit()
{
	r_BeginConnect = (t_BeginConnect)DetourFunction((PBYTE)GetInstance()->mBeginConnect, (PBYTE)BeginConnect);
}

void GuildWarsHook::SetBeginConnect( void* pAddress )
{
	mBeginConnect = pAddress;
}
