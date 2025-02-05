using System;
using MongoDB.Driver;

namespace RAC_IMS.Backend_MongoDB
{
    public class MongoDBService
    {
        private readonly IMongoDatabase _database;

        public MongoDBService(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        // Function for obtaining the collection of products object
        public IMongoCollection<Product> GetProductsCollection()
        {
            return _database.GetCollection<Product>("Products");
        }
    }
}
