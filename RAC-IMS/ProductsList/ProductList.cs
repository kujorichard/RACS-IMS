using RAC_IMS.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAC_IMS.Backend.ObjectModels;

namespace RAC_IMS.ProductsList
{
    public partial class ProductList : Form
    {
        private readonly MongoDBService _mongoService;
        const string connection_uri = "mongodb://localhost:27017";
        const string database_name = "RACS_IMS";

        public ProductList()
        {
            InitializeComponent();
            _mongoService = new MongoDBService(connection_uri, database_name);
        }

        private void LoadProducts()
        {
            try
            {
                List<Product> products = _mongoService.GetAllProducts(); // Fetch products from MongoDB

                // Bind to DataGridView
                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                name = "Test Product",
                reseller_price = 50.0,
                wholesale_price = 40.0,
                retail_price = 60.0,
                category = "Test Category",
                supplier = "Test Supplier",
                supplier_id = 99,
                raw_material_id = new List<int> { 1, 2 }
            };

            MongoDBService mongo_service = new MongoDBService(connection_uri, database_name);
            mongo_service.InsertProduct(newProduct);

            MessageBox.Show("Product inserted successfully!");
            LoadProducts();
        }
    }
}
