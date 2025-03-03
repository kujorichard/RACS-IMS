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
using RAC_IMS.Backend.ObjectModels;

namespace RAC_IMS.Backend.ObjectModels
{
    public class ProductOrder
    {
        public string product_id { get; set; }
        public int quantity { get; set; }
        public string price_type { get; set; }
    }

    internal class Order
    {
        [BsonId] // Marks this as the MongoDB document ID
        [BsonRepresentation(BsonType.ObjectId)] // Ensures it works as a string
        public string _id { get; set; }

        public string customer { get; set; }
        public List<ProductOrder> products_ordered { get; set; }
        public string status { get; set; }
        public double total_price { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime created_at { get; set; } = DateTime.UtcNow; // Automatically set when created

        public async void ComputeTotalPrice(ProductsService productsService)
        {

            var productCollection = productsService.GetAllProducts(); // Get the MongoDB collection
            double total = 0;

            foreach (var po in products_ordered)
            {
                Product product = await productsService.GetProductById(po.product_id); // Get the product by ID
                if (product == null) continue; // Skip if product not found

                double price = 0;

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

            total_price = total; // Set the total price
        }



    }
}
