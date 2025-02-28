using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend.ObjectModels
{
    internal class Supplier
    {
        [BsonId] // Marks this as the MongoDB document ID
        [BsonRepresentation(BsonType.ObjectId)] // Ensures it works as a string
        public string _id { get; set; }

        public string name { get; set; }
        public string contact_num { get; set; }
        public string contact_person { get; set; }
        public string address { get; set; }

    }
}
