using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAC_IMS.Backend.ObjectServices;

namespace RAC_IMS.Backend.ObjectModels
{
    internal class Order
    {
        [BsonId] // Marks this as the MongoDB document ID
        [BsonRepresentation(BsonType.ObjectId)] // Ensures it works as a string
        public string _id { get; set; }

        public int customer_id { get; set; }
        public List<KeyValuePair<int, int>> products_id { get; set; }
        public string status { get; set; }
        public double total_price { get; set; }

        [BsonIgnore] // This ensures MongoDB does NOT store this field
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (var product in products_id)
                {
                    int product_id = product.Key;
                    int quantity = product.Value;

                    // Fetch product price 
                    double price = GetProductPriceById(product_id);
                    total += price * quantity;
                }
                return total;
            }
        }


        private double GetProductPriceById(int productId)
        {
            // Example: Fetch from database (Replace this with actual MongoDB query)
            var product = ProductsService.GetProductById(product_id);
            return product != null ? product.retail_price : 0;
        }
    }
}
