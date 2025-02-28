using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAC_IMS.Backend.ObjectModels;
using RAC_IMS.Backend;
using MongoDB.Driver;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class SuppliersService
    {
        private readonly IMongoCollection<Supplier> _supplierCollection;

        public SuppliersService(MongoDBService mongoDBService)
        {
            _supplierCollection = mongoDBService.GetSupplierCollection();
        }

        // CREATE: Insert a new Supplier
        public async Task InsertSupplier(Supplier Supplier)
        {
            await _supplierCollection.InsertOneAsync(Supplier);
        }

        // READ: Get all Suppliers
        public async Task<List<Supplier>> GetAllSuppliers()
        {
            return await _supplierCollection.Find(_ => true).ToListAsync();
        }

        // READ: Get a single Supplier by ID
        public async Task<Supplier> GetSupplierById(string id)
        {
            return await _supplierCollection.Find(p => p._id == id).FirstOrDefaultAsync();
        }

        // UPDATE: Update an existing Supplier
        public async Task UpdateSupplier(string id, Supplier updatedSupplier)
        {
            await _supplierCollection.ReplaceOneAsync(p => p._id == id, updatedSupplier);
        }

        // DELETE: Delete a Supplier
        public async Task DeleteSupplier(string id)
        {
            await _supplierCollection.DeleteOneAsync(p => p._id == id);
        }
    }
}
