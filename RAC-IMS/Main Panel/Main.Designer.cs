namespace RAC_IMS.Main_Panel
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_main_overview = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_main_sales = new System.Windows.Forms.Button();
            this.btn_main_exit = new System.Windows.Forms.Button();
            this.btn_main_inventory = new System.Windows.Forms.Button();
            this.lbl_login_inventorytext = new System.Windows.Forms.Label();
            this.pb_login_logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tc_main_inventory = new System.Windows.Forms.TabControl();
            this.product_tab = new System.Windows.Forms.TabPage();
            this.txt_products_stock = new System.Windows.Forms.TextBox();
            this.lbl_products_stock = new System.Windows.Forms.Label();
            this.btn_products_clear = new System.Windows.Forms.Button();
            this.btn_products_delete = new System.Windows.Forms.Button();
            this.btn_products_add = new System.Windows.Forms.Button();
            this.btn_products_select = new System.Windows.Forms.Button();
            this.btn_products_update = new System.Windows.Forms.Button();
            this.clb_products_materials = new System.Windows.Forms.CheckedListBox();
            this.cmb_products_category = new System.Windows.Forms.ComboBox();
            this.cmb_products_supplier = new System.Windows.Forms.ComboBox();
            this.txt_products_retail = new System.Windows.Forms.TextBox();
            this.txt_products_wholesale = new System.Windows.Forms.TextBox();
            this.txt_products_resell = new System.Windows.Forms.TextBox();
            this.txt_products_name = new System.Windows.Forms.TextBox();
            this.lbl_products_materials = new System.Windows.Forms.Label();
            this.lbl_products_supplier = new System.Windows.Forms.Label();
            this.lbl_products_category = new System.Windows.Forms.Label();
            this.lbl_products_retail = new System.Windows.Forms.Label();
            this.lbl_products_wholesale = new System.Windows.Forms.Label();
            this.lbl_products_resell = new System.Windows.Forms.Label();
            this.lbl_products_name = new System.Windows.Forms.Label();
            this.dgv_products_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.suppliers_tab = new System.Windows.Forms.TabPage();
            this.txt_suppliers_address = new System.Windows.Forms.TextBox();
            this.lbl_suppliers_address = new System.Windows.Forms.Label();
            this.btn_suppliers_clear = new System.Windows.Forms.Button();
            this.btn_suppliers_delete = new System.Windows.Forms.Button();
            this.btn_suppliers_add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_suppliers_contact = new System.Windows.Forms.TextBox();
            this.txt_suppliers_contactnum = new System.Windows.Forms.TextBox();
            this.txt_suppliers_name = new System.Windows.Forms.TextBox();
            this.lbl_suppliers_person = new System.Windows.Forms.Label();
            this.lbl_suppliers_contact = new System.Windows.Forms.Label();
            this.lbl_suppliers_name = new System.Windows.Forms.Label();
            this.dgv_suppliers_table = new System.Windows.Forms.DataGridView();
            this.materials_tab = new System.Windows.Forms.TabPage();
            this.txt_materials_stock = new System.Windows.Forms.TextBox();
            this.lbl_materials_stock = new System.Windows.Forms.Label();
            this.btn_materials_clear = new System.Windows.Forms.Button();
            this.btn_materials_delete = new System.Windows.Forms.Button();
            this.btn_materials_add = new System.Windows.Forms.Button();
            this.btn_materials_select = new System.Windows.Forms.Button();
            this.btn_materials_update = new System.Windows.Forms.Button();
            this.cmb_materials_unit = new System.Windows.Forms.ComboBox();
            this.txt_materials_price = new System.Windows.Forms.TextBox();
            this.txt_materials_name = new System.Windows.Forms.TextBox();
            this.lbl_materials_unit = new System.Windows.Forms.Label();
            this.lbl_materials_price = new System.Windows.Forms.Label();
            this.lbl_materials_name = new System.Windows.Forms.Label();
            this.dgv_rawmaterials_table = new System.Windows.Forms.DataGridView();
            this.tc_main_sales = new System.Windows.Forms.TabControl();
            this.orders_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).BeginInit();
            this.tc_main_inventory.SuspendLayout();
            this.product_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products_table)).BeginInit();
            this.suppliers_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers_table)).BeginInit();
            this.materials_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rawmaterials_table)).BeginInit();
            this.tc_main_sales.SuspendLayout();
            this.orders_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_main_overview);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btn_main_sales);
            this.panel1.Controls.Add(this.btn_main_exit);
            this.panel1.Controls.Add(this.btn_main_inventory);
            this.panel1.Controls.Add(this.lbl_login_inventorytext);
            this.panel1.Controls.Add(this.pb_login_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 806);
            this.panel1.TabIndex = 0;
            // 
            // btn_main_overview
            // 
            this.btn_main_overview.BackColor = System.Drawing.Color.Black;
            this.btn_main_overview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_overview.ForeColor = System.Drawing.Color.White;
            this.btn_main_overview.Image = global::RAC_IMS.Properties.Resources.table_32px;
            this.btn_main_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_overview.Location = new System.Drawing.Point(45, 212);
            this.btn_main_overview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_main_overview.Name = "btn_main_overview";
            this.btn_main_overview.Size = new System.Drawing.Size(267, 50);
            this.btn_main_overview.TabIndex = 9;
            this.btn_main_overview.Text = "OVERVIEW";
            this.btn_main_overview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_overview.UseVisualStyleBackColor = false;
            this.btn_main_overview.Click += new System.EventHandler(this.btn_main_overview_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(356, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 245);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(192, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_main_sales
            // 
            this.btn_main_sales.BackColor = System.Drawing.Color.Black;
            this.btn_main_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_sales.ForeColor = System.Drawing.Color.White;
            this.btn_main_sales.Image = global::RAC_IMS.Properties.Resources.sales_32px;
            this.btn_main_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_sales.Location = new System.Drawing.Point(45, 287);
            this.btn_main_sales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_main_sales.Name = "btn_main_sales";
            this.btn_main_sales.Size = new System.Drawing.Size(267, 50);
            this.btn_main_sales.TabIndex = 8;
            this.btn_main_sales.Text = "SALES";
            this.btn_main_sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_sales.UseVisualStyleBackColor = false;
            this.btn_main_sales.Click += new System.EventHandler(this.btn_main_sales_Click);
            // 
            // btn_main_exit
            // 
            this.btn_main_exit.BackColor = System.Drawing.Color.Black;
            this.btn_main_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_main_exit.Image = global::RAC_IMS.Properties.Resources.exit_32px;
            this.btn_main_exit.Location = new System.Drawing.Point(35, 720);
            this.btn_main_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_main_exit.Name = "btn_main_exit";
            this.btn_main_exit.Size = new System.Drawing.Size(63, 46);
            this.btn_main_exit.TabIndex = 7;
            this.btn_main_exit.UseVisualStyleBackColor = false;
            this.btn_main_exit.Click += new System.EventHandler(this.btn_main_exit_Click);
            // 
            // btn_main_inventory
            // 
            this.btn_main_inventory.BackColor = System.Drawing.Color.Black;
            this.btn_main_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_main_inventory.Image = global::RAC_IMS.Properties.Resources.checklists_32px;
            this.btn_main_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_inventory.Location = new System.Drawing.Point(45, 366);
            this.btn_main_inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_main_inventory.Name = "btn_main_inventory";
            this.btn_main_inventory.Size = new System.Drawing.Size(268, 50);
            this.btn_main_inventory.TabIndex = 6;
            this.btn_main_inventory.Text = "INVENTORY";
            this.btn_main_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_inventory.UseVisualStyleBackColor = false;
            this.btn_main_inventory.Click += new System.EventHandler(this.btn_main_inventory_Click);
            // 
            // lbl_login_inventorytext
            // 
            this.lbl_login_inventorytext.AutoSize = true;
            this.lbl_login_inventorytext.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_inventorytext.ForeColor = System.Drawing.Color.White;
            this.lbl_login_inventorytext.Location = new System.Drawing.Point(32, 9);
            this.lbl_login_inventorytext.Name = "lbl_login_inventorytext";
            this.lbl_login_inventorytext.Size = new System.Drawing.Size(279, 21);
            this.lbl_login_inventorytext.TabIndex = 5;
            this.lbl_login_inventorytext.Text = "Inventory Management System";
            // 
            // pb_login_logo
            // 
            this.pb_login_logo.Image = global::RAC_IMS.Properties.Resources.brand_logo_200pxX172px;
            this.pb_login_logo.Location = new System.Drawing.Point(45, 18);
            this.pb_login_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_login_logo.Name = "pb_login_logo";
            this.pb_login_logo.Size = new System.Drawing.Size(268, 172);
            this.pb_login_logo.TabIndex = 4;
            this.pb_login_logo.TabStop = false;
            this.pb_login_logo.Click += new System.EventHandler(this.pb_login_logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(356, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 33);
            this.panel2.TabIndex = 1;
            // 
            // tc_main_inventory
            // 
            this.tc_main_inventory.Controls.Add(this.product_tab);
            this.tc_main_inventory.Controls.Add(this.suppliers_tab);
            this.tc_main_inventory.Controls.Add(this.materials_tab);
            this.tc_main_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_main_inventory.Location = new System.Drawing.Point(360, 39);
            this.tc_main_inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_main_inventory.Name = "tc_main_inventory";
            this.tc_main_inventory.SelectedIndex = 0;
            this.tc_main_inventory.Size = new System.Drawing.Size(1059, 1394);
            this.tc_main_inventory.TabIndex = 0;
            // 
            // product_tab
            // 
            this.product_tab.AutoScroll = true;
            this.product_tab.BackColor = System.Drawing.Color.Transparent;
            this.product_tab.Controls.Add(this.txt_products_stock);
            this.product_tab.Controls.Add(this.lbl_products_stock);
            this.product_tab.Controls.Add(this.btn_products_clear);
            this.product_tab.Controls.Add(this.btn_products_delete);
            this.product_tab.Controls.Add(this.btn_products_add);
            this.product_tab.Controls.Add(this.btn_products_select);
            this.product_tab.Controls.Add(this.btn_products_update);
            this.product_tab.Controls.Add(this.clb_products_materials);
            this.product_tab.Controls.Add(this.cmb_products_category);
            this.product_tab.Controls.Add(this.cmb_products_supplier);
            this.product_tab.Controls.Add(this.txt_products_retail);
            this.product_tab.Controls.Add(this.txt_products_wholesale);
            this.product_tab.Controls.Add(this.txt_products_resell);
            this.product_tab.Controls.Add(this.txt_products_name);
            this.product_tab.Controls.Add(this.lbl_products_materials);
            this.product_tab.Controls.Add(this.lbl_products_supplier);
            this.product_tab.Controls.Add(this.lbl_products_category);
            this.product_tab.Controls.Add(this.lbl_products_retail);
            this.product_tab.Controls.Add(this.lbl_products_wholesale);
            this.product_tab.Controls.Add(this.lbl_products_resell);
            this.product_tab.Controls.Add(this.lbl_products_name);
            this.product_tab.Controls.Add(this.dgv_products_table);
            this.product_tab.Controls.Add(this.label1);
            this.product_tab.Location = new System.Drawing.Point(4, 38);
            this.product_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_tab.Name = "product_tab";
            this.product_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_tab.Size = new System.Drawing.Size(1051, 1352);
            this.product_tab.TabIndex = 0;
            this.product_tab.Text = "Products";
            this.product_tab.Click += new System.EventHandler(this.product_tab_Click);
            // 
            // txt_products_stock
            // 
            this.txt_products_stock.Location = new System.Drawing.Point(733, 468);
            this.txt_products_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_products_stock.Name = "txt_products_stock";
            this.txt_products_stock.Size = new System.Drawing.Size(263, 34);
            this.txt_products_stock.TabIndex = 26;
            // 
            // lbl_products_stock
            // 
            this.lbl_products_stock.AutoSize = true;
            this.lbl_products_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_stock.Location = new System.Drawing.Point(559, 481);
            this.lbl_products_stock.Name = "lbl_products_stock";
            this.lbl_products_stock.Size = new System.Drawing.Size(84, 25);
            this.lbl_products_stock.TabIndex = 25;
            this.lbl_products_stock.Text = "STOCK";
            this.lbl_products_stock.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_products_clear
            // 
            this.btn_products_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_products_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_products_clear.Location = new System.Drawing.Point(852, 677);
            this.btn_products_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_products_clear.Name = "btn_products_clear";
            this.btn_products_clear.Size = new System.Drawing.Size(144, 42);
            this.btn_products_clear.TabIndex = 24;
            this.btn_products_clear.Text = "CLEAR";
            this.btn_products_clear.UseVisualStyleBackColor = false;
            this.btn_products_clear.Click += new System.EventHandler(this.btn_products_clear_Click);
            // 
            // btn_products_delete
            // 
            this.btn_products_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_products_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_products_delete.Location = new System.Drawing.Point(451, 677);
            this.btn_products_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_products_delete.Name = "btn_products_delete";
            this.btn_products_delete.Size = new System.Drawing.Size(144, 42);
            this.btn_products_delete.TabIndex = 23;
            this.btn_products_delete.Text = "DELETE";
            this.btn_products_delete.UseVisualStyleBackColor = false;
            this.btn_products_delete.Click += new System.EventHandler(this.btn_products_delete_Click);
            // 
            // btn_products_add
            // 
            this.btn_products_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_products_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_add.ForeColor = System.Drawing.Color.Black;
            this.btn_products_add.Location = new System.Drawing.Point(243, 677);
            this.btn_products_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_products_add.Name = "btn_products_add";
            this.btn_products_add.Size = new System.Drawing.Size(144, 42);
            this.btn_products_add.TabIndex = 22;
            this.btn_products_add.Text = "ADD";
            this.btn_products_add.UseVisualStyleBackColor = false;
            this.btn_products_add.Click += new System.EventHandler(this.btn_products_add_Click);
            // 
            // btn_products_select
            // 
            this.btn_products_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_products_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_select.ForeColor = System.Drawing.Color.Black;
            this.btn_products_select.Location = new System.Drawing.Point(43, 677);
            this.btn_products_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_products_select.Name = "btn_products_select";
            this.btn_products_select.Size = new System.Drawing.Size(144, 42);
            this.btn_products_select.TabIndex = 21;
            this.btn_products_select.Text = "SELECT";
            this.btn_products_select.UseVisualStyleBackColor = false;
            this.btn_products_select.Click += new System.EventHandler(this.btn_products_select_Click);
            // 
            // btn_products_update
            // 
            this.btn_products_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_products_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_update.ForeColor = System.Drawing.Color.Black;
            this.btn_products_update.Location = new System.Drawing.Point(655, 677);
            this.btn_products_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_products_update.Name = "btn_products_update";
            this.btn_products_update.Size = new System.Drawing.Size(144, 42);
            this.btn_products_update.TabIndex = 20;
            this.btn_products_update.Text = "UPDATE";
            this.btn_products_update.UseVisualStyleBackColor = false;
            this.btn_products_update.Click += new System.EventHandler(this.btn_products_update_Click);
            // 
            // clb_products_materials
            // 
            this.clb_products_materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_products_materials.FormattingEnabled = true;
            this.clb_products_materials.IntegralHeight = false;
            this.clb_products_materials.Location = new System.Drawing.Point(733, 521);
            this.clb_products_materials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clb_products_materials.Name = "clb_products_materials";
            this.clb_products_materials.Size = new System.Drawing.Size(263, 137);
            this.clb_products_materials.TabIndex = 19;
            // 
            // cmb_products_category
            // 
            this.cmb_products_category.FormattingEnabled = true;
            this.cmb_products_category.Location = new System.Drawing.Point(733, 359);
            this.cmb_products_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_products_category.Name = "cmb_products_category";
            this.cmb_products_category.Size = new System.Drawing.Size(263, 37);
            this.cmb_products_category.TabIndex = 18;
            // 
            // cmb_products_supplier
            // 
            this.cmb_products_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_products_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_products_supplier.FormattingEnabled = true;
            this.cmb_products_supplier.Location = new System.Drawing.Point(733, 415);
            this.cmb_products_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_products_supplier.Name = "cmb_products_supplier";
            this.cmb_products_supplier.Size = new System.Drawing.Size(263, 37);
            this.cmb_products_supplier.TabIndex = 16;
            // 
            // txt_products_retail
            // 
            this.txt_products_retail.Location = new System.Drawing.Point(260, 522);
            this.txt_products_retail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_products_retail.Name = "txt_products_retail";
            this.txt_products_retail.Size = new System.Drawing.Size(263, 34);
            this.txt_products_retail.TabIndex = 12;
            // 
            // txt_products_wholesale
            // 
            this.txt_products_wholesale.Location = new System.Drawing.Point(260, 468);
            this.txt_products_wholesale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_products_wholesale.Name = "txt_products_wholesale";
            this.txt_products_wholesale.Size = new System.Drawing.Size(263, 34);
            this.txt_products_wholesale.TabIndex = 11;
            // 
            // txt_products_resell
            // 
            this.txt_products_resell.Location = new System.Drawing.Point(260, 416);
            this.txt_products_resell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_products_resell.Name = "txt_products_resell";
            this.txt_products_resell.Size = new System.Drawing.Size(263, 34);
            this.txt_products_resell.TabIndex = 10;
            // 
            // txt_products_name
            // 
            this.txt_products_name.Location = new System.Drawing.Point(260, 361);
            this.txt_products_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_products_name.Name = "txt_products_name";
            this.txt_products_name.Size = new System.Drawing.Size(263, 34);
            this.txt_products_name.TabIndex = 9;
            // 
            // lbl_products_materials
            // 
            this.lbl_products_materials.AutoSize = true;
            this.lbl_products_materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_materials.Location = new System.Drawing.Point(559, 532);
            this.lbl_products_materials.Name = "lbl_products_materials";
            this.lbl_products_materials.Size = new System.Drawing.Size(126, 25);
            this.lbl_products_materials.TabIndex = 8;
            this.lbl_products_materials.Text = "MATERIALS";
            // 
            // lbl_products_supplier
            // 
            this.lbl_products_supplier.AutoSize = true;
            this.lbl_products_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_supplier.Location = new System.Drawing.Point(559, 427);
            this.lbl_products_supplier.Name = "lbl_products_supplier";
            this.lbl_products_supplier.Size = new System.Drawing.Size(108, 25);
            this.lbl_products_supplier.TabIndex = 7;
            this.lbl_products_supplier.Text = "SUPPLIER";
            // 
            // lbl_products_category
            // 
            this.lbl_products_category.AutoSize = true;
            this.lbl_products_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_category.Location = new System.Drawing.Point(559, 372);
            this.lbl_products_category.Name = "lbl_products_category";
            this.lbl_products_category.Size = new System.Drawing.Size(124, 25);
            this.lbl_products_category.TabIndex = 6;
            this.lbl_products_category.Text = "CATEGORY";
            // 
            // lbl_products_retail
            // 
            this.lbl_products_retail.AutoSize = true;
            this.lbl_products_retail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_retail.Location = new System.Drawing.Point(37, 533);
            this.lbl_products_retail.Name = "lbl_products_retail";
            this.lbl_products_retail.Size = new System.Drawing.Size(145, 25);
            this.lbl_products_retail.TabIndex = 5;
            this.lbl_products_retail.Text = "RETAIL PRICE";
            // 
            // lbl_products_wholesale
            // 
            this.lbl_products_wholesale.AutoSize = true;
            this.lbl_products_wholesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_wholesale.Location = new System.Drawing.Point(37, 479);
            this.lbl_products_wholesale.Name = "lbl_products_wholesale";
            this.lbl_products_wholesale.Size = new System.Drawing.Size(202, 25);
            this.lbl_products_wholesale.TabIndex = 4;
            this.lbl_products_wholesale.Text = "WHOLESALE PRICE";
            // 
            // lbl_products_resell
            // 
            this.lbl_products_resell.AutoSize = true;
            this.lbl_products_resell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_resell.Location = new System.Drawing.Point(37, 427);
            this.lbl_products_resell.Name = "lbl_products_resell";
            this.lbl_products_resell.Size = new System.Drawing.Size(151, 25);
            this.lbl_products_resell.TabIndex = 3;
            this.lbl_products_resell.Text = "RESELL PRICE";
            // 
            // lbl_products_name
            // 
            this.lbl_products_name.AutoSize = true;
            this.lbl_products_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products_name.Location = new System.Drawing.Point(37, 372);
            this.lbl_products_name.Name = "lbl_products_name";
            this.lbl_products_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_products_name.TabIndex = 2;
            this.lbl_products_name.Text = "NAME";
            // 
            // dgv_products_table
            // 
            this.dgv_products_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_products_table.Location = new System.Drawing.Point(3, 2);
            this.dgv_products_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_products_table.Name = "dgv_products_table";
            this.dgv_products_table.RowHeadersWidth = 51;
            this.dgv_products_table.RowTemplate.Height = 24;
            this.dgv_products_table.Size = new System.Drawing.Size(1045, 325);
            this.dgv_products_table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // suppliers_tab
            // 
            this.suppliers_tab.AutoScroll = true;
            this.suppliers_tab.Controls.Add(this.txt_suppliers_address);
            this.suppliers_tab.Controls.Add(this.lbl_suppliers_address);
            this.suppliers_tab.Controls.Add(this.btn_suppliers_clear);
            this.suppliers_tab.Controls.Add(this.btn_suppliers_delete);
            this.suppliers_tab.Controls.Add(this.btn_suppliers_add);
            this.suppliers_tab.Controls.Add(this.button4);
            this.suppliers_tab.Controls.Add(this.button5);
            this.suppliers_tab.Controls.Add(this.txt_suppliers_contact);
            this.suppliers_tab.Controls.Add(this.txt_suppliers_contactnum);
            this.suppliers_tab.Controls.Add(this.txt_suppliers_name);
            this.suppliers_tab.Controls.Add(this.lbl_suppliers_person);
            this.suppliers_tab.Controls.Add(this.lbl_suppliers_contact);
            this.suppliers_tab.Controls.Add(this.lbl_suppliers_name);
            this.suppliers_tab.Controls.Add(this.dgv_suppliers_table);
            this.suppliers_tab.Location = new System.Drawing.Point(4, 38);
            this.suppliers_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppliers_tab.Name = "suppliers_tab";
            this.suppliers_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppliers_tab.Size = new System.Drawing.Size(1051, 1352);
            this.suppliers_tab.TabIndex = 1;
            this.suppliers_tab.Text = "Suppliers";
            this.suppliers_tab.UseVisualStyleBackColor = true;
            // 
            // txt_suppliers_address
            // 
            this.txt_suppliers_address.Location = new System.Drawing.Point(260, 522);
            this.txt_suppliers_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suppliers_address.Name = "txt_suppliers_address";
            this.txt_suppliers_address.Size = new System.Drawing.Size(263, 34);
            this.txt_suppliers_address.TabIndex = 31;
            // 
            // lbl_suppliers_address
            // 
            this.lbl_suppliers_address.AutoSize = true;
            this.lbl_suppliers_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppliers_address.Location = new System.Drawing.Point(37, 533);
            this.lbl_suppliers_address.Name = "lbl_suppliers_address";
            this.lbl_suppliers_address.Size = new System.Drawing.Size(108, 25);
            this.lbl_suppliers_address.TabIndex = 30;
            this.lbl_suppliers_address.Text = "ADDRESS";
            // 
            // btn_suppliers_clear
            // 
            this.btn_suppliers_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suppliers_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_suppliers_clear.Location = new System.Drawing.Point(852, 601);
            this.btn_suppliers_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_suppliers_clear.Name = "btn_suppliers_clear";
            this.btn_suppliers_clear.Size = new System.Drawing.Size(144, 42);
            this.btn_suppliers_clear.TabIndex = 29;
            this.btn_suppliers_clear.Text = "CLEAR";
            this.btn_suppliers_clear.UseVisualStyleBackColor = false;
            this.btn_suppliers_clear.Click += new System.EventHandler(this.btn_suppliers_clear_Click);
            // 
            // btn_suppliers_delete
            // 
            this.btn_suppliers_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_suppliers_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_suppliers_delete.Location = new System.Drawing.Point(451, 601);
            this.btn_suppliers_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_suppliers_delete.Name = "btn_suppliers_delete";
            this.btn_suppliers_delete.Size = new System.Drawing.Size(144, 42);
            this.btn_suppliers_delete.TabIndex = 28;
            this.btn_suppliers_delete.Text = "DELETE";
            this.btn_suppliers_delete.UseVisualStyleBackColor = false;
            this.btn_suppliers_delete.Click += new System.EventHandler(this.btn_suppliers_delete_Click);
            // 
            // btn_suppliers_add
            // 
            this.btn_suppliers_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_suppliers_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers_add.ForeColor = System.Drawing.Color.Black;
            this.btn_suppliers_add.Location = new System.Drawing.Point(243, 601);
            this.btn_suppliers_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_suppliers_add.Name = "btn_suppliers_add";
            this.btn_suppliers_add.Size = new System.Drawing.Size(144, 42);
            this.btn_suppliers_add.TabIndex = 27;
            this.btn_suppliers_add.Text = "ADD";
            this.btn_suppliers_add.UseVisualStyleBackColor = false;
            this.btn_suppliers_add.Click += new System.EventHandler(this.btn_suppliers_add_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(43, 601);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 42);
            this.button4.TabIndex = 26;
            this.button4.Text = "SELECT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(655, 601);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 42);
            this.button5.TabIndex = 25;
            this.button5.Text = "UPDATE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txt_suppliers_contact
            // 
            this.txt_suppliers_contact.Location = new System.Drawing.Point(260, 468);
            this.txt_suppliers_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suppliers_contact.Name = "txt_suppliers_contact";
            this.txt_suppliers_contact.Size = new System.Drawing.Size(263, 34);
            this.txt_suppliers_contact.TabIndex = 17;
            // 
            // txt_suppliers_contactnum
            // 
            this.txt_suppliers_contactnum.Location = new System.Drawing.Point(260, 416);
            this.txt_suppliers_contactnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suppliers_contactnum.Name = "txt_suppliers_contactnum";
            this.txt_suppliers_contactnum.Size = new System.Drawing.Size(263, 34);
            this.txt_suppliers_contactnum.TabIndex = 16;
            // 
            // txt_suppliers_name
            // 
            this.txt_suppliers_name.Location = new System.Drawing.Point(260, 361);
            this.txt_suppliers_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suppliers_name.Name = "txt_suppliers_name";
            this.txt_suppliers_name.Size = new System.Drawing.Size(263, 34);
            this.txt_suppliers_name.TabIndex = 15;
            // 
            // lbl_suppliers_person
            // 
            this.lbl_suppliers_person.AutoSize = true;
            this.lbl_suppliers_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppliers_person.Location = new System.Drawing.Point(37, 479);
            this.lbl_suppliers_person.Name = "lbl_suppliers_person";
            this.lbl_suppliers_person.Size = new System.Drawing.Size(200, 25);
            this.lbl_suppliers_person.TabIndex = 14;
            this.lbl_suppliers_person.Text = "CONTACT PERSON";
            // 
            // lbl_suppliers_contact
            // 
            this.lbl_suppliers_contact.AutoSize = true;
            this.lbl_suppliers_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppliers_contact.Location = new System.Drawing.Point(37, 427);
            this.lbl_suppliers_contact.Name = "lbl_suppliers_contact";
            this.lbl_suppliers_contact.Size = new System.Drawing.Size(201, 25);
            this.lbl_suppliers_contact.TabIndex = 13;
            this.lbl_suppliers_contact.Text = "CONTACT NUMBER";
            // 
            // lbl_suppliers_name
            // 
            this.lbl_suppliers_name.AutoSize = true;
            this.lbl_suppliers_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppliers_name.Location = new System.Drawing.Point(37, 372);
            this.lbl_suppliers_name.Name = "lbl_suppliers_name";
            this.lbl_suppliers_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_suppliers_name.TabIndex = 12;
            this.lbl_suppliers_name.Text = "NAME";
            // 
            // dgv_suppliers_table
            // 
            this.dgv_suppliers_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suppliers_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_suppliers_table.Location = new System.Drawing.Point(3, 2);
            this.dgv_suppliers_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_suppliers_table.Name = "dgv_suppliers_table";
            this.dgv_suppliers_table.RowHeadersWidth = 51;
            this.dgv_suppliers_table.RowTemplate.Height = 24;
            this.dgv_suppliers_table.Size = new System.Drawing.Size(1045, 325);
            this.dgv_suppliers_table.TabIndex = 3;
            // 
            // materials_tab
            // 
            this.materials_tab.AutoScroll = true;
            this.materials_tab.BackColor = System.Drawing.Color.Transparent;
            this.materials_tab.Controls.Add(this.txt_materials_stock);
            this.materials_tab.Controls.Add(this.lbl_materials_stock);
            this.materials_tab.Controls.Add(this.btn_materials_clear);
            this.materials_tab.Controls.Add(this.btn_materials_delete);
            this.materials_tab.Controls.Add(this.btn_materials_add);
            this.materials_tab.Controls.Add(this.btn_materials_select);
            this.materials_tab.Controls.Add(this.btn_materials_update);
            this.materials_tab.Controls.Add(this.cmb_materials_unit);
            this.materials_tab.Controls.Add(this.txt_materials_price);
            this.materials_tab.Controls.Add(this.txt_materials_name);
            this.materials_tab.Controls.Add(this.lbl_materials_unit);
            this.materials_tab.Controls.Add(this.lbl_materials_price);
            this.materials_tab.Controls.Add(this.lbl_materials_name);
            this.materials_tab.Controls.Add(this.dgv_rawmaterials_table);
            this.materials_tab.Location = new System.Drawing.Point(4, 38);
            this.materials_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materials_tab.Name = "materials_tab";
            this.materials_tab.Size = new System.Drawing.Size(1051, 1352);
            this.materials_tab.TabIndex = 2;
            this.materials_tab.Text = "Materials";
            // 
            // txt_materials_stock
            // 
            this.txt_materials_stock.Location = new System.Drawing.Point(260, 535);
            this.txt_materials_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_materials_stock.Name = "txt_materials_stock";
            this.txt_materials_stock.Size = new System.Drawing.Size(263, 34);
            this.txt_materials_stock.TabIndex = 36;
            // 
            // lbl_materials_stock
            // 
            this.lbl_materials_stock.AutoSize = true;
            this.lbl_materials_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materials_stock.Location = new System.Drawing.Point(37, 542);
            this.lbl_materials_stock.Name = "lbl_materials_stock";
            this.lbl_materials_stock.Size = new System.Drawing.Size(84, 25);
            this.lbl_materials_stock.TabIndex = 35;
            this.lbl_materials_stock.Text = "STOCK";
            // 
            // btn_materials_clear
            // 
            this.btn_materials_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_materials_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materials_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_materials_clear.Location = new System.Drawing.Point(852, 601);
            this.btn_materials_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_materials_clear.Name = "btn_materials_clear";
            this.btn_materials_clear.Size = new System.Drawing.Size(144, 42);
            this.btn_materials_clear.TabIndex = 34;
            this.btn_materials_clear.Text = "CLEAR";
            this.btn_materials_clear.UseVisualStyleBackColor = false;
            this.btn_materials_clear.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_materials_delete
            // 
            this.btn_materials_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_materials_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materials_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_materials_delete.Location = new System.Drawing.Point(451, 601);
            this.btn_materials_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_materials_delete.Name = "btn_materials_delete";
            this.btn_materials_delete.Size = new System.Drawing.Size(144, 42);
            this.btn_materials_delete.TabIndex = 33;
            this.btn_materials_delete.Text = "DELETE";
            this.btn_materials_delete.UseVisualStyleBackColor = false;
            this.btn_materials_delete.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_materials_add
            // 
            this.btn_materials_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_materials_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materials_add.ForeColor = System.Drawing.Color.Black;
            this.btn_materials_add.Location = new System.Drawing.Point(243, 601);
            this.btn_materials_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_materials_add.Name = "btn_materials_add";
            this.btn_materials_add.Size = new System.Drawing.Size(144, 42);
            this.btn_materials_add.TabIndex = 32;
            this.btn_materials_add.Text = "ADD";
            this.btn_materials_add.UseVisualStyleBackColor = false;
            this.btn_materials_add.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_materials_select
            // 
            this.btn_materials_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_materials_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materials_select.ForeColor = System.Drawing.Color.Black;
            this.btn_materials_select.Location = new System.Drawing.Point(43, 601);
            this.btn_materials_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_materials_select.Name = "btn_materials_select";
            this.btn_materials_select.Size = new System.Drawing.Size(144, 42);
            this.btn_materials_select.TabIndex = 31;
            this.btn_materials_select.Text = "SELECT";
            this.btn_materials_select.UseVisualStyleBackColor = false;
            this.btn_materials_select.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_materials_update
            // 
            this.btn_materials_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_materials_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materials_update.ForeColor = System.Drawing.Color.Black;
            this.btn_materials_update.Location = new System.Drawing.Point(655, 601);
            this.btn_materials_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_materials_update.Name = "btn_materials_update";
            this.btn_materials_update.Size = new System.Drawing.Size(144, 42);
            this.btn_materials_update.TabIndex = 30;
            this.btn_materials_update.Text = "UPDATE";
            this.btn_materials_update.UseVisualStyleBackColor = false;
            this.btn_materials_update.Click += new System.EventHandler(this.button10_Click);
            // 
            // cmb_materials_unit
            // 
            this.cmb_materials_unit.FormattingEnabled = true;
            this.cmb_materials_unit.Location = new System.Drawing.Point(260, 473);
            this.cmb_materials_unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_materials_unit.Name = "cmb_materials_unit";
            this.cmb_materials_unit.Size = new System.Drawing.Size(263, 37);
            this.cmb_materials_unit.TabIndex = 23;
            this.cmb_materials_unit.SelectedIndexChanged += new System.EventHandler(this.cmb_materials_unit_SelectedIndexChanged);
            // 
            // txt_materials_price
            // 
            this.txt_materials_price.Location = new System.Drawing.Point(260, 416);
            this.txt_materials_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_materials_price.Name = "txt_materials_price";
            this.txt_materials_price.Size = new System.Drawing.Size(263, 34);
            this.txt_materials_price.TabIndex = 22;
            this.txt_materials_price.TextChanged += new System.EventHandler(this.txt_materials_price_TextChanged);
            // 
            // txt_materials_name
            // 
            this.txt_materials_name.Location = new System.Drawing.Point(260, 361);
            this.txt_materials_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_materials_name.Name = "txt_materials_name";
            this.txt_materials_name.Size = new System.Drawing.Size(263, 34);
            this.txt_materials_name.TabIndex = 21;
            this.txt_materials_name.TextChanged += new System.EventHandler(this.txt_materials_name_TextChanged);
            // 
            // lbl_materials_unit
            // 
            this.lbl_materials_unit.AutoSize = true;
            this.lbl_materials_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materials_unit.Location = new System.Drawing.Point(37, 479);
            this.lbl_materials_unit.Name = "lbl_materials_unit";
            this.lbl_materials_unit.Size = new System.Drawing.Size(58, 25);
            this.lbl_materials_unit.TabIndex = 20;
            this.lbl_materials_unit.Text = "UNIT";
            // 
            // lbl_materials_price
            // 
            this.lbl_materials_price.AutoSize = true;
            this.lbl_materials_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materials_price.Location = new System.Drawing.Point(37, 427);
            this.lbl_materials_price.Name = "lbl_materials_price";
            this.lbl_materials_price.Size = new System.Drawing.Size(122, 25);
            this.lbl_materials_price.TabIndex = 19;
            this.lbl_materials_price.Text = "UNIT PRICE";
            // 
            // lbl_materials_name
            // 
            this.lbl_materials_name.AutoSize = true;
            this.lbl_materials_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materials_name.Location = new System.Drawing.Point(37, 372);
            this.lbl_materials_name.Name = "lbl_materials_name";
            this.lbl_materials_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_materials_name.TabIndex = 18;
            this.lbl_materials_name.Text = "NAME";
            this.lbl_materials_name.Click += new System.EventHandler(this.lbl_materials_name_Click);
            // 
            // dgv_rawmaterials_table
            // 
            this.dgv_rawmaterials_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rawmaterials_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_rawmaterials_table.Location = new System.Drawing.Point(0, 0);
            this.dgv_rawmaterials_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_rawmaterials_table.Name = "dgv_rawmaterials_table";
            this.dgv_rawmaterials_table.RowHeadersWidth = 51;
            this.dgv_rawmaterials_table.RowTemplate.Height = 24;
            this.dgv_rawmaterials_table.Size = new System.Drawing.Size(1051, 325);
            this.dgv_rawmaterials_table.TabIndex = 4;
            // 
            // tc_main_sales
            // 
            this.tc_main_sales.Controls.Add(this.orders_tab);
            this.tc_main_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_main_sales.Location = new System.Drawing.Point(356, 33);
            this.tc_main_sales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_main_sales.Name = "tc_main_sales";
            this.tc_main_sales.SelectedIndex = 0;
            this.tc_main_sales.Size = new System.Drawing.Size(1061, 373);
            this.tc_main_sales.TabIndex = 2;
            // 
            // orders_tab
            // 
            this.orders_tab.AutoScroll = true;
            this.orders_tab.Controls.Add(this.dataGridView1);
            this.orders_tab.Location = new System.Drawing.Point(4, 38);
            this.orders_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_tab.Name = "orders_tab";
            this.orders_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_tab.Size = new System.Drawing.Size(1053, 331);
            this.orders_tab.TabIndex = 0;
            this.orders_tab.Text = "Orders";
            this.orders_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 806);
            this.Controls.Add(this.tc_main_inventory);
            this.Controls.Add(this.tc_main_sales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btn_main_inventory_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).EndInit();
            this.tc_main_inventory.ResumeLayout(false);
            this.product_tab.ResumeLayout(false);
            this.product_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products_table)).EndInit();
            this.suppliers_tab.ResumeLayout(false);
            this.suppliers_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suppliers_table)).EndInit();
            this.materials_tab.ResumeLayout(false);
            this.materials_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rawmaterials_table)).EndInit();
            this.tc_main_sales.ResumeLayout(false);
            this.orders_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_login_logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_login_inventorytext;
        private System.Windows.Forms.Button btn_main_inventory;
        private System.Windows.Forms.Button btn_main_exit;
        private System.Windows.Forms.Button btn_main_sales;
        private System.Windows.Forms.TabControl tc_main_inventory;
        private System.Windows.Forms.TabPage product_tab;
        private System.Windows.Forms.TabPage suppliers_tab;
        private System.Windows.Forms.TabPage materials_tab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tc_main_sales;
        private System.Windows.Forms.TabPage orders_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_products_table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_products_name;
        private System.Windows.Forms.Label lbl_products_retail;
        private System.Windows.Forms.Label lbl_products_wholesale;
        private System.Windows.Forms.Label lbl_products_resell;
        private System.Windows.Forms.Label lbl_products_supplier;
        private System.Windows.Forms.Label lbl_products_category;
        private System.Windows.Forms.Label lbl_products_materials;
        private System.Windows.Forms.TextBox txt_products_retail;
        private System.Windows.Forms.TextBox txt_products_wholesale;
        private System.Windows.Forms.TextBox txt_products_resell;
        private System.Windows.Forms.TextBox txt_products_name;
        private System.Windows.Forms.ComboBox cmb_products_supplier;
        private System.Windows.Forms.ComboBox cmb_products_category;
        private System.Windows.Forms.CheckedListBox clb_products_materials;
        private System.Windows.Forms.Button btn_products_update;
        private System.Windows.Forms.Button btn_products_clear;
        private System.Windows.Forms.Button btn_products_delete;
        private System.Windows.Forms.Button btn_products_add;
        private System.Windows.Forms.Button btn_products_select;
        private System.Windows.Forms.DataGridView dgv_suppliers_table;
        private System.Windows.Forms.TextBox txt_suppliers_contact;
        private System.Windows.Forms.TextBox txt_suppliers_contactnum;
        private System.Windows.Forms.TextBox txt_suppliers_name;
        private System.Windows.Forms.Label lbl_suppliers_person;
        private System.Windows.Forms.Label lbl_suppliers_contact;
        private System.Windows.Forms.Label lbl_suppliers_name;
        private System.Windows.Forms.Button btn_suppliers_clear;
        private System.Windows.Forms.Button btn_suppliers_delete;
        private System.Windows.Forms.Button btn_suppliers_add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_suppliers_address;
        private System.Windows.Forms.Label lbl_suppliers_address;
        private System.Windows.Forms.DataGridView dgv_rawmaterials_table;
        private System.Windows.Forms.TextBox txt_materials_price;
        private System.Windows.Forms.TextBox txt_materials_name;
        private System.Windows.Forms.Label lbl_materials_unit;
        private System.Windows.Forms.Label lbl_materials_price;
        private System.Windows.Forms.Label lbl_materials_name;
        private System.Windows.Forms.ComboBox cmb_materials_unit;
        private System.Windows.Forms.Button btn_materials_clear;
        private System.Windows.Forms.Button btn_materials_delete;
        private System.Windows.Forms.Button btn_materials_add;
        private System.Windows.Forms.Button btn_materials_select;
        private System.Windows.Forms.Button btn_materials_update;
        private System.Windows.Forms.Button btn_main_overview;
        private System.Windows.Forms.Label lbl_products_stock;
        private System.Windows.Forms.TextBox txt_products_stock;
        private System.Windows.Forms.TextBox txt_materials_stock;
        private System.Windows.Forms.Label lbl_materials_stock;
    }
}