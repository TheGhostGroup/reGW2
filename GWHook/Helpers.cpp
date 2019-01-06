#include "stdafx.h"
#include "Helpers.hpp"

void *DetourFunc(BYTE *src, const BYTE *dst, const int len)
{
	BYTE *jmp = (BYTE*)malloc(len+5);
	DWORD dwBack;

	VirtualProtect(jmp,len+5, PAGE_EXECUTE_READWRITE,&dwBack);
	VirtualProtect(src, len, PAGE_READWRITE, &dwBack);

	memcpy(jmp, src, len);	
	jmp += len;

	jmp[0] = 0xE9;
	*(DWORD*)(jmp+1) = (DWORD)(src+len - jmp) - 5;

	src[0] = 0xE9;
	*(DWORD*)(src+1) = (DWORD)(dst - src) - 5;

	for( int i=5; i < len; i++ )
		src[i] = 0x90;

	VirtualProtect(src, len, dwBack, &dwBack);

	return (jmp-len);
}