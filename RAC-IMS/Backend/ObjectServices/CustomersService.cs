using MongoDB.Driver;
using RAC_IMS.Backend.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class CustomersService
    {
        private readonly IMongoCollection<Customer> _CustomerCollection;

        public CustomersService(MongoDBService mongoDBService)
        {
            _CustomerCollection = mongoDBService.GetCustomerCollection();
        }

        // CREATE: Insert a new Customer
        public async Task InsertCustomer(Customer Customer)
        {
            await _CustomerCollection.InsertOneAsync(Customer);
        }

        // READ: Get all Customers
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _CustomerCollection.Find(_ => true).ToListAsync();
        }

        // READ: Get a single Customer by ID
        public async Task<Customer> GetCustomerById(string id)
        {
            return await _CustomerCollection.Find(p => p._id == id).FirstOrDefaultAsync();
        }

        // UPDATE: Update an existing Customer
        public async Task UpdateCustomer(string id, Customer updatedCustomer)
        {
            await _CustomerCollection.ReplaceOneAsync(p => p._id == id, updatedCustomer);
        }

        // DELETE: Delete a Customer
        public async Task DeleteCustomer(string id)
        {
            await _CustomerCollection.DeleteOneAsync(p => p._id == id);
        }
    }
}
