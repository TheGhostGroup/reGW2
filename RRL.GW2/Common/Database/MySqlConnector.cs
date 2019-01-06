using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using log4net;

namespace RRL.GW2.Common.Database
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    public class MySqlConnector : IDisposable
    {
        protected static readonly ILog Log = LogManager.GetLogger(typeof (MySqlConnector));

        protected static readonly string ConnectionStr = "server={0};database={1};user={2};password={3};port={4};";

        protected MySqlConnection Connection;

        protected object Lock = new object();

        private enum SchemaTableRows
        {
            // ReSharper disable UnusedMember.Local
            ColumnName = 0,
            ColumnOrdinal = 1,
            ColumnSize = 2,
            NumericPrecision = 3,
            NumericScale = 4,
            IsUnique = 5,
            IsKey = 6,
            BaseCatalogName = 7,
            BaseColumnName = 8,
            BaseSchemaName = 9,
            BaseTableName = 10,
            DataType = 11,
            AllowDbNull = 12,
            ProviderType = 13,
            IsAliased = 14,
            IsExpression = 15,
            IsIdentity = 16,
            IsAutoIncrement = 17,
            IsRowVersion = 18,
            IsHidden = 19,
            IsLong = 20,
            IsReadOnly = 21,
            // ReSharper restore UnusedMember.Local
        }

        public void Init(string server, string database, string user, string password, int port = 3306)
        {
            Connection = new MySqlConnection(string.Format(ConnectionStr, server, database, user, password, port));
            try
            {
                Log.Info("Connecting to MySQL...");
                Connection.Open();
                Log.Info("Done.");
            }
            catch (Exception ex)
            {
                Log.Fatal("Can't connect to DB.", ex);
            }
        }

        public void Dispose()
        {
            lock (Lock)
            {
                Log.Info("Close connection...");
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
        }

        public Object Single(string sql)
        {
            Object result = null;

            lock (Lock)
            {
                try
                {
                    result = new MySqlCommand(sql, Connection).ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    Log.Warn("MySQL", ex);
                }
            }

            return result;
        }

        public Dictionary<string, object> Select(string sql)
        {
            Dictionary<string, object> values = null;

            lock (Lock)
            {
                try
                {
                    MySqlDataReader dataReader = new MySqlCommand(sql, Connection).ExecuteReader();
                    if (dataReader.Read())
                        values = GetValues(dataReader);
                    if (dataReader.Read())
                        Log.InfoFormat("MySql select \"{0}\" not single!", sql);
                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    Log.Warn("MySQL", ex);
                }
            }

            return values;
        }

        public List<Dictionary<string, object>> SelectAll(string sql)
        {
            var allValues = new List<Dictionary<string, object>>();

            lock (Lock)
            {
                try
                {
                    MySqlDataReader dataReader = new MySqlCommand(sql, Connection).ExecuteReader();
                    DataTable schemaTable = null;
                    while (dataReader.Read())
                        allValues.Add(GetValues(dataReader, schemaTable));
                    dataReader.Close();
                }
                catch (MySqlException ex)
                {
                    Log.Warn("MySQL", ex);
                }
            }

            return allValues;
        }

        public int Execute(string sql)
        {
            int result = 0;

            lock (Lock)
            {
                try
                {
                    result = new MySqlCommand(sql, Connection).ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Log.Warn("MySQL", ex);
                }
            }

            return result;
        }

        //

        private static Dictionary<string, object> GetValues(MySqlDataReader dataReader, DataTable schemaTable = null)
        {
            var values = new Dictionary<string, object>();

            if (schemaTable == null)
                schemaTable = dataReader.GetSchemaTable();

            // ReSharper disable PossibleNullReferenceException
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            // ReSharper restore PossibleNullReferenceException
            {
                DataRow row = schemaTable.Rows[i];

                if ((Type)row[(int)SchemaTableRows.DataType] == typeof(Boolean))
                    values.Add((string)row[(int)SchemaTableRows.ColumnName],
                               dataReader.GetByte(i));
                else
                    values.Add((string)row[(int)SchemaTableRows.ColumnName],
                        // ReSharper disable AssignNullToNotNullAttribute
                               (bool)row[(int)SchemaTableRows.AllowDbNull] && dataReader.IsDBNull(i)
                                   ? null
                                   : Convert.ChangeType(dataReader.GetValue(i),
                                                        (Type)row[(int)SchemaTableRows.DataType]));
                // ReSharper restore AssignNullToNotNullAttribute
            }

            return values;
        }
    }
}
