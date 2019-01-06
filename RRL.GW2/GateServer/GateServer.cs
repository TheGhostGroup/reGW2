using System;
using System.Reflection;
using System.Threading;
using RRL.GW2.Common.Communications.GateServer;
using RRL.GW2.Common.Communications.GateServer.Interfaces;
using RRL.GW2.GateServer.Services;

namespace RRL.GW2.GateServer
{
    /// <summary>
    /// Author: Alehandr, Ara(ra)gi
    /// </summary>
    sealed class GateServer : GtSGlobal
    {
        public static Semaphore ShutdownSemaphore = new Semaphore(0, 1);

        static void Main()
        {
            Console.Title = "[Guild Wars 2] {Gate Server}";

            log4net.Config.XmlConfigurator.Configure();


            #region Load engines & services

            AuthEngine =
                (IGtSAuthEngine)
                Assembly.LoadFrom("Engines//GateServer.AuthEngine.dll").CreateInstance(
                    "GateServer.AuthEngine.AuthEngine");

            NetworkEngine =
                (IGtSNetworkEngine)
                Assembly.LoadFrom("Engines//GateServer.NetworkEngine.dll").CreateInstance(
                    "GateServer.NetworkEngine.NetworkEngine");

            //DatabaseService = new DatabaseService(Database.Default.MySql_User, Database.Default.MySql_Password,
            //                                      Database.Default.MySql_Host, Database.Default.MySql_Database,
            //                                      Database.Default.MySql_Port);

            #endregion

// ReSharper disable PossibleNullReferenceException
            NetworkEngine.StartTcpServer(6600);
// ReSharper restore PossibleNullReferenceException

            
            
            ShutdownSemaphore.WaitOne();
        }
    }
}