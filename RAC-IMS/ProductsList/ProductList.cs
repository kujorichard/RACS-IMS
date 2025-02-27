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

namespace RAC_IMS.ProductsList
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
            MongoDBService mongoService = new MongoDBService("mongodb://localhost:27017", "RACS_IMS");

            bool isConnected = await mongoService.TestConnectionAsync(); // Await the async call

            if (isConnected)
            {
                MessageBox.Show("✅ Connected to MongoDB successfully!", "MongoDB Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Failed to connect to MongoDB!", "MongoDB Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
