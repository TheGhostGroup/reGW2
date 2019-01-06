#pragma once

typedef int (__thiscall * t_rc4)(int instance, int length, uint8_t* out, uint8_t* in);
typedef int (__thiscall * t_CBC)(int instance, int unk, unsigned int length, uint8_t* data);

struct BigNum
{
	DWORD unk;
	DWORD* number;
	DWORD unk1;
	DWORD unk2;
	DWORD size;
};

struct Encryption
{
	static void Commit();

	static t_rc4 p_rc4;
	static t_CBC p_cbc_encrypt;
	static t_CBC p_cbc_decrypt;
	static BYTE* KeyGenHookStart;
	static BYTE* KeyGenHookEnd;

};