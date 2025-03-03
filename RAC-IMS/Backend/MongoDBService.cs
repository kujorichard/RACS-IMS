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
        private readonly IMongoDatabase _database;
        private readonly MongoClient _client;

        public MongoDBService(string connection_uri, string database_name)
        {
            _client = new MongoClient(connection_uri);
            _database = _client.GetDatabase(database_name);
        }


        public IMongoCollection<Product> GetProductsCollection()
        {
            return _database.GetCollection<Product>("Products");
        }

        public IMongoCollection<Supplier> GetSupplierCollection()
        {
            return _database.GetCollection<Supplier>("Suppliers");
        }

        public IMongoCollection<Customer> GetCustomerCollection()
        {
            return _database.GetCollection<Customer>("Customer");
        }

        public IMongoCollection<Order> GetOrderCollection()
        {
            return _database.GetCollection<Order>("Order");
        }

        public IMongoCollection<RawMaterial> GetRawMaterialCollection()
        {
            return _database.GetCollection<RawMaterial>("RawMaterial");
        }

        public IMongoCollection<User> GetUserCollection()
        {
            return _database.GetCollection<User>("Users");
        }
    }
}
