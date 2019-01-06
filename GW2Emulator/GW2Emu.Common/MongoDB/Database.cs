using System;
using MongoDB.Driver;

namespace GW2Emu.Common.MongoDB
{
    public class Database
    {
        private MongoDatabase database;

        public Database(string host, string databaseName)
        {
            MongoServer server = new MongoServer(new MongoServerSettings() { Server = new MongoServerAddress(host) });
            database = server.GetDatabase(databaseName);
        }

        public Collection<T> GetCollection<T>(string name)
        {
            if (!CollectionExists(name))
            {
                if (!CreateCollection(name))
                {
                    throw new ArgumentException("Invalid parameter.", "name");
                }
            }

            return GetExistingCollection<T>(name);
        }

        public bool CreateCollection(string name)
        {
            return database.CreateCollection(name).Ok;
        }

        public Collection<T> GetExistingCollection<T>(string name)
        {
            return new Collection<T>(database.GetCollection<T>(name));
        }

        public bool CollectionExists(string name)
        {
            return database.CollectionExists(name);
        }

        public void DeleteCollection(string name)
        {
            database.DropCollection(name);
        }

        public void DeleteCollection(ICollection collection)
        {
            database.DropCollection(collection.Name);
        }
    }
}
