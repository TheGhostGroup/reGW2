#pragma once


struct PE
{
	struct ImageSectionInfo
	{
		uint32_t start, size;
	};

	static ImageSectionInfo FindSection(const std::string& pData);
};
