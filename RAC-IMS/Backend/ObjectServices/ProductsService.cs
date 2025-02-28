using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAC_IMS.Backend.ObjectModels;
using RAC_IMS.Backend;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class ProductsService
    {

        private readonly IMongoCollection<Product> _productCollection;

        public ProductsService(MongoDBService mongoDBService)
        {
            _productCollection = mongoDBService.GetProductsCollection();
        }

        // CREATE: Insert a new product
        public async Task InsertProduct(Product product)
        {
            await _productCollection.InsertOneAsync(product);
        }

        // READ: Get all products
        public async Task<List<Product>> GetAllProducts()
        {
            return await _productCollection.Find(_ => true).ToListAsync();
        }

        // READ: Get a single product by ID
        public async Task<Product> GetProductById(string id)
        {
            return await _productCollection.Find(p => p._id == id).FirstOrDefaultAsync();
        }

        // UPDATE: Update an existing product
        public async Task UpdateProduct(string id, Product updatedProduct)
        {
            await _productCollection.ReplaceOneAsync(p => p._id == id, updatedProduct);
        }

        // DELETE: Delete a product
        public async Task DeleteProduct(string id)
        {
            await _productCollection.DeleteOneAsync(p => p._id == id);
        }
    }
}
