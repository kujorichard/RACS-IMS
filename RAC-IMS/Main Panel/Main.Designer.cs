namespace RAC_IMS.Main_Panel
{
    partial class btn_main_panel
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
            this.lbl_login_inventorytext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_main_sales = new System.Windows.Forms.Button();
            this.btn_main_exit = new System.Windows.Forms.Button();
            this.btn_main_inventory = new System.Windows.Forms.Button();
            this.pb_login_logo = new System.Windows.Forms.PictureBox();
            this.tc_main_inventory = new System.Windows.Forms.TabControl();
            this.product_tab = new System.Windows.Forms.TabPage();
            this.suppliers_tab = new System.Windows.Forms.TabPage();
            this.materials_tab = new System.Windows.Forms.TabPage();
            this.orders_tab = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).BeginInit();
            this.tc_main_inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_main_sales);
            this.panel1.Controls.Add(this.btn_main_exit);
            this.panel1.Controls.Add(this.btn_main_inventory);
            this.panel1.Controls.Add(this.lbl_login_inventorytext);
            this.panel1.Controls.Add(this.pb_login_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 743);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(356, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 33);
            this.panel2.TabIndex = 1;
            // 
            // btn_main_sales
            // 
            this.btn_main_sales.BackColor = System.Drawing.Color.Black;
            this.btn_main_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_sales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_sales.ForeColor = System.Drawing.Color.White;
            this.btn_main_sales.Image = global::RAC_IMS.Properties.Resources.sales_32px;
            this.btn_main_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_sales.Location = new System.Drawing.Point(45, 369);
            this.btn_main_sales.Name = "btn_main_sales";
            this.btn_main_sales.Size = new System.Drawing.Size(267, 51);
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
            this.btn_main_exit.Location = new System.Drawing.Point(34, 672);
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
            this.btn_main_inventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_main_inventory.Image = global::RAC_IMS.Properties.Resources.checklists_32px;
            this.btn_main_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_inventory.Location = new System.Drawing.Point(44, 294);
            this.btn_main_inventory.Name = "btn_main_inventory";
            this.btn_main_inventory.Size = new System.Drawing.Size(268, 51);
            this.btn_main_inventory.TabIndex = 6;
            this.btn_main_inventory.Text = "INVENTORY";
            this.btn_main_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_inventory.UseVisualStyleBackColor = false;
            this.btn_main_inventory.Click += new System.EventHandler(this.btn_main_inventory_Click);
            // 
            // pb_login_logo
            // 
            this.pb_login_logo.Image = global::RAC_IMS.Properties.Resources.brand_logo_200pxX172px;
            this.pb_login_logo.Location = new System.Drawing.Point(45, -12);
            this.pb_login_logo.Name = "pb_login_logo";
            this.pb_login_logo.Size = new System.Drawing.Size(268, 172);
            this.pb_login_logo.TabIndex = 4;
            this.pb_login_logo.TabStop = false;
            this.pb_login_logo.Click += new System.EventHandler(this.pb_login_logo_Click);
            // 
            // tc_main_inventory
            // 
            this.tc_main_inventory.Controls.Add(this.product_tab);
            this.tc_main_inventory.Controls.Add(this.suppliers_tab);
            this.tc_main_inventory.Controls.Add(this.materials_tab);
            this.tc_main_inventory.Controls.Add(this.orders_tab);
            this.tc_main_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main_inventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_main_inventory.Location = new System.Drawing.Point(356, 33);
            this.tc_main_inventory.Name = "tc_main_inventory";
            this.tc_main_inventory.SelectedIndex = 0;
            this.tc_main_inventory.Size = new System.Drawing.Size(834, 710);
            this.tc_main_inventory.TabIndex = 0;
            // 
            // product_tab
            // 
            this.product_tab.Location = new System.Drawing.Point(4, 29);
            this.product_tab.Name = "product_tab";
            this.product_tab.Padding = new System.Windows.Forms.Padding(3);
            this.product_tab.Size = new System.Drawing.Size(826, 677);
            this.product_tab.TabIndex = 0;
            this.product_tab.Text = "Products";
            this.product_tab.UseVisualStyleBackColor = true;
            this.product_tab.Click += new System.EventHandler(this.product_tab_Click);
            // 
            // suppliers_tab
            // 
            this.suppliers_tab.Location = new System.Drawing.Point(4, 29);
            this.suppliers_tab.Name = "suppliers_tab";
            this.suppliers_tab.Padding = new System.Windows.Forms.Padding(3);
            this.suppliers_tab.Size = new System.Drawing.Size(826, 678);
            this.suppliers_tab.TabIndex = 1;
            this.suppliers_tab.Text = "Suppliers";
            this.suppliers_tab.UseVisualStyleBackColor = true;
            // 
            // materials_tab
            // 
            this.materials_tab.Location = new System.Drawing.Point(4, 29);
            this.materials_tab.Name = "materials_tab";
            this.materials_tab.Size = new System.Drawing.Size(826, 678);
            this.materials_tab.TabIndex = 2;
            this.materials_tab.Text = "Materials";
            this.materials_tab.UseVisualStyleBackColor = true;
            // 
            // orders_tab
            // 
            this.orders_tab.Location = new System.Drawing.Point(4, 29);
            this.orders_tab.Name = "orders_tab";
            this.orders_tab.Size = new System.Drawing.Size(826, 678);
            this.orders_tab.TabIndex = 3;
            this.orders_tab.Text = "Orders";
            this.orders_tab.UseVisualStyleBackColor = true;
            // 
            // btn_main_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 743);
            this.Controls.Add(this.tc_main_inventory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btn_main_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btn_main_inventory_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).EndInit();
            this.tc_main_inventory.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage orders_tab;
    }
}