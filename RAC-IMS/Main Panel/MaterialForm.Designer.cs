namespace RAC_IMS.Main_Panel
{
    partial class MaterialForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_products_material = new System.Windows.Forms.ComboBox();
            this.txt_products_material_quantity = new System.Windows.Forms.TextBox();
            this.btn_products_add_material = new System.Windows.Forms.Button();
            this.btn_products_rem_material = new System.Windows.Forms.Button();
            this.btn_products_cancel_material = new System.Windows.Forms.Button();
            this.btn_products_save_material = new System.Windows.Forms.Button();
            this.cmb_products_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 131);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmb_products_material
            // 
            this.cmb_products_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_products_material.FormattingEnabled = true;
            this.cmb_products_material.Location = new System.Drawing.Point(189, 58);
            this.cmb_products_material.Name = "cmb_products_material";
            this.cmb_products_material.Size = new System.Drawing.Size(415, 32);
            this.cmb_products_material.TabIndex = 4;
            // 
            // txt_products_material_quantity
            // 
            this.txt_products_material_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_products_material_quantity.Location = new System.Drawing.Point(189, 102);
            this.txt_products_material_quantity.Multiline = true;
            this.txt_products_material_quantity.Name = "txt_products_material_quantity";
            this.txt_products_material_quantity.Size = new System.Drawing.Size(94, 34);
            this.txt_products_material_quantity.TabIndex = 5;
            // 
            // btn_products_add_material
            // 
            this.btn_products_add_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_products_add_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_add_material.ForeColor = System.Drawing.Color.Black;
            this.btn_products_add_material.Location = new System.Drawing.Point(18, 149);
            this.btn_products_add_material.Name = "btn_products_add_material";
            this.btn_products_add_material.Size = new System.Drawing.Size(143, 29);
            this.btn_products_add_material.TabIndex = 6;
            this.btn_products_add_material.Text = "Add Material";
            this.btn_products_add_material.UseVisualStyleBackColor = false;
            // 
            // btn_products_rem_material
            // 
            this.btn_products_rem_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_products_rem_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_rem_material.ForeColor = System.Drawing.Color.Black;
            this.btn_products_rem_material.Location = new System.Drawing.Point(177, 149);
            this.btn_products_rem_material.Name = "btn_products_rem_material";
            this.btn_products_rem_material.Size = new System.Drawing.Size(172, 29);
            this.btn_products_rem_material.TabIndex = 7;
            this.btn_products_rem_material.Text = "Remove Material";
            this.btn_products_rem_material.UseVisualStyleBackColor = false;
            // 
            // btn_products_cancel_material
            // 
            this.btn_products_cancel_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_products_cancel_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_cancel_material.ForeColor = System.Drawing.Color.Black;
            this.btn_products_cancel_material.Location = new System.Drawing.Point(448, 149);
            this.btn_products_cancel_material.Name = "btn_products_cancel_material";
            this.btn_products_cancel_material.Size = new System.Drawing.Size(88, 29);
            this.btn_products_cancel_material.TabIndex = 8;
            this.btn_products_cancel_material.Text = "Cancel";
            this.btn_products_cancel_material.UseVisualStyleBackColor = false;
            this.btn_products_cancel_material.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_products_save_material
            // 
            this.btn_products_save_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_products_save_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_save_material.ForeColor = System.Drawing.Color.Black;
            this.btn_products_save_material.Location = new System.Drawing.Point(542, 149);
            this.btn_products_save_material.Name = "btn_products_save_material";
            this.btn_products_save_material.Size = new System.Drawing.Size(88, 29);
            this.btn_products_save_material.TabIndex = 9;
            this.btn_products_save_material.Text = "Save";
            this.btn_products_save_material.UseVisualStyleBackColor = false;
            this.btn_products_save_material.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmb_products_name
            // 
            this.cmb_products_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_products_name.FormattingEnabled = true;
            this.cmb_products_name.Location = new System.Drawing.Point(189, 12);
            this.cmb_products_name.Name = "cmb_products_name";
            this.cmb_products_name.Size = new System.Drawing.Size(415, 32);
            this.cmb_products_name.TabIndex = 10;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(642, 327);
            this.Controls.Add(this.cmb_products_name);
            this.Controls.Add(this.btn_products_save_material);
            this.Controls.Add(this.btn_products_cancel_material);
            this.Controls.Add(this.btn_products_rem_material);
            this.Controls.Add(this.btn_products_add_material);
            this.Controls.Add(this.txt_products_material_quantity);
            this.Controls.Add(this.cmb_products_material);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_products_material;
        private System.Windows.Forms.TextBox txt_products_material_quantity;
        private System.Windows.Forms.Button btn_products_add_material;
        private System.Windows.Forms.Button btn_products_rem_material;
        private System.Windows.Forms.Button btn_products_cancel_material;
        private System.Windows.Forms.Button btn_products_save_material;
        private System.Windows.Forms.ComboBox cmb_products_name;
    }
}