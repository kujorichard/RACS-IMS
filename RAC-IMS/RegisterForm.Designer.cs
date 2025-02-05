namespace RAC_IMS
{
    partial class RegisterForm
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
            this.btn_register_register = new System.Windows.Forms.Button();
            this.chk_register_showpassword = new System.Windows.Forms.CheckBox();
            this.txt_register_password = new System.Windows.Forms.TextBox();
            this.lbl_register_password = new System.Windows.Forms.Label();
            this.txt_register_username = new System.Windows.Forms.TextBox();
            this.lbl_register_username = new System.Windows.Forms.Label();
            this.lbl_register_acc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_register_logo = new System.Windows.Forms.PictureBox();
            this.lbl_register_inventorytext = new System.Windows.Forms.Label();
            this.btn_register_signin = new System.Windows.Forms.Button();
            this.lbl_register_signintext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register_register
            // 
            this.btn_register_register.BackColor = System.Drawing.Color.Red;
            this.btn_register_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register_register.FlatAppearance.BorderSize = 0;
            this.btn_register_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register_register.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_register.ForeColor = System.Drawing.Color.White;
            this.btn_register_register.Location = new System.Drawing.Point(486, 410);
            this.btn_register_register.Name = "btn_register_register";
            this.btn_register_register.Size = new System.Drawing.Size(110, 42);
            this.btn_register_register.TabIndex = 16;
            this.btn_register_register.Text = "SIGN UP";
            this.btn_register_register.UseVisualStyleBackColor = false;
            // 
            // chk_register_showpassword
            // 
            this.chk_register_showpassword.AutoSize = true;
            this.chk_register_showpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_register_showpassword.Location = new System.Drawing.Point(744, 377);
            this.chk_register_showpassword.Name = "chk_register_showpassword";
            this.chk_register_showpassword.Size = new System.Drawing.Size(130, 22);
            this.chk_register_showpassword.TabIndex = 15;
            this.chk_register_showpassword.Text = "Show Password";
            this.chk_register_showpassword.UseVisualStyleBackColor = true;
            this.chk_register_showpassword.CheckedChanged += new System.EventHandler(this.chk_register_showpassword_CheckedChanged);
            // 
            // txt_register_password
            // 
            this.txt_register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_register_password.Location = new System.Drawing.Point(486, 318);
            this.txt_register_password.Multiline = true;
            this.txt_register_password.Name = "txt_register_password";
            this.txt_register_password.PasswordChar = '*';
            this.txt_register_password.Size = new System.Drawing.Size(388, 40);
            this.txt_register_password.TabIndex = 14;
            // 
            // lbl_register_password
            // 
            this.lbl_register_password.AutoSize = true;
            this.lbl_register_password.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_password.Location = new System.Drawing.Point(482, 281);
            this.lbl_register_password.Name = "lbl_register_password";
            this.lbl_register_password.Size = new System.Drawing.Size(90, 22);
            this.lbl_register_password.TabIndex = 13;
            this.lbl_register_password.Text = "Password:";
            // 
            // txt_register_username
            // 
            this.txt_register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_register_username.Location = new System.Drawing.Point(486, 211);
            this.txt_register_username.Multiline = true;
            this.txt_register_username.Name = "txt_register_username";
            this.txt_register_username.Size = new System.Drawing.Size(388, 40);
            this.txt_register_username.TabIndex = 12;
            // 
            // lbl_register_username
            // 
            this.lbl_register_username.AutoSize = true;
            this.lbl_register_username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_username.Location = new System.Drawing.Point(482, 174);
            this.lbl_register_username.Name = "lbl_register_username";
            this.lbl_register_username.Size = new System.Drawing.Size(94, 22);
            this.lbl_register_username.TabIndex = 11;
            this.lbl_register_username.Text = "Username:";
            // 
            // lbl_register_acc
            // 
            this.lbl_register_acc.AutoSize = true;
            this.lbl_register_acc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_acc.Location = new System.Drawing.Point(481, 79);
            this.lbl_register_acc.Name = "lbl_register_acc";
            this.lbl_register_acc.Size = new System.Drawing.Size(208, 27);
            this.lbl_register_acc.TabIndex = 10;
            this.lbl_register_acc.Text = "Register Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pb_register_logo);
            this.panel1.Controls.Add(this.lbl_register_inventorytext);
            this.panel1.Controls.Add(this.btn_register_signin);
            this.panel1.Controls.Add(this.lbl_register_signintext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 571);
            this.panel1.TabIndex = 9;
            // 
            // pb_register_logo
            // 
            this.pb_register_logo.Image = global::RAC_IMS.Properties.Resources.brand_logo_200pxX172px;
            this.pb_register_logo.Location = new System.Drawing.Point(84, 103);
            this.pb_register_logo.Name = "pb_register_logo";
            this.pb_register_logo.Size = new System.Drawing.Size(268, 172);
            this.pb_register_logo.TabIndex = 3;
            this.pb_register_logo.TabStop = false;
            // 
            // lbl_register_inventorytext
            // 
            this.lbl_register_inventorytext.AutoSize = true;
            this.lbl_register_inventorytext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_inventorytext.ForeColor = System.Drawing.Color.White;
            this.lbl_register_inventorytext.Location = new System.Drawing.Point(46, 281);
            this.lbl_register_inventorytext.Name = "lbl_register_inventorytext";
            this.lbl_register_inventorytext.Size = new System.Drawing.Size(329, 24);
            this.lbl_register_inventorytext.TabIndex = 2;
            this.lbl_register_inventorytext.Text = "Inventory Management System";
            // 
            // btn_register_signin
            // 
            this.btn_register_signin.BackColor = System.Drawing.Color.Red;
            this.btn_register_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register_signin.FlatAppearance.BorderSize = 0;
            this.btn_register_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register_signin.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_signin.ForeColor = System.Drawing.Color.White;
            this.btn_register_signin.Location = new System.Drawing.Point(59, 497);
            this.btn_register_signin.Name = "btn_register_signin";
            this.btn_register_signin.Size = new System.Drawing.Size(303, 44);
            this.btn_register_signin.TabIndex = 1;
            this.btn_register_signin.Text = "SIGN IN";
            this.btn_register_signin.UseVisualStyleBackColor = false;
            this.btn_register_signin.Click += new System.EventHandler(this.btn_register_signin_Click);
            // 
            // lbl_register_signintext
            // 
            this.lbl_register_signintext.AutoSize = true;
            this.lbl_register_signintext.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_signintext.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_register_signintext.Location = new System.Drawing.Point(98, 456);
            this.lbl_register_signintext.Name = "lbl_register_signintext";
            this.lbl_register_signintext.Size = new System.Drawing.Size(212, 22);
            this.lbl_register_signintext.TabIndex = 0;
            this.lbl_register_signintext.Text = "Already have an account?";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 571);
            this.Controls.Add(this.btn_register_register);
            this.Controls.Add(this.chk_register_showpassword);
            this.Controls.Add(this.txt_register_password);
            this.Controls.Add(this.lbl_register_password);
            this.Controls.Add(this.txt_register_username);
            this.Controls.Add(this.lbl_register_username);
            this.Controls.Add(this.lbl_register_acc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register_register;
        private System.Windows.Forms.CheckBox chk_register_showpassword;
        private System.Windows.Forms.TextBox txt_register_password;
        private System.Windows.Forms.Label lbl_register_password;
        private System.Windows.Forms.TextBox txt_register_username;
        private System.Windows.Forms.Label lbl_register_username;
        private System.Windows.Forms.Label lbl_register_acc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_register_logo;
        private System.Windows.Forms.Label lbl_register_inventorytext;
        private System.Windows.Forms.Button btn_register_signin;
        private System.Windows.Forms.Label lbl_register_signintext;
    }
}