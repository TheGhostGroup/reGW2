#include "../Macroses.h"

/// <summary>
/// Author: Alehandr
/// </summary>

#undef LOG
#define LOG PacketHandler::log

#define SP(name, signature, code) START_NAMESPACE namespace ServerPackets { \
	\
	public ref class Sp##name \
	{ \
	public: \
		static array<unsigned char>^ Build signature \
		code \
	}; \
	\
} END_NAMESPACE

#define BUILDER(size) array<unsigned char>^ builder = gcnew array<unsigned char>(size); unsigned builder_pointer = 0;

#define BUILD System::Array::Resize(builder, builder_pointer); return builder;

#define WRITE(val) builder[builder_pointer++] = val;

#define WRITE_DATA(val) System::Buffer::BlockCopy(val, 0, builder, builder_pointer, val->Length); builder_pointer += val->Length;

#define WRITE_SHORT(val) builder[builder_pointer++] = val; \
	builder[builder_pointer++] = val >> 8;

#define WRITE_INT(val) builder[builder_pointer++] = val; \
	builder[builder_pointer++] = val >> 8; \
	builder[builder_pointer++] = val >> 16; \
	builder[builder_pointer++] = val >> 24;

#define WRITE_LONG(val) builder[builder_pointer++] = val; \
	builder[builder_pointer++] = val >> 8; \
	builder[builder_pointer++] = val >> 16; \
	builder[builder_pointer++] = val >> 24; \
	builder[builder_pointer++] = val >> 32; \
	builder[builder_pointer++] = val >> 40; \
	builder[builder_pointer++] = val >> 48; \
	builder[builder_pointer++] = val >> 56;