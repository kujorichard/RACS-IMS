using MongoDB.Driver;
using RAC_IMS.Backend.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class RawMaterialsService
    {
        private readonly IMongoCollection<RawMaterial> _RawMaterialCollection;

        public RawMaterialsService(MongoDBService mongoDBService)
        {
            _RawMaterialCollection = mongoDBService.GetRawMaterialCollection();
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
    }
}
