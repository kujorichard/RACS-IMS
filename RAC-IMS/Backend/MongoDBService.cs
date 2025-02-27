using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using RAC_IMS.Backend.ObjectModels;

namespace RAC_IMS.Backend
{
    internal class MongoDBService
    {
        const string connectionUri = "mongodb://localhost:27017";
        private readonly IMongoDatabase _database;
        private readonly MongoClient _client;

        public MongoDBService(string connectionUri, string databaseName)
        {
            _client = new MongoClient(connectionUri);
            _database = _client.GetDatabase(databaseName);
        }

        // ✅ Test connection method
        public async Task<bool> TestConnectionAsync()
        {
            try
            {
                Console.WriteLine("🔄 Testing MongoDB Connection...");

                var databases = await _client.ListDatabaseNamesAsync();

                Console.WriteLine("✅ Connection Successful!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ MongoDB Connection Error: " + ex.Message);
                return false;
            }
        }



        public IMongoCollection<Product> GetProductsCollection()
        {
            return _database.GetCollection<Product>("Products");
        }

    }
}
