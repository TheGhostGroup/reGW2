#pragma once

class GuildWarsHook
{
public:

	enum
	{
		kNone,
		kPortalServer,
		kLoginServer,
		kGameServer
	};

	GuildWarsHook();
	~GuildWarsHook();

	static GuildWarsHook* GetInstance();

	void Log(const std::string& pStr);
	void SetMeta(const std::string& pKey, const std::string& pValue);
	std::string GetMeta(const std::string& pKey);
	int GetState();
	void SetState(int pState);
	void SetBeginConnect( void* pAddress );

	static void Commit();

protected:

	void ReadRealmlist();
	
	
private:

	static GuildWarsHook* instance;

	std::ofstream mLogFile;
	std::map<std::string, std::string> mMeta;
	int mState;
	void* mBeginConnect;
};