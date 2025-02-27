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


        // Product operations
        public IMongoCollection<Product> GetProductsCollection()
        {
            return _database.GetCollection<Product>("Products");
        }

        public void InsertProduct(Product product)
        {
            var productCollection = GetProductsCollection();
            productCollection.InsertOne(product);  // Insert product into MongoDB
        }


        public List<Product> GetAllProducts()
        {
            var productCollection = GetProductsCollection();
            return productCollection.Find(_ => true).ToList(); // Fetch all documents
        }

    }
}
