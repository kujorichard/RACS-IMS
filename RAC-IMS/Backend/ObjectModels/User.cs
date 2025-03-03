using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend.ObjectModels
{
    internal class User
    {
        [BsonId] // Marks this as the MongoDB document ID
        [BsonRepresentation(BsonType.ObjectId)] // Ensures it works as a string

        public string _id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
