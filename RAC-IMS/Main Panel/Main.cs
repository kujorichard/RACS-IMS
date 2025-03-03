using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using RAC_IMS.Backend.ObjectServices;
using RAC_IMS.Backend.ObjectModels;
using RAC_IMS.Backend;
using MongoDB.Bson;
using MongoDB.Driver;
using RAC_IMS.Main_Panel;

namespace RAC_IMS.Main_Panel
{
    public partial class Main : Form
    {
        private readonly MongoDBService mongoDBService;
        private readonly ProductsService productService;
        private readonly RawMaterialsService rawMaterialService;
        private readonly SuppliersService supplierService;
        private readonly OrdersService orderService;

        public Main()
        {
            InitializeComponent();
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";

            mongoDBService = new MongoDBService(connectionUri, databaseName);
            productService = new ProductsService(mongoDBService);
            rawMaterialService = new RawMaterialsService(mongoDBService);
            supplierService = new SuppliersService(mongoDBService);
            orderService = new OrdersService(mongoDBService);
            Load_Tables();
        }


        private async void Load_Tables()
        {
            dgv_products_table.DataSource = await productService.GetAllProducts();
            dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
            dgv_suppliers_table.DataSource = await supplierService.GetAllSuppliers();
            dgv_orders_table.DataSource = await orderService.GetAllOrders();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadMaterialsComboBox();
            LoadSupplierRawMaterialListBox();
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
            foreach (DataGridViewRow row in dgv_products_table.Rows)
            {
                if (row.Cells["name"].Value != null && row.Cells["Name"].Value.ToString() == txt_products_name.Text)
                {
                    MessageBox.Show("The product already exists in the database. Kindly update the desired product's data with Update button.");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txt_products_name.Text))
            {
                MessageBox.Show("Please enter a valid name.");
            }
            if (!double.TryParse(txt_products_resell.Text, out double reseller_price))
            {
                MessageBox.Show("Please enter a valid resell price.");
            }
            if (!double.TryParse(txt_products_wholesale.Text, out double wholesale_price))
            {
                MessageBox.Show("Please enter a valid wholesale price.");
            }
            if (!double.TryParse(txt_products_retail.Text, out double retail_price))
            {
                MessageBox.Show("Please enter a valid retail price.");
            }
            if (!double.TryParse(txt_products_stock.Text, out double stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }


            Product newProduct = new Product
            {
                name = txt_products_name.Text,
                reseller_price = double.Parse(txt_products_resell.Text),
                wholesale_price = double.Parse(txt_products_wholesale.Text),
                retail_price = double.Parse(txt_products_retail.Text),
                stock = int.Parse(txt_products_stock.Text),
                raw_material_id = raw_materials_to_add
            };

            await productService.InsertProduct(newProduct);
            MessageBox.Show("Product added successfully!");
            dgv_products_table.DataSource = await productService.GetAllProducts();
            ClearFields();
        }

        private void btn_products_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
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

            orders_tab.AutoScroll = false;

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
            RawMaterial searchMaterial = new RawMaterial
            {
                name = txt_materials_name.Text.Trim()
            };

            if (string.IsNullOrEmpty(searchMaterial.name))
            {
                MessageBox.Show("Please enter a raw material name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isFound = false;

            foreach (DataGridViewRow row in dgv_rawmaterials_table.Rows)
            {
                if (row.Cells["name"].Value != null &&
                    row.Cells["name"].Value.ToString().Equals(searchMaterial.name, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    isFound = true;
                    dgv_rawmaterials_table.CurrentCell = row.Cells[0];
                    break;
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Raw material not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Select button in suppliers
        {
            Supplier searchSupplier = new Supplier
            {
                name = txt_suppliers_name.Text.Trim()
            };

            if (string.IsNullOrEmpty(searchSupplier.name))
            {
                MessageBox.Show("Please enter a supplier name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isFound = false;

            foreach (DataGridViewRow row in dgv_suppliers_table.Rows)
            {
                if (row.Cells["name"].Value != null &&
                    row.Cells["name"].Value.ToString().Equals(searchSupplier.name, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    isFound = true;
                    dgv_suppliers_table.CurrentCell = row.Cells[0];
                    break;
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Supplier not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                foreach (DataGridViewRow row in dgv_rawmaterials_table.Rows)
                {
                    if (row.Cells["name"].Value != null && row.Cells["name"].Value.ToString() == txt_materials_name.Text)
                    {
                        MessageBox.Show("The raw material already exists in the database. Kindly update the desired material's data with Update button.");
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(txt_materials_name.Text))
                {
                    MessageBox.Show("Please enter a valid name.");
                    return;
                }

                if (!double.TryParse(txt_materials_price.Text, out double price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                if (!int.TryParse(txt_materials_stock.Text, out int stock))
                {
                    MessageBox.Show("Please enter a valid stock quantity.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmb_materials_unit.Text))
                {
                    MessageBox.Show("Please select a unit of measurement.");
                    return;
                }

                if (!clb_materials_supplier.CheckedItems.OfType<Supplier>().Any())
                {
                    MessageBox.Show("Please select at least one supplier.");
                    return;
                }

                Dictionary<string, string> selectedSupplierIDs = new Dictionary<string, string>();

                foreach (var item in clb_materials_supplier.CheckedItems)
                {
                    if (item is Supplier supplier)
                    {
                        selectedSupplierIDs.Add(supplier._id, supplier.name);
                    }
                }

                RawMaterial new_raw_material = new RawMaterial
                {
                    name = txt_materials_name.Text.Trim(),
                    price_per_weight = price,
                    stock = stock,
                    unit = cmb_materials_unit.Text.Trim(),
                    supplier_id = selectedSupplierIDs
                };

                await rawMaterialService.InsertRawMaterial(new_raw_material);
                MessageBox.Show("Raw Material successfully added!");
                dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
                ClearFields_Materials();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding raw material: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadMaterialsComboBox();
        }

        private async void button7_Click(object sender, EventArgs e) // Delete button in materials
        {
            if (dgv_rawmaterials_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a raw material to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgv_rawmaterials_table.SelectedRows[0];
            string id = row.Cells["_id"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid raw material ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this raw material?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await rawMaterialService.DeleteRawMaterial(id);
                    MessageBox.Show("Raw material deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting raw material: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadMaterialsComboBox();
        }

        private async void button10_Click(object sender, EventArgs e) // Update button in materials
        {
            if (dgv_rawmaterials_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a raw material to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgv_rawmaterials_table.SelectedRows[0];
            string id = row.Cells["_id"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid raw material ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RawMaterial existingMaterial = await rawMaterialService.GetRawMaterialById(id);
            if (existingMaterial == null)
            {
                MessageBox.Show("Raw material not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, string> selectedSupplierIds = new Dictionary<string, string>();

            foreach (var item in clb_materials_supplier.CheckedItems)
            {
                if (item is Supplier supplier)
                {
                    selectedSupplierIds.Add(supplier._id, supplier.name);
                }
            }

            // Update specific fields
            if (!string.IsNullOrWhiteSpace(txt_materials_name.Text))
                existingMaterial.name = txt_materials_name.Text.Trim();

            if (double.TryParse(txt_materials_price.Text, out double price))
                existingMaterial.price_per_weight = price;

            if (int.TryParse(txt_materials_stock.Text, out int stock))
                existingMaterial.stock = stock;

            if (!string.IsNullOrWhiteSpace(cmb_materials_unit.Text))
                existingMaterial.unit = cmb_materials_unit.Text.Trim();
            
            if (selectedSupplierIds.Any())
                existingMaterial.supplier_id.Clear();
                existingMaterial.supplier_id = selectedSupplierIds;

            try
            {
                await rawMaterialService.UpdateRawMaterial(id, existingMaterial);
                MessageBox.Show("Raw material updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
                ClearFields_Materials();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating raw material: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadMaterialsComboBox();
        }

        private void button6_Click(object sender, EventArgs e) // Clear button in materials
        {
            ClearFields_Materials();
        }

        private async void ClearFields_Materials()
        {
            txt_materials_name.Text = "";
            txt_materials_price.Text = "";
            txt_materials_stock.Text = "";
            cmb_materials_unit.Text = "";

            dgv_rawmaterials_table.DataSource = null;
            dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
        }

        private void lbl_materials_name_Click(object sender, EventArgs e)
        {

        }
        // End of Materials Tab


        private async void btn_products_delete_Click(object sender, EventArgs e)
        {
            if (dgv_products_table.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_products_table.SelectedRows[0];

                string id = row.Cells["_id"].Value.ToString();

                try
                {
                    await productService.DeleteProduct(id);
                    MessageBox.Show("Selected Product deleted successfully!");
                }
                catch
                {
                    MessageBox.Show("Deletion Error!");
                }
                dgv_products_table.DataSource = await productService.GetAllProducts();
            }
            else
            {
                MessageBox.Show("Select a data row first!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_products_select_Click(object sender, EventArgs e)
        {
            Product searchProduct = new Product
            {
                name = txt_products_name.Text.Trim()
            };

            if (string.IsNullOrEmpty(searchProduct.name))
            {
                MessageBox.Show("Please enter a product name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isFound = false;

            foreach (DataGridViewRow row in dgv_products_table.Rows)
            {
                if (row.Cells["name"].Value != null &&
                    row.Cells["name"].Value.ToString().Equals(searchProduct.name, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    isFound = true;
                    dgv_products_table.CurrentCell = row.Cells[0];
                    break;
                }
                ClearFields();
            }
            
            if (!isFound)
            {
                MessageBox.Show("Product not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_suppliers_clear_Click(object sender, EventArgs e)
        {
            ClearFields_Supplier();
        }

        private async void ClearFields_Supplier()
        {
            txt_suppliers_name.Text = "";
            txt_suppliers_contactnum.Text = "";
            txt_suppliers_contact.Text = "";
            txt_suppliers_address.Text = "";

            dgv_suppliers_table.DataSource = null;
            dgv_suppliers_table.DataSource = await supplierService.GetAllSuppliers();
        }

        private async void btn_suppliers_add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_suppliers_table.Rows)
            {
                if (row.Cells["name"].Value != null && row.Cells["name"].Value.ToString() == txt_suppliers_name.Text)
                {
                    MessageBox.Show("The supplier already exists in the database. Kindly update the desired supplier's data with Update button.");
                    return;
                }
            }

            string suppliername = txt_suppliers_name.Text;
            string contactnumber = txt_suppliers_contactnum.Text;
            string contactperson = txt_suppliers_contact.Text;
            string address = txt_suppliers_address.Text;

            if (string.IsNullOrWhiteSpace(suppliername) || string.IsNullOrWhiteSpace(contactnumber))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Supplier newSupplier = new Supplier
            {
                name = suppliername,
                contact_num = contactnumber,
                contact_person = contactperson,
                address = address
            };

            try
            {
                await supplierService.InsertSupplier(newSupplier);
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_suppliers_table.DataSource = await supplierService.GetAllSuppliers();
                LoadSupplierRawMaterialListBox();
                ClearFields_Supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ClearFields()
        {
            txt_products_name.Text = "";
            txt_products_resell.Text = "";
            txt_products_retail.Text = "";
            txt_products_wholesale.Text = "";
            txt_products_stock.Text = "";

            dgv_products_table.DataSource = null;
            dgv_products_table.DataSource = await productService.GetAllProducts();
        }

        private async void btn_suppliers_delete_Click(object sender, EventArgs e)
        {
            if(dgv_suppliers_table.SelectedRows.Count == 0)
    {
                MessageBox.Show("Please select a supplier to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgv_suppliers_table.SelectedRows[0];
            string id = row.Cells["_id"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid supplier ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await supplierService.DeleteSupplier(id);
                    MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_suppliers_table.DataSource = await supplierService.GetAllSuppliers();
                    LoadSupplierRawMaterialListBox();
                    ClearFields_Supplier();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task LoadSuppliers()
        {
            try
            {
                var suppliers = await supplierService.GetAllSuppliers();

                if (suppliers != null && suppliers.Any())
                {

                    suppliers = suppliers.OrderByDescending(s => s._id).ToList();

                    dgv_suppliers_table.DataSource = null;
                    dgv_suppliers_table.DataSource = suppliers;
                    dgv_suppliers_table.Refresh();


                    dgv_suppliers_table.ClearSelection();
                    dgv_suppliers_table.Rows[0].Selected = true;
                    dgv_suppliers_table.FirstDisplayedScrollingRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_products_update_Click(object sender, EventArgs e)
        {
            if (dgv_products_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgv_products_table.SelectedRows[0];
            string id = row.Cells["_id"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product existingProduct = await productService.GetProductById(id);
            if (existingProduct == null)
            {
                MessageBox.Show("Product not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update specific field
            if (!string.IsNullOrWhiteSpace(txt_products_name.Text))
                existingProduct.name = txt_products_name.Text.Trim();
            if (double.TryParse(txt_products_resell.Text, out double reseller_price))
                existingProduct.reseller_price = reseller_price;
            if (double.TryParse(txt_products_wholesale.Text, out double wholesale_price))
                existingProduct.wholesale_price = wholesale_price;
            if (double.TryParse(txt_products_retail.Text, out double retail_price))
                existingProduct.retail_price = retail_price;
            if (int.TryParse(txt_products_stock.Text, out int stock))
                existingProduct.stock = stock;
            

                try
                {
                await productService.UpdateProduct(id, existingProduct);
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_products_table.DataSource = await productService.GetAllProducts();

                // Update raw material stock - Additional properties in product class needs to be added for this to work such as how much does a product consume a raw material
                /*
                string productId = existingProduct._id;
                int newStock = int.Parse(txt_products_stock.Text);

                var product = await productService.GetProductById(productId);
                if (product == null) return;

                int stockDifference = newStock - product.stock; // Calculate change of stock

                if (stockDifference != 0)
                {
                    await rawMaterialService.UpdateRawMaterialStock(productId, stockDifference);
                    product.stock = newStock;
                    await productService.UpdateProduct(productId, product);
                }
                */

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_suppliers_update_Click(object sender, EventArgs e)
        {
            if (dgv_suppliers_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgv_suppliers_table.SelectedRows[0];
            string id = row.Cells["_id"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid supplier ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supplier existingSupplier = await supplierService.GetSupplierById(id);
            if (existingSupplier == null)
            {
                MessageBox.Show("Supplier not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update specific fields
            if (!string.IsNullOrWhiteSpace(txt_suppliers_name.Text))
                existingSupplier.name = txt_suppliers_name.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txt_suppliers_contactnum.Text))
                existingSupplier.contact_num = txt_suppliers_contactnum.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txt_suppliers_contact.Text))
                existingSupplier.contact_person = txt_suppliers_contact.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txt_suppliers_address.Text))
                existingSupplier.address = txt_suppliers_address.Text.Trim();

            try
            {
                await supplierService.UpdateSupplier(id, existingSupplier);
                MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadSuppliers();
                LoadSupplierRawMaterialListBox();
                ClearFields_Supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clb_products_materials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void LoadSupplierRawMaterialListBox()
        {
            var suppliers = await supplierService.GetAllSuppliers();

            if (suppliers == null || suppliers.Count == 0)
            {
                return;
            }

            clb_materials_supplier.DataSource = suppliers; 
            clb_materials_supplier.DisplayMember = "name";  
            clb_materials_supplier.ValueMember = "_id";  
        }


        private void dgv_products_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void orders_tab_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrderForm order = new OrderForm();
            order.FormClosed += (s, args) => this.Show();
            order.ShowDialog();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }


        // Orders tab datagrid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await RefreshOrdersTable();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        public static Dictionary<string, double> raw_materials_to_add = new Dictionary<string, double>(); // List to hold raw materials for product

        private async void LoadMaterialsComboBox() // load raw materials into combobox
        {
            var raw_materials = await rawMaterialService.GetAllRawMaterials();

            if (raw_materials == null || raw_materials.Count == 0)
            {
                MessageBox.Show("No products found or failed to fetch data.");
                return;
            }

            cmb_products_material.DataSource = null;
            cmb_products_material.DataSource = raw_materials;
            cmb_products_material.DisplayMember = "name";
            cmb_products_material.ValueMember = "_id";
            cmb_products_material.Refresh();

        }

        private void button3_Click_1(object sender, EventArgs e) // Add material
        {
            if (string.IsNullOrWhiteSpace(txt_products_material_quantity.Text) || cmb_products_material.SelectedValue == null)
            {
                MessageBox.Show("Please select a material and enter a valid quantity.");
                return;
            }

            string materialName = cmb_products_material.SelectedValue.ToString();
            double quantity;

            if (!double.TryParse(txt_products_material_quantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid number for quantity.");
                return;
            }

            // Add material to dictionary
            if (!raw_materials_to_add.ContainsKey(materialName))
            {
                raw_materials_to_add.Add(materialName, quantity);
            }
            else
            {
                raw_materials_to_add[materialName] += quantity; // Update quantity if already exists
            }

            txt_products_material_quantity.Clear();

            // Convert Dictionary to a List and Bind
            dgv_materials_added.DataSource = new BindingSource(new BindingList<KeyValuePair<string, double>>(raw_materials_to_add.ToList()), null);
            LoadMaterialsComboBox();
        }

        private void button4_Click_1(object sender, EventArgs e) //Delete material
        {
            if (dgv_materials_added.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a material to remove.");
                return;
            }

            // Assuming the material name is in the first column
            string material_to_remove = dgv_materials_added.SelectedRows[0].Cells[0].Value.ToString();

            if (raw_materials_to_add.ContainsKey(material_to_remove))
            {
                raw_materials_to_add.Remove(material_to_remove); // Remove from dictionary

                // Refresh DataGridView
                dgv_materials_added.DataSource = new BindingSource(raw_materials_to_add, null);
            }
            else
            {
                MessageBox.Show("Material not found in the list.");
            }

            LoadMaterialsComboBox();
        }

        private void btn_orders_select_Click(object sender, EventArgs e)
        {
            if (dgv_orders_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            // Get the selected order
            Order selected_order = dgv_orders_table.SelectedRows[0].DataBoundItem as Order;

            if (selected_order != null)
            {
                string order_id = selected_order._id;
                OrderReceiptForm order_details_form = new OrderReceiptForm(order_id);
                order_details_form.Show(); // Open the details form
            }
        }

        private async Task RefreshOrdersTable()
        {
            try
            {
                dgv_orders_table.DataSource = null; // Clear existing data
                var orders = await orderService.GetAllOrders(); // Fetch latest orders
                dgv_orders_table.DataSource = orders; // Bind to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing orders: {ex.Message}");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dgv_orders_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            // Get selected order ID (Assumes the first column has the _id)
            string orderId = dgv_orders_table.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Order ID is missing. Cannot delete.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this order?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                    await orderService.DeleteOrder(orderId);
                    MessageBox.Show("Order deleted successfully!");
                    await RefreshOrdersTable(); // Refresh DataGridView
            }
        }
    }
}
