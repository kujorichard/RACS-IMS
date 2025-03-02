using MongoDB.Driver;
using RAC_IMS.Backend.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAC_IMS.Backend.ObjectServices;
using RAC_IMS.Backend;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class RawMaterialsService
    {
        string connection_uri = "mongodb://localhost:27017";
        string database_name = "RACS_IMS";
        
        private readonly IMongoCollection<RawMaterial> _RawMaterialCollection;
        private readonly ProductsService productService;

        public RawMaterialsService(MongoDBService mongoDBService)
        {
            _RawMaterialCollection = mongoDBService.GetRawMaterialCollection();
             productService = new ProductsService(new MongoDBService(connection_uri, database_name));
        }

        // CREATE: Insert a new RawMaterial
        public async Task InsertRawMaterial(RawMaterial RawMaterial)
        {
            await _RawMaterialCollection.InsertOneAsync(RawMaterial);
        }

        // READ: Get all RawMaterials
        public async Task<List<RawMaterial>> GetAllRawMaterials()
        {
            return await _RawMaterialCollection.Find(_ => true).ToListAsync();
        }

        // READ: Get a single RawMaterial by ID
        public async Task<RawMaterial> GetRawMaterialById(string id)
        {
            return await _RawMaterialCollection.Find(p => p._id == id).FirstOrDefaultAsync();
        }

        // UPDATE: Update an existing RawMaterial
        public async Task UpdateRawMaterial(string id, RawMaterial updatedRawMaterial)
        {
            await _RawMaterialCollection.ReplaceOneAsync(p => p._id == id, updatedRawMaterial);
        }

        // DELETE: Delete a RawMaterial
        public async Task DeleteRawMaterial(string id)
        {
            await _RawMaterialCollection.DeleteOneAsync(p => p._id == id);
        }


        public async Task UpdateRawMaterialStock(string productId, int stockDifference)
        {
            var product = await productService.GetProductById(productId);
            if (product == null) return; // Skip if product not found

            foreach (var rawMaterialId in product.raw_material_id)
            {
                var rawMaterial = await GetRawMaterialById(rawMaterialId);
                if (rawMaterial == null) continue; // Skip if raw material not found

                rawMaterial.stock -= stockDifference; // Adjust stock

                if (rawMaterial.stock < 0)
                    rawMaterial.stock = 0; // Prevent negative stock

                await UpdateRawMaterial(rawMaterialId, rawMaterial);
            }
        }

    }
}
