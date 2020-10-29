using MongoDB.API.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.API.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity, new()
    {
        private readonly IMongoCollection<T> _mongoCollection;

        public BaseRepository(IFootballMarketDatabaseSettings settings, string collectionName)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _mongoCollection = database.GetCollection<T>(collectionName);
        }

        public virtual List<T> GetList()
        {
            return _mongoCollection.Find(book => true).ToList();
        }

        public virtual T GetById(string id)
        {
            return _mongoCollection.Find(m => m.Id == id).FirstOrDefault();
        }

        public virtual T Create(T document)
        {
            _mongoCollection.InsertOne(document);

            return document;
        }

        public virtual void Update(string id, T document)
        {
            _mongoCollection.ReplaceOne(m => m.Id == id, document);
        }

        public virtual void Delete(string id, T document)
        {
            _mongoCollection.DeleteOne(m => m.Id == id);
        }


    }
}
