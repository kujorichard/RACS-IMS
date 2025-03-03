using RAC_IMS.Backend;
using RAC_IMS.Backend.ObjectModels;
using RAC_IMS.Backend.ObjectServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAC_IMS.Main_Panel
{
    public partial class OrderForm : Form
    {
        private readonly MongoDBService mongoDBService;
        private readonly ProductsService productService;
        private readonly OrdersService orderService;
        public OrderForm()
        {
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";

            mongoDBService = new MongoDBService(connectionUri, databaseName);
            productService = new ProductsService(mongoDBService);
            orderService = new OrdersService(mongoDBService);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Add item(product)
        {
            // Variable to hold the ordered product
            ProductOrder new_product_order = new ProductOrder();

            //new_product_order.product_id = cmb_order_product.SelectedValue.ToString();
           // new_product_order.quantity = Convert.ToInt32(txt_order_qty.Text);
            //new_product_order.price_type = cmb_order_price_type.Text;

            products_ordered.Add(new_product_order);
            txt_order_qty.Clear();
            LoadProductsOrdered(); // Refresh datagrid to display products ordered
        }

        // Load products into product options in order form
        private async void LoadProductsComboBox()
        {
            var products = await productService.GetAllProducts();   

            if (products == null || products.Count == 0)
            {
                MessageBox.Show("No products found or failed to fetch data.");
                return;
            }

            //cmb_order_product.DataSource = null;
            //cmb_order_product.DataSource = products;
            //cmb_order_product.DisplayMember = "name";
            //cmb_order_product.ValueMember = "_id";
            //cmb_order_product.Refresh();

        }

        private void LoadProductsOrdered() // Reload data grid to see products ordered
        {
            dgv_order_products_selected.DataSource = null; // Reset binding
            dgv_order_products_selected.DataSource = products_ordered;
            dgv_order_products_selected.Refresh();

        }

        // Load products into product options in order form
        private void OrderForm_Load_1(object sender, EventArgs e)
        {
            LoadProductsComboBox();
        }

        // Products ordered array
        private List<ProductOrder> products_ordered = new List<ProductOrder>();

    }
}
