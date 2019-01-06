using RRL.GW2.Common.Database;

namespace RRL.GW2.Common.Communications.GateServer.Interfaces
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public interface IGtSDatabaseService
    {
        MySqlConnector MySqlConnector { get; set; }

        int ExecuteQuery(string querry);
    }
}
