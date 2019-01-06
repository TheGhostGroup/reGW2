namespace GW2Emu.Common
{
    public interface IGtSAuthEngine
    {
        void ProcessStsConnection(Connection connection, string header, string body);

        Account ClientAuth(Connection connection, string login, string password);
    }
}
