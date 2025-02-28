using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAC_IMS.Main_Panel
{
    public partial class btn_main_panel : Form
    {
        public btn_main_panel()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pb_login_logo_Click(object sender, EventArgs e)
        {

        }

        private void btn_main_inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_main_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirm Logout",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void lbl_login_acc_Click(object sender, EventArgs e)
        {

        }

        private void btn_main_inventory_Click(object sender, EventArgs e)
        {
            tc_main_inventory.Visible = true;
        }

        private void btn_main_sales_Click(object sender, EventArgs e)
        {
            tc_main_inventory.Visible = false;
        }

        private void product_tab_Click(object sender, EventArgs e)
        {

        }
    }
}
