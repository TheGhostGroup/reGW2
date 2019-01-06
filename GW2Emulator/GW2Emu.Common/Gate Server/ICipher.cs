namespace GW2Emu.Common
{
    public interface ICipher
    {
        void Process(ref byte[] data, int fromIndex, int toIndex);
    }
}
