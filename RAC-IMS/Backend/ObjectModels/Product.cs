﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend.ObjectModels
{
    internal class Product
    {

        [BsonId] // Marks this as the MongoDB document ID
        [BsonRepresentation(BsonType.ObjectId)] // Ensures it works as a string
        public string _id { get; set; }
        public string category { get; set; }

        public string name { get; set; }
        public double reseller_price { get; set; }
        public double wholesale_price { get; set; }
        public double retail_price { get; set; }
        public string price_type { get; set; }
        public string supplier { get; set; }
        public int supplier_id { get; set; }
        public List<int> raw_material_id { get; set; }
    }
}
