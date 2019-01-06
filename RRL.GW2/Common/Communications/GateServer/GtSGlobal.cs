using RRL.GW2.Common.Communications.GateServer.Interfaces;

namespace RRL.GW2.Common.Communications.GateServer
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public class GtSGlobal
    {
        public static IGtSAuthEngine AuthEngine;

        public static IGtSNetworkEngine NetworkEngine;

        public static IGtSDatabaseService DatabaseService;
    }
}
