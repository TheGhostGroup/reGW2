using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GW2Emu.Common.MongoDB
{
    public class Collection<T> : ICollection
    {
        private MongoCollection<T> collection;

        public Collection(MongoCollection<T> collection)
        {
            this.collection = collection;
        }

        public T FindById(UID id)
        {
            return collection.FindOneAs<T>(Query.EQ("_id", id.ToBsonDocument<UID>()));
        }

        public T[] FindAllById(UID id)
        {
            return new System.Collections.Generic.List<T>(collection.Find(Query.EQ("_id", id.ToBsonDocument<UID>()))).ToArray();
        }

        public T[] FindAll()
        {
            return new System.Collections.Generic.List<T>(collection.FindAllAs<T>()).ToArray();
        }

        public T[] FindAllByIdQuery(string name, UID id)
        {
            return new System.Collections.Generic.List<T>(collection.Find(Query.EQ(name, id.ToBsonDocument<UID>()))).ToArray();
        }

        public void Save(T input)
        {
            collection.Save<T>(input);
        }

        public void Clear()
        {
            collection.RemoveAll();
        }

        public string Name
        {
            get
            {
                return collection.Name;
            }
        }
    }
}
