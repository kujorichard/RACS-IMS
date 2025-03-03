namespace RAC_IMS.Main_Panel
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_order_customerName = new System.Windows.Forms.TextBox();
            this.txt_order_qty = new System.Windows.Forms.TextBox();
            this.cmb_order_price_type = new System.Windows.Forms.ComboBox();
            this.btn_order_cancel = new System.Windows.Forms.Button();
            this.btn_order_finish = new System.Windows.Forms.Button();
            this.btn_order_add_item = new System.Windows.Forms.Button();
            this.btn_order_remove_item = new System.Windows.Forms.Button();
            this.dgv_order_products_selected = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_products_selected)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD ORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(17, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // txt_order_customerName
            // 
            this.txt_order_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_customerName.Location = new System.Drawing.Point(204, 42);
            this.txt_order_customerName.Multiline = true;
            this.txt_order_customerName.Name = "txt_order_customerName";
            this.txt_order_customerName.Size = new System.Drawing.Size(556, 33);
            this.txt_order_customerName.TabIndex = 5;
            // 
            // txt_order_qty
            // 
            this.txt_order_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_qty.Location = new System.Drawing.Point(204, 138);
            this.txt_order_qty.Multiline = true;
            this.txt_order_qty.Name = "txt_order_qty";
            this.txt_order_qty.Size = new System.Drawing.Size(61, 33);
            this.txt_order_qty.TabIndex = 7;
            // 
            // cmb_order_price_type
            // 
            this.cmb_order_price_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_order_price_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_order_price_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_order_price_type.FormattingEnabled = true;
            this.cmb_order_price_type.Items.AddRange(new object[] {
            "Wholesale",
            "Reseller",
            "Retail"});
            this.cmb_order_price_type.Location = new System.Drawing.Point(204, 180);
            this.cmb_order_price_type.Name = "cmb_order_price_type";
            this.cmb_order_price_type.Size = new System.Drawing.Size(177, 32);
            this.cmb_order_price_type.TabIndex = 8;
            // 
            // btn_order_cancel
            // 
            this.btn_order_cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_order_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_order_cancel.Location = new System.Drawing.Point(626, 157);
            this.btn_order_cancel.Name = "btn_order_cancel";
            this.btn_order_cancel.Size = new System.Drawing.Size(162, 50);
            this.btn_order_cancel.TabIndex = 9;
            this.btn_order_cancel.Text = "CANCEL ORDER";
            this.btn_order_cancel.UseVisualStyleBackColor = false;
            this.btn_order_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_order_finish
            // 
            this.btn_order_finish.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_order_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_finish.ForeColor = System.Drawing.Color.White;
            this.btn_order_finish.Location = new System.Drawing.Point(626, 215);
            this.btn_order_finish.Name = "btn_order_finish";
            this.btn_order_finish.Size = new System.Drawing.Size(162, 45);
            this.btn_order_finish.TabIndex = 10;
            this.btn_order_finish.Text = "FINISH ORDER";
            this.btn_order_finish.UseVisualStyleBackColor = false;
            this.btn_order_finish.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_order_add_item
            // 
            this.btn_order_add_item.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_order_add_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_add_item.ForeColor = System.Drawing.Color.White;
            this.btn_order_add_item.Location = new System.Drawing.Point(18, 228);
            this.btn_order_add_item.Name = "btn_order_add_item";
            this.btn_order_add_item.Size = new System.Drawing.Size(147, 32);
            this.btn_order_add_item.TabIndex = 12;
            this.btn_order_add_item.Text = "ADD ITEM";
            this.btn_order_add_item.UseVisualStyleBackColor = false;
            this.btn_order_add_item.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_order_remove_item
            // 
            this.btn_order_remove_item.BackColor = System.Drawing.Color.Firebrick;
            this.btn_order_remove_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_remove_item.ForeColor = System.Drawing.Color.White;
            this.btn_order_remove_item.Location = new System.Drawing.Point(184, 228);
            this.btn_order_remove_item.Name = "btn_order_remove_item";
            this.btn_order_remove_item.Size = new System.Drawing.Size(147, 32);
            this.btn_order_remove_item.TabIndex = 13;
            this.btn_order_remove_item.Text = "REMOVE ITEM";
            this.btn_order_remove_item.UseVisualStyleBackColor = false;
            // 
            // dgv_order_products_selected
            // 
            this.dgv_order_products_selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order_products_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_products_selected.Location = new System.Drawing.Point(18, 266);
            this.dgv_order_products_selected.Name = "dgv_order_products_selected";
            this.dgv_order_products_selected.Size = new System.Drawing.Size(770, 231);
            this.dgv_order_products_selected.TabIndex = 14;
            this.dgv_order_products_selected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderForm_Load_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 33);
            this.textBox1.TabIndex = 15;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_order_products_selected);
            this.Controls.Add(this.btn_order_remove_item);
            this.Controls.Add(this.btn_order_add_item);
            this.Controls.Add(this.btn_order_finish);
            this.Controls.Add(this.btn_order_cancel);
            this.Controls.Add(this.cmb_order_price_type);
            this.Controls.Add(this.txt_order_qty);
            this.Controls.Add(this.txt_order_customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_products_selected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_order_customerName;
        private System.Windows.Forms.TextBox txt_order_qty;
        private System.Windows.Forms.ComboBox cmb_order_price_type;
        private System.Windows.Forms.Button btn_order_cancel;
        private System.Windows.Forms.Button btn_order_finish;
        private System.Windows.Forms.Button btn_order_add_item;
        private System.Windows.Forms.Button btn_order_remove_item;
        private System.Windows.Forms.DataGridView dgv_order_products_selected;
        private System.Windows.Forms.TextBox textBox1;
    }
}