using RAC_IMS.Backend.ObjectModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAC_IMS.Backend.ObjectServices;
using RAC_IMS.Backend;

namespace RAC_IMS.Main_Panel
{
    public partial class OrderReceiptForm : Form
    {
        private string order_id;
        private readonly MongoDBService mongoDBService;
        private readonly OrdersService orderService;
        private readonly ProductsService productService;

        public OrderReceiptForm(string _orderId)
        {
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";
            mongoDBService = new MongoDBService(connectionUri, databaseName);
            orderService = new OrdersService(mongoDBService);
            productService = new ProductsService(mongoDBService);

            InitializeComponent();
            order_id = _orderId;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private async void OrderReceiptForm_Load(object sender, EventArgs e)
        {
            await LoadOrderDetails(order_id);
        }

        private async Task LoadOrderDetails(string id) // Make method async
        {
            try
            {
                Order order = await orderService.GetOrderById(id); // Fetch order

                if (order != null)
                {
                    lbl_order_customer_name.Text = order.customer;
                    lbl_order_date.Text = order.created_at.ToString();
                    lbl_order_status.Text = order.status;
                    lbl_order_price.Text = order.total_price.ToString();

                    // Fetch full product details
                    var enrichedProducts = new List<object>();

                    foreach (var item in order.products_ordered)
                    {
                        var product = await productService.GetProductById(item.product_id); // Fetch product details

                        if (product != null)
                        {
                            enrichedProducts.Add(new
                            {
                                ProductName = product.name,  // Fetch product name
                                Quantity = item.quantity,    // Quantity from order
                                Price = product.retail_price, // Example: Fetch price
                                Total = product.retail_price * item.quantity // Calculate total cost
                            });
                        }
                    }

                    // Bind enriched data to DataGridView
                    dgv_order_products_ordered.DataSource = enrichedProducts;
                }
                else
                {
                    MessageBox.Show("Order not found!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}");
            }
        }

        private async Task UpdateOrderStatus(string newStatus)
        {
            bool isUpdated = await orderService.UpdateOrderStatus(order_id, newStatus);

            if (isUpdated)
            {
                MessageBox.Show($"Order status updated to {newStatus}");
                await LoadOrderDetails(order_id); // Refresh order details in UI
            }
            else
            {
                MessageBox.Show("Failed to update order status.");
            }
        }

        private async void btn_orders_complete_Click(object sender, EventArgs e)
        {
            await UpdateOrderStatus("Completed");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await UpdateOrderStatus("Pending");
        }
    }

}
