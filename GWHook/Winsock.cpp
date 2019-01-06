#include "stdafx.h"
#include "detours.h"
#include "Winsock.hpp"
#include "GuildWarsHook.hpp"

typedef hostent* (WINAPI __stdcall * t_gethostbyname)(const char* name);
typedef int (*t_connect)(SOCKET s,const struct sockaddr *name,int namelen);
typedef uint16_t (*t_htons)(uint16_t);
typedef int (*t_WSAConnect)(SOCKET s,const struct sockaddr *name,int namelen,LPWSABUF lpCallerData,LPWSABUF lpCalleeData,LPQOS lpSQOS,LPQOS lpGQOS);

t_gethostbyname r_gethostbyname;
t_connect r_connect;
t_htons r_htons;
t_WSAConnect r_WSAConnect;

int WINAPI h_connect(SOCKET s,const struct sockaddr *name,int namelen)
{
	GuildWarsHook::GetInstance()->Log("Connect");
	return r_connect(s, name, namelen);
}

hostent* WINAPI h_gethostbyname(const char* name) 
{
	std::string ip = name;
	std::ostringstream os;
	os << "gethostbyname : " << name;
	GuildWarsHook::GetInstance()->Log(os.str()); 

	r_connect = (t_connect)DetourFunction((PBYTE)connect, (PBYTE)h_connect);
	
	if (ip.find("clienterror.101.ncplatform.net") != std::string::npos)
	{
		return r_gethostbyname("127.0.0.1");
	}
	else if(ip.find("cligate.101") != std::string::npos)
	{
		GuildWarsHook::GetInstance()->SetState(GuildWarsHook::kPortalServer);
		GuildWarsHook::GetInstance()->Log("Portal Server");

		if(!GuildWarsHook::GetInstance()->GetMeta("realm").empty())
			return r_gethostbyname(GuildWarsHook::GetInstance()->GetMeta("realm").c_str());
	}
	/*else if(ip.find("cligate-fr.101") != std::string::npos)
	{
		GuildWarsHook::GetInstance()->SetState(GuildWarsHook::kLoginServer);
		GuildWarsHook::GetInstance()->Log("Login Server");

		if(!GuildWarsHook::GetInstance()->GetMeta("realm").empty())
			return r_gethostbyname(GuildWarsHook::GetInstance()->GetMeta("realm").c_str());
	}*/
	else if (ip.find("Auth") == 0)
	{
		GuildWarsHook::GetInstance()->SetState(GuildWarsHook::kLoginServer);
		GuildWarsHook::GetInstance()->Log("Login Server");

		if(!GuildWarsHook::GetInstance()->GetMeta("realm").empty())
			return r_gethostbyname(GuildWarsHook::GetInstance()->GetMeta("realm").c_str());
	}

	return r_gethostbyname(name);
}



unsigned short WINAPI h_htons(unsigned short in)
{
	/*std::ostringstream os;
	os << "Port : " << in;
	GuildWarsHook::GetInstance()->Log(os.str());*/
	return r_htons(in);
}

int h_WSAConnect(SOCKET s,const struct sockaddr *name,int namelen,LPWSABUF lpCallerData,LPWSABUF lpCalleeData,LPQOS lpSQOS,LPQOS lpGQOS)
{
	GuildWarsHook::GetInstance()->Log("WSA");
	return r_WSAConnect(s, name, namelen, lpCallerData, lpCalleeData, lpSQOS, lpGQOS);
}


void Winsock::Commit()
{
	HMODULE mod = LoadLibraryA("ws2_32.dll");
	r_gethostbyname = (t_gethostbyname)DetourFunction((PBYTE)GetProcAddress(mod, "gethostbyname"), (PBYTE)h_gethostbyname);
	
	r_WSAConnect = (t_WSAConnect)DetourFunction((PBYTE)WSAConnect, (PBYTE)h_WSAConnect);
}