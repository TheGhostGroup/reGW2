#include "stdafx.h"
#include "PE.hpp"
#include <windows.h>
#include <Dbghelp.h>

PE::ImageSectionInfo PE::FindSection(const std::string& pData)
{
	PE::ImageSectionInfo image;
	HMODULE module = GetModuleHandle(NULL); 

	IMAGE_NT_HEADERS *pNtHdr = ImageNtHeader(module);

	IMAGE_SECTION_HEADER *pSectionHdr = (IMAGE_SECTION_HEADER *) (pNtHdr + 1);

	ImageSectionInfo *pSectionInfo = NULL;

	for ( int i = 0 ; i < pNtHdr->FileHeader.NumberOfSections ; i++ )
	{
		std::string name = (char*) pSectionHdr->Name;
		if (name.find(pData) != std::string::npos)
		{
			image.start = pSectionHdr->VirtualAddress + pNtHdr->OptionalHeader.ImageBase;
			image.size = pSectionHdr->SizeOfRawData;
			break;
		}
		pSectionHdr++;
	}

	return image;
}