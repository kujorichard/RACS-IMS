﻿using System;
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
                }
                if (!double.TryParse(txt_materials_price.Text, out double price))
                {
                    MessageBox.Show("Please enter a valid price.");
                }

                if (!double.TryParse(txt_materials_stock.Text, out double stock))
                {
                    MessageBox.Show("Please enter a valid stock quantity.");
                    return;
                }

                RawMaterial new_raw_material = new RawMaterial
                {
                    name = txt_materials_name.Text.Trim(),
                    price_per_weight = price,
                    unit = cmb_materials_unit.Text.Trim()
                };

                await rawMaterialService.InsertRawMaterial(new_raw_material);
                MessageBox.Show("Raw Material successfully inputted!");
                dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();

            }
            catch
            {
                MessageBox.Show("Invalid Entry");
            }
        }

        private async void button7_Click(object sender, EventArgs e) // Delete button in materials
        {   
            if (dgv_rawmaterials_table.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_rawmaterials_table.SelectedRows[0];

                string id = row.Cells["_id"].Value.ToString();
                    
                try
                {
                    await rawMaterialService.DeleteRawMaterial(id);
                    MessageBox.Show("Raw Material deleted successfully!");
                }
                catch
                {
                    MessageBox.Show("Deletion Error!");
                }
                dgv_rawmaterials_table.DataSource = await rawMaterialService.GetAllRawMaterials();
            } else
            {
                MessageBox.Show("Select a data row first!");
            }
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
            }
            
            if (!isFound)
            {
                MessageBox.Show("Product not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_suppliers_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private async void btn_suppliers_add_Click(object sender, EventArgs e)
        {
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

                if (dgv_suppliers_table.Rows.Count > 0)
                {
                    dgv_suppliers_table.ClearSelection();
                    dgv_suppliers_table.Rows[dgv_suppliers_table.Rows.Count - 1].Selected = true;
                    dgv_suppliers_table.FirstDisplayedScrollingRowIndex = dgv_suppliers_table.Rows.Count - 1;
                }

                ClearFields();
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txt_suppliers_name.Clear();
            txt_suppliers_contactnum.Clear();
            txt_suppliers_contact.Clear();
            txt_suppliers_address.Clear();
        }

        private async void btn_suppliers_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_suppliers_table.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select at least one supplier to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<string> supplierIdsToDelete = new List<string>();

                foreach (DataGridViewRow row in dgv_suppliers_table.SelectedRows)
                {
                    if (row.Cells["_id"].Value != null)
                    {
                        string idString = row.Cells["_id"].Value.ToString();
                        supplierIdsToDelete.Add(idString);
                    }
                }

                if (supplierIdsToDelete.Count == 0)
                {
                    MessageBox.Show("Invalid supplier ID(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                DialogResult result = MessageBox.Show($"Are you sure you want to delete {supplierIdsToDelete.Count} supplier(s)?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (var supplierId in supplierIdsToDelete)
                    {
                        await supplierService.DeleteSupplier(supplierId);
                    }
                    MessageBox.Show("Supplier(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadSuppliers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting supplier(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
