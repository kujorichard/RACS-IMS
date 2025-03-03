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
using MongoDB.Driver;
using RAC_IMS.Backend.ObjectServices;

namespace RAC_IMS.ProductsList
{
    public partial class ProductList : Form
    {
        private readonly MongoDBService mongoDBService;
        private readonly ProductsService productService;

        public ProductList()
        {
            InitializeComponent();
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";

            mongoDBService = new MongoDBService(connectionUri, databaseName);
            productService = new ProductsService(mongoDBService);
        }

        private void LoadProducts()
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                name = textBox1.Text,
                reseller_price = double.Parse(textBox2.Text),
                wholesale_price = double.Parse(textBox3.Text),
                retail_price = double.Parse(textBox4.Text)
            };

            await productService.InsertProduct(newProduct);
            MessageBox.Show("Product added successfully!");
            dataGridView1.DataSource = await productService.GetAllProducts();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {

        }
    }
}
