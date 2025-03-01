using RAC_IMS.Backend.ObjectServices;
using RAC_IMS.Backend.ObjectModels;
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
using System.Xml.Linq;

namespace RAC_IMS.Main_Panel
{
    public partial class Main : Form
    {
        private readonly MongoDBService mongoDBService;
        private readonly ProductsService productService;
        private readonly RawMaterialsService rawMaterialService;
        private readonly SuppliersService supplierService;

        public Main()
        {
            InitializeComponent();
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";

            mongoDBService = new MongoDBService(connectionUri, databaseName);
            productService = new ProductsService(mongoDBService);
            rawMaterialService = new RawMaterialsService(mongoDBService);
            supplierService = new SuppliersService(mongoDBService);
            Load_Tables();
        }

        private async void Load_Tables()
        {
            dgv_products_table.DataSource = await productService.GetAllProducts();
            dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
            dgv_suppliers_table.DataSource = await supplierService.GetAllSuppliers();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pb_login_logo_Click(object sender, EventArgs e)
        {

        }

        private void btn_main_inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_main_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirm Logout",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void lbl_login_acc_Click(object sender, EventArgs e)
        {

        }

        private void btn_main_inventory_Click(object sender, EventArgs e)
        {
            tc_main_sales.Visible = false;
            tc_main_inventory.Visible = true;
            tc_main_inventory.Dock = DockStyle.Fill;
        }

        private void btn_main_sales_Click(object sender, EventArgs e)
        {
            tc_main_inventory.Visible = false;
            tc_main_sales.Visible = true;
            tc_main_sales.Dock = DockStyle.Fill;
        }

        private void product_tab_Click(object sender, EventArgs e)
        {

        }

        private async void btn_products_add_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                name = txt_products_name.Text,
                reseller_price = double.Parse(txt_products_resell.Text),
                wholesale_price = double.Parse(txt_products_wholesale.Text),
                retail_price = double.Parse(txt_products_retail.Text),
                stock = int.Parse(txt_products_stock.Text),
                supplier = cmb_products_supplier.Text,
                
            };

            await productService.InsertProduct(newProduct);
            MessageBox.Show("Product added successfully!");
            dgv_products_table.DataSource = await productService.GetAllProducts();
        }

        private void btn_products_clear_Click(object sender, EventArgs e)
        {
            txt_products_name.Text = "";
            txt_products_resell.Text = "";
            txt_products_retail.Text = "";
            txt_products_wholesale.Text = "";
            cmb_products_category.Text = "";
            cmb_products_supplier.Text = "";
            dgv_products_table.Rows.Clear();
        }

        private void btn_main_overview_Click(object sender, EventArgs e)
        {
            tc_main_inventory.Visible = true;
            tc_main_inventory.Dock = DockStyle.None;
            tc_main_inventory.Size = new Size(798, 1022);
            tc_main_inventory.Location = new Point(267,338);

            tc_main_sales.Visible = true;
            tc_main_sales.Dock = DockStyle.None;
            tc_main_sales.Size = new Size(798,305);
            tc_main_sales.Location = new Point(267,27);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Materials tab
        private void txt_materials_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) // Select button in materials
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txt_materials_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_materials_unit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button8_Click(object sender, EventArgs e) // Add button in materials
        {

            try
            {
                if (!double.TryParse(txt_materials_price.Text, out double price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                RawMaterial new_raw_material = new RawMaterial
                {
                    name = txt_materials_name.Text.Trim(),
                    price_per_weight = price,
                    unit = cmb_materials_unit.Text.Trim()
                };

        }

        private void button7_Click(object sender, EventArgs e) // Delete button in materials
        {

        }

        private void button10_Click(object sender, EventArgs e) // Update button in materials
        {

        }

        private void button6_Click(object sender, EventArgs e) // Clear button in materials
        {

        }

        private void lbl_materials_name_Click(object sender, EventArgs e)
        {

        }
        // End of Materials Tab


        private void btn_products_delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
