using System;
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
using MongoDB.Bson;
using MongoDB.Driver;
using System.Drawing.Text;

namespace RAC_IMS
{
    public partial class RegisterForm : Form
    {
        private readonly MongoDBService mongoDBService;
        private readonly UserService userService;
        public RegisterForm()
        {
            InitializeComponent();
            string connectionUri = "mongodb://localhost:27017";
            string databaseName = "RACS_IMS";

            this.AcceptButton = btn_register_register;

            mongoDBService = new MongoDBService(connectionUri, databaseName);
            userService = new UserService(mongoDBService);
        }

        private void btn_register_signin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chk_register_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_register_password.PasswordChar = chk_register_showpassword.Checked ? '\0' : '*';
        }

        private async void btn_register_register_Click(object sender, EventArgs e)
        {
            string username = txt_register_username.Text.Trim();
            string password = txt_register_password.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists
            bool usernameExists = await userService.UsernameExists(username);
            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and insert new user
            User user = new User
            {
                username = username,
                password = password
            };

            await userService.InsertUser(user);
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            BackToLogin();
        }
        private void BackToLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ClearFields()
        {
            txt_register_username.Text = "";
            txt_register_password.Text = "";    
        }
    }
}
