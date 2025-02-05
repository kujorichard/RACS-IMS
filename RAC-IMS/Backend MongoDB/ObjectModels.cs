using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC_IMS.Backend_MongoDB
{
    // Model for the Product object in the database
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double reseller_price { get; set; }
        public double wholesale_price { get; set; }
        public double retail_price { get; set; }
        public string category { get; set; }
        public int supplier_id { get; set; }
    }

}
