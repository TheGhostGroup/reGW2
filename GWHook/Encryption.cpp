#include "stdafx.h"
#include "keys.h"
#include "Encryption.hpp"
#include "Helpers.hpp"
#include "GuildWarsHook.hpp"


int __fastcall hook_rc4(int instance, void *fastcall, int length, uint8_t* out, uint8_t* in);
int __fastcall hook_cbc_encrypt(int instance, void *fastcall, int unk, unsigned int length, uint8_t* data);
int __fastcall hook_cbc_decrypt(int instance, void *fastcall, int unk, unsigned int length, uint8_t* data);

t_rc4 Encryption::p_rc4;
t_CBC Encryption::p_cbc_encrypt;
t_CBC Encryption::p_cbc_decrypt;
BYTE* Encryption::KeyGenHookStart;
BYTE* Encryption::KeyGenHookEnd;

int __fastcall hook_rc4(int instance, void *fastcall, int length, uint8_t* out, uint8_t* in) 
{
	int result = Encryption::p_rc4(instance, length, out, in);

	std::string hex = "0123456789ABCDEF";
	{
		std::ostringstream stream;
		for (int i = 0 ; i < length ; i++)
			stream << hex[(*in>>4)&0xF] << hex[(*in++)&0xF];
	}
	{
		std::ostringstream stream;
		for (int i = 0 ; i < length ; i++)
			stream << hex[(*out>>4)&0xF] << hex[(*out++)&0xF];
	}

	return result;
}

int __fastcall hook_cbc_encrypt(int instance, void *fastcall, int unk, unsigned int length, uint8_t* data)
{
	{
		std::ostringstream stream;
		for (unsigned int i = 0 ; i < length ; i++)
			stream << data[i];
	}

	return Encryption::p_cbc_encrypt(instance, unk, length, data);
}

int __fastcall hook_cbc_decrypt(int instance, void *fastcall, int unk, unsigned int length, uint8_t* data)
{
	int result = Encryption::p_cbc_decrypt(instance, unk, length, data);

	uint8_t* out = (uint8_t *)*(DWORD32 *)(unk + 4);

	{
		std::ostringstream stream;
		for (unsigned int i = 0 ; i < length ; i++)
			stream << out[i];
	}

	return result;
}

void __stdcall ExchangeKeys(BigNum* public_key,BigNum* prime)
{
	memcpy(public_key->number,s_ServerPublicKey,sizeof(s_ServerPublicKey));
	memcpy(prime->number,s_Prime,sizeof(s_Prime));
}

void __declspec(naked) KeyGenHook()
{
	__asm
	{
			PUSHAD
			LEA EDX,[EBP-0x78]
			PUSH EAX //prime
			PUSH EDX //server public key
			CALL ExchangeKeys
			POPAD
			JMP Encryption::KeyGenHookEnd
	}
}

void Encryption::Commit()
{
	if(!GuildWarsHook::GetInstance()->GetMeta("realm").empty())
		KeyGenHookEnd = (BYTE*)DetourFunc(KeyGenHookStart,(BYTE*)KeyGenHook,6);
}