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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 571);
            this.panel1.TabIndex = 0;
            // 
            // pb_login_logo
            // 
            this.pb_login_logo.Image = global::RAC_IMS.Properties.Resources.brand_logo_200pxX172px;
            this.pb_login_logo.Location = new System.Drawing.Point(84, 103);
            this.pb_login_logo.Name = "pb_login_logo";
            this.pb_login_logo.Size = new System.Drawing.Size(268, 172);
            this.pb_login_logo.TabIndex = 3;
            this.pb_login_logo.TabStop = false;
            // 
            // lbl_login_inventorytext
            // 
            this.lbl_login_inventorytext.AutoSize = true;
            this.lbl_login_inventorytext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_inventorytext.ForeColor = System.Drawing.Color.White;
            this.lbl_login_inventorytext.Location = new System.Drawing.Point(46, 281);
            this.lbl_login_inventorytext.Name = "lbl_login_inventorytext";
            this.lbl_login_inventorytext.Size = new System.Drawing.Size(329, 24);
            this.lbl_login_inventorytext.TabIndex = 2;
            this.lbl_login_inventorytext.Text = "Inventory Management System";
            // 
            // btn_login_signup
            // 
            this.btn_login_signup.BackColor = System.Drawing.Color.Red;
            this.btn_login_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_signup.FlatAppearance.BorderSize = 0;
            this.btn_login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_signup.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_signup.ForeColor = System.Drawing.Color.White;
            this.btn_login_signup.Location = new System.Drawing.Point(59, 497);
            this.btn_login_signup.Name = "btn_login_signup";
            this.btn_login_signup.Size = new System.Drawing.Size(303, 44);
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
            this.lbl_login_registertext.Location = new System.Drawing.Point(109, 457);
            this.lbl_login_registertext.Name = "lbl_login_registertext";
            this.lbl_login_registertext.Size = new System.Drawing.Size(183, 22);
            this.lbl_login_registertext.TabIndex = 0;
            this.lbl_login_registertext.Text = "Register your Account";
            // 
            // lbl_login_acc
            // 
            this.lbl_login_acc.AutoSize = true;
            this.lbl_login_acc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_acc.Location = new System.Drawing.Point(461, 79);
            this.lbl_login_acc.Name = "lbl_login_acc";
            this.lbl_login_acc.Size = new System.Drawing.Size(175, 27);
            this.lbl_login_acc.TabIndex = 2;
            this.lbl_login_acc.Text = "Login Account";
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(462, 174);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(94, 22);
            this.lbl_login_username.TabIndex = 3;
            this.lbl_login_username.Text = "Username:";
            // 
            // txt_login_username
            // 
            this.txt_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_username.Location = new System.Drawing.Point(466, 211);
            this.txt_login_username.Multiline = true;
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(388, 40);
            this.txt_login_username.TabIndex = 4;
            // 
            // txt_login_password
            // 
            this.txt_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.Location = new System.Drawing.Point(466, 318);
            this.txt_login_password.Multiline = true;
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.PasswordChar = '*';
            this.txt_login_password.Size = new System.Drawing.Size(388, 40);
            this.txt_login_password.TabIndex = 6;
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(462, 281);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(90, 22);
            this.lbl_login_password.TabIndex = 5;
            this.lbl_login_password.Text = "Password:";
            // 
            // chk_login_showpassword
            // 
            this.chk_login_showpassword.AutoSize = true;
            this.chk_login_showpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_login_showpassword.Location = new System.Drawing.Point(724, 377);
            this.chk_login_showpassword.Name = "chk_login_showpassword";
            this.chk_login_showpassword.Size = new System.Drawing.Size(130, 22);
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
            this.btn_login_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_login.ForeColor = System.Drawing.Color.White;
            this.btn_login_login.Location = new System.Drawing.Point(466, 410);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(110, 42);
            this.btn_login_login.TabIndex = 8;
            this.btn_login_login.Text = "LOGIN";
            this.btn_login_login.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 571);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.chk_login_showpassword);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.txt_login_username);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.lbl_login_acc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

