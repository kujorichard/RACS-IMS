using RAC_IMS.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAC_IMS.Backend.ObjectServices;
using RAC_IMS.Backend.ObjectModels;
using RAC_IMS.Main_Panel;

namespace RAC_IMS
{
    public partial class LoginForm : Form
    {
        private readonly MongoDBService mongoDBService;
        private readonly UserService userService;
        public LoginForm()
        {
            InitializeComponent();
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";

            this.AcceptButton = btn_login_login;

            mongoDBService = new MongoDBService(connectionUri, databaseName);
            userService = new UserService(mongoDBService);  
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_login_password.PasswordChar = chk_login_showpassword.Checked ? '\0' : '*';
        }

        private void btn_login_signup_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void btn_login_login_Click(object sender, EventArgs e)
        {
            string username = txt_login_username.Text.Trim();
            string password = txt_login_password.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to login
            User user = await userService.LoginUser(username, password);

            if (user != null)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
