using MongoDB.Driver;
using RAC_IMS.Backend;
using RAC_IMS.Backend.ObjectModels;
using System.Collections.Generic;

namespace RAC_IMS.Backend
{
    internal class ProductOperations
    {
        private readonly MongoDBService _mongoService;
        private readonly IMongoCollection<Product> _productCollection;


        public ProductOperations()
        {
            _mongoService = new MongoDBService("mongodb://localhost:27017", "RACS_IMS");
            _productCollection = _mongoService.GetProductsCollection();
        }

        public void InsertProduct(Product product)
        {
            _productCollection.InsertOne(product);  // Insert product into MongoDB
        }

        public void InsertSampleProduct()
        {
            Product new_product = new Product
            {
                name = "Product 1",
                reseller_price = 100,
                wholesale_price = 200,
                retail_price = 300,
                category = "Category 1",
                supplier = "Supplier 1",
                supplier_id = 1,
                raw_material_id = new List<int> { 1, 2, 3 }
            };

            // Insert the product into MongoDB
            InsertProduct(new_product);
        }
    }
}
