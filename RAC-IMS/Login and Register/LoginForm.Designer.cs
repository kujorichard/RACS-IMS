namespace RAC_IMS
{
    partial class LoginForm
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
            this.pb_login_logo = new System.Windows.Forms.PictureBox();
            this.lbl_login_inventorytext = new System.Windows.Forms.Label();
            this.btn_login_signup = new System.Windows.Forms.Button();
            this.lbl_login_registertext = new System.Windows.Forms.Label();
            this.lbl_login_acc = new System.Windows.Forms.Label();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.chk_login_showpassword = new System.Windows.Forms.CheckBox();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pb_login_logo);
            this.panel1.Controls.Add(this.lbl_login_inventorytext);
            this.panel1.Controls.Add(this.btn_login_signup);
            this.panel1.Controls.Add(this.lbl_login_registertext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 464);
            this.panel1.TabIndex = 0;
            // 
            // pb_login_logo
            // 
            this.pb_login_logo.Image = global::RAC_IMS.Properties.Resources.brand_logo_200pxX172px;
            this.pb_login_logo.Location = new System.Drawing.Point(63, 84);
            this.pb_login_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_login_logo.Name = "pb_login_logo";
            this.pb_login_logo.Size = new System.Drawing.Size(201, 140);
            this.pb_login_logo.TabIndex = 3;
            this.pb_login_logo.TabStop = false;
            // 
            // lbl_login_inventorytext
            // 
            this.lbl_login_inventorytext.AutoSize = true;
            this.lbl_login_inventorytext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_inventorytext.ForeColor = System.Drawing.Color.White;
            this.lbl_login_inventorytext.Location = new System.Drawing.Point(34, 228);
            this.lbl_login_inventorytext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_inventorytext.Name = "lbl_login_inventorytext";
            this.lbl_login_inventorytext.Size = new System.Drawing.Size(263, 19);
            this.lbl_login_inventorytext.TabIndex = 2;
            this.lbl_login_inventorytext.Text = "Inventory Management System";
            // 
            // btn_login_signup
            // 
            this.btn_login_signup.BackColor = System.Drawing.Color.Red;
            this.btn_login_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_signup.FlatAppearance.BorderSize = 0;
            this.btn_login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_signup.ForeColor = System.Drawing.Color.White;
            this.btn_login_signup.Location = new System.Drawing.Point(44, 404);
            this.btn_login_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login_signup.Name = "btn_login_signup";
            this.btn_login_signup.Size = new System.Drawing.Size(227, 36);
            this.btn_login_signup.TabIndex = 1;
            this.btn_login_signup.Text = "SIGN UP";
            this.btn_login_signup.UseVisualStyleBackColor = false;
            this.btn_login_signup.Click += new System.EventHandler(this.btn_login_signup_Click);
            // 
            // lbl_login_registertext
            // 
            this.lbl_login_registertext.AutoSize = true;
            this.lbl_login_registertext.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_registertext.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_login_registertext.Location = new System.Drawing.Point(82, 371);
            this.lbl_login_registertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_registertext.Name = "lbl_login_registertext";
            this.lbl_login_registertext.Size = new System.Drawing.Size(151, 18);
            this.lbl_login_registertext.TabIndex = 0;
            this.lbl_login_registertext.Text = "Register your Account";
            // 
            // lbl_login_acc
            // 
            this.lbl_login_acc.AutoSize = true;
            this.lbl_login_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_acc.Location = new System.Drawing.Point(346, 64);
            this.lbl_login_acc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_acc.Name = "lbl_login_acc";
            this.lbl_login_acc.Size = new System.Drawing.Size(132, 24);
            this.lbl_login_acc.TabIndex = 2;
            this.lbl_login_acc.Text = "Login Account";
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(346, 141);
            this.lbl_login_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(80, 18);
            this.lbl_login_username.TabIndex = 3;
            this.lbl_login_username.Text = "Username:";
            // 
            // txt_login_username
            // 
            this.txt_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_username.Location = new System.Drawing.Point(350, 171);
            this.txt_login_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_login_username.Multiline = true;
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(292, 33);
            this.txt_login_username.TabIndex = 4;
            // 
            // txt_login_password
            // 
            this.txt_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.Location = new System.Drawing.Point(350, 258);
            this.txt_login_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_login_password.Multiline = true;
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.PasswordChar = '*';
            this.txt_login_password.Size = new System.Drawing.Size(292, 33);
            this.txt_login_password.TabIndex = 6;
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(346, 228);
            this.lbl_login_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(74, 18);
            this.lbl_login_password.TabIndex = 5;
            this.lbl_login_password.Text = "Password:";
            // 
            // chk_login_showpassword
            // 
            this.chk_login_showpassword.AutoSize = true;
            this.chk_login_showpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_login_showpassword.Location = new System.Drawing.Point(543, 306);
            this.chk_login_showpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_login_showpassword.Name = "chk_login_showpassword";
            this.chk_login_showpassword.Size = new System.Drawing.Size(112, 18);
            this.chk_login_showpassword.TabIndex = 7;
            this.chk_login_showpassword.Text = "Show Password";
            this.chk_login_showpassword.UseVisualStyleBackColor = true;
            this.chk_login_showpassword.CheckedChanged += new System.EventHandler(this.chk_showpassword_CheckedChanged);
            // 
            // btn_login_login
            // 
            this.btn_login_login.BackColor = System.Drawing.Color.Red;
            this.btn_login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_login.FlatAppearance.BorderSize = 0;
            this.btn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_login.ForeColor = System.Drawing.Color.White;
            this.btn_login_login.Location = new System.Drawing.Point(350, 333);
            this.btn_login_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(82, 34);
            this.btn_login_login.TabIndex = 8;
            this.btn_login_login.Text = "LOGIN";
            this.btn_login_login.UseVisualStyleBackColor = false;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 464);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.chk_login_showpassword);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.txt_login_username);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.lbl_login_acc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_login_acc;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.CheckBox chk_login_showpassword;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Label lbl_login_registertext;
        private System.Windows.Forms.Button btn_login_signup;
        private System.Windows.Forms.Label lbl_login_inventorytext;
        private System.Windows.Forms.PictureBox pb_login_logo;
    }
}

