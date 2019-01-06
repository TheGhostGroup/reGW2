using RRL.GW2.Common.Communications.GateServer.Interfaces;
using RRL.GW2.Common.Database;

namespace RRL.GW2.GateServer.Services
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public class DatabaseService : IGtSDatabaseService
    {
        public MySqlConnector MySqlConnector { get; set; }

        public DatabaseService(string user, string password, string host, string database, short port = 3306)
        {
            MySqlConnector = new MySqlConnector();
            MySqlConnector.Init(host, database,user,password, port);
        }

        public int ExecuteQuery(string querry)
        {
            return MySqlConnector.Execute(querry);
        }
    }
}
