using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.controller;

namespace Unicomtic_manegment_system.view
{
    public partial class loginaddmin : Form
    {
        private LoginadminController loginController;

        public loginaddmin()
        {
            InitializeComponent();
            loginController = new LoginadminController();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtadminusername.Text.Trim();
            string password = txtadminpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = loginController.ValidateLogin(username, password);

            if (isValid)
            {
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open your admin dashboard form or next form here
                // Example:
                admindashboard dashboard = new admindashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            second second = new second();

            second.Show();
            this.Hide();
        }

        private void txtadminusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

