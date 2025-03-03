using MongoDB.Driver;
using RAC_IMS.Backend.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class OrdersService
    {
        private readonly IMongoCollection<Order> _OrderCollection;

        public OrdersService(MongoDBService mongoDBService)
        {
            _OrderCollection = mongoDBService.GetOrderCollection();
        }

        // CREATE: Insert a new Order
        public async Task InsertOrder(Order Order)
        {
            await _OrderCollection.InsertOneAsync(Order);
        }

        // READ: Get all Orders
        public async Task<List<Order>> GetAllOrders()
        {
            return await _OrderCollection.Find(_ => true).ToListAsync();
        }

        // READ: Get a single Order by ID
        public async Task<Order> GetOrderById(string id)
        {
            return await _OrderCollection.Find(p => p._id == id).FirstOrDefaultAsync();
        }

        // UPDATE: Update an existing Order
        public async Task UpdateOrder(string id, Order updatedOrder)
        {
            await _OrderCollection.ReplaceOneAsync(p => p._id == id, updatedOrder);
        }

        // DELETE: Delete a Order
        public async Task DeleteOrder(string id)
        {
            await _OrderCollection.DeleteOneAsync(p => p._id == id);
        }
    }
}
