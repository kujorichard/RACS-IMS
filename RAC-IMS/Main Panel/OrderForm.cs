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

        private void button1_Click(object sender, EventArgs e) // Cancel order button
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e) // Finish order button
        {
            // Check if customer name is empty
            if (string.IsNullOrWhiteSpace(txt_order_customerName.Text))
            {
                MessageBox.Show("Customer name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if products are added
            if (products_ordered == null || products_ordered.Count == 0)
            {
                MessageBox.Show("Please add at least one product to the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new order object    
            Order new_order = new Order()
            {
                customer = txt_order_customerName.Text,
                products_ordered = products_ordered,
                status = "pending",
            };

            new_order.ComputeTotalPrice(productService); // Compute total price of the order
            await orderService.InsertOrder(new_order); // Add the order to the database

            MessageBox.Show("Order successfully placed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Add item(product)
        {
            // Variable to hold the ordered product
            ProductOrder new_product_order = new ProductOrder();

            new_product_order.product_id = comboBox1.SelectedValue.ToString();
            new_product_order.quantity = Convert.ToInt32(txt_order_qty.Text);
            new_product_order.price_type = cmb_order_price_type.Text;

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

            comboBox1.DataSource = null;
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "_id";
            comboBox1.Refresh();

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

        private void btn_order_remove_item_Click(object sender, EventArgs e) // Remove button to remove selected product
        {
            if (dgv_order_products_selected.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            // Get selected row index
            int rowIndex = dgv_order_products_selected.SelectedRows[0].Index;

            if (rowIndex >= 0 && rowIndex < products_ordered.Count)
            {
                products_ordered.RemoveAt(rowIndex); // Remove from the list
                LoadProductsOrdered(); // Refresh DataGridView
            }
        }
    }
}
