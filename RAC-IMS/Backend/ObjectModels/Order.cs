using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAC_IMS.Backend.ObjectServices;
using MongoDB.Driver;
using RAC_IMS.Backend;

namespace RAC_IMS.Backend.ObjectModels
{
    internal class Order
    {
        [BsonId] // Marks this as the MongoDB document ID
        [BsonRepresentation(BsonType.ObjectId)] // Ensures it works as a string
        public string _id { get; set; }

        public int customer_id { get; set; }
        public List<ProductOrder> products_ordered { get; set; }
        public string status { get; set; }
        public double total_price { get; set; }


        public class ProductOrder
        {
            public string product_id { get; set; }
            public int quantity { get; set; }
            public string price_type { get; set; }
        }

        public double ComputeTotalPrice(MongoDBService mongoDBService)
        {
            var productCollection = mongoDBService.GetProductsCollection(); // Get the MongoDB collection
            double total = 0;

            foreach (var po in products_ordered)
            {
                var product = productCollection.Find(p => p._id == po.product_id).FirstOrDefault();
                if (product == null) continue; // Skip if product not found

                double price = 0;

                // Traditional switch statement for C# 8.0
                switch (po.price_type)
                {
                    case "retail":
                        price = product.retail_price;
                        break;
                    case "reseller":
                        price = product.reseller_price;
                        break;
                    case "wholesale":
                        price = product.wholesale_price;
                        break;
                    default:
                        price = 0;
                        break;
                }

                total += price * po.quantity; // Multiply price by quantity and add to total
            }

            return total;
        }



    }
}
