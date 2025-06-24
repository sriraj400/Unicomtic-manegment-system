using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicomtic_manegment_system.view
{
    public partial class Studendashboard : Form
    {
        private string currentUser;
        private string loggedStudent;


        public Studendashboard(string username, string utNumber)
        {
            InitializeComponent();
            currentUser = username;
            loggedStudent = utNumber;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Studendashboard_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new studentdashboardview(currentUser, loggedStudent));
        }
        private void LoadFormInPanel(Form form)
        {
            panelmainstu.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmainstu.Controls.Add(form);
            form.Show();
        }


        private void btndashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new studentdashboardview(currentUser, loggedStudent));
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {

        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewcoursedetails());
        }

        private void txtexame_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewexame());
        }
        private void btntimetable_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewtimtable());
        }

        private void btnlecture_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewlecturerdetails());
        }

        private void btnlogoutstudash_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Close();
        }

        private void btnviewfeedback_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Addfeedback());
        }

        private void panelmainstu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
