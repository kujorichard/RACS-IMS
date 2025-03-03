namespace RAC_IMS.Main_Panel
{
    partial class OrderReceiptForm
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
            this.dgv_order_products_ordered = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_order_customer_name = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.lbl_order_status = new System.Windows.Forms.Label();
            this.btn_orders_complete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_order_total_price = new System.Windows.Forms.Label();
            this.lbl_order_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_products_ordered)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date ordered: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Products purchased:";
            // 
            // dgv_order_products_ordered
            // 
            this.dgv_order_products_ordered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order_products_ordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_products_ordered.Location = new System.Drawing.Point(17, 168);
            this.dgv_order_products_ordered.Name = "dgv_order_products_ordered";
            this.dgv_order_products_ordered.Size = new System.Drawing.Size(771, 197);
            this.dgv_order_products_ordered.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status: ";
            // 
            // lbl_order_customer_name
            // 
            this.lbl_order_customer_name.AutoSize = true;
            this.lbl_order_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_customer_name.Location = new System.Drawing.Point(178, 18);
            this.lbl_order_customer_name.Name = "lbl_order_customer_name";
            this.lbl_order_customer_name.Size = new System.Drawing.Size(154, 25);
            this.lbl_order_customer_name.TabIndex = 5;
            this.lbl_order_customer_name.Text = "Customer Name";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(156, 56);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(53, 25);
            this.lbl_order_date.TabIndex = 6;
            this.lbl_order_date.Text = "Date";
            // 
            // lbl_order_status
            // 
            this.lbl_order_status.AutoSize = true;
            this.lbl_order_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_status.Location = new System.Drawing.Point(90, 94);
            this.lbl_order_status.Name = "lbl_order_status";
            this.lbl_order_status.Size = new System.Drawing.Size(68, 25);
            this.lbl_order_status.TabIndex = 7;
            this.lbl_order_status.Text = "Status";
            // 
            // btn_orders_complete
            // 
            this.btn_orders_complete.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_orders_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders_complete.Location = new System.Drawing.Point(665, 35);
            this.btn_orders_complete.Name = "btn_orders_complete";
            this.btn_orders_complete.Size = new System.Drawing.Size(123, 35);
            this.btn_orders_complete.TabIndex = 8;
            this.btn_orders_complete.Text = "COMPLETED";
            this.btn_orders_complete.UseVisualStyleBackColor = false;
            this.btn_orders_complete.Click += new System.EventHandler(this.btn_orders_complete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(665, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "PENDING";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Set Status:";
            // 
            // lbl_order_total_price
            // 
            this.lbl_order_total_price.AutoSize = true;
            this.lbl_order_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_total_price.Location = new System.Drawing.Point(329, 130);
            this.lbl_order_total_price.Name = "lbl_order_total_price";
            this.lbl_order_total_price.Size = new System.Drawing.Size(119, 25);
            this.lbl_order_total_price.TabIndex = 11;
            this.lbl_order_total_price.Text = "Total price:";
            // 
            // lbl_order_price
            // 
            this.lbl_order_price.AutoSize = true;
            this.lbl_order_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_price.Location = new System.Drawing.Point(445, 130);
            this.lbl_order_price.Name = "lbl_order_price";
            this.lbl_order_price.Size = new System.Drawing.Size(56, 25);
            this.lbl_order_price.TabIndex = 12;
            this.lbl_order_price.Text = "Price";
            // 
            // OrderReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.lbl_order_price);
            this.Controls.Add(this.lbl_order_total_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_orders_complete);
            this.Controls.Add(this.lbl_order_status);
            this.Controls.Add(this.lbl_order_date);
            this.Controls.Add(this.lbl_order_customer_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_order_products_ordered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderReceiptForm";
            this.Text = "Order Receipt";
            this.Load += new System.EventHandler(this.OrderReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_products_ordered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_order_products_ordered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_order_customer_name;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.Label lbl_order_status;
        private System.Windows.Forms.Button btn_orders_complete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_order_total_price;
        private System.Windows.Forms.Label lbl_order_price;
    }
}