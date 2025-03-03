using MongoDB.Driver;
using RAC_IMS.Backend.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend.ObjectServices
{
    internal class UserService
    {
        private readonly IMongoCollection<User> _UserCollection; 

        public UserService(MongoDBService mongoDBService)
        {
            _UserCollection = mongoDBService.GetUserCollection();
        }

        public async Task InsertUser(User User)
        {
            await _UserCollection.InsertOneAsync(User);
        }

        public async Task<bool> UsernameExists(string username)
        {
            var filter = Builders<User>.Filter.Eq(u => u.username, username);
            var user = await _UserCollection.Find(filter).FirstOrDefaultAsync();
            return user != null;
        }

        public async Task<User> LoginUser(string username, string password)
        {
            var filter = Builders<User>.Filter.And(
                Builders<User>.Filter.Eq(u => u.username, username),
                Builders<User>.Filter.Eq(u => u.password, password)
            );

            var user = await _UserCollection.Find(filter).FirstOrDefaultAsync();
            return user; 
        }
    }
}
