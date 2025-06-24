using System;
using System.Windows.Forms;
using Unicomtic_manegment_system.view;

namespace Unicomtic_manegment_system.view
{
    public partial class Staffdashboard : Form
    {
        private string loggedUser;

        public Staffdashboard(string username)
        {
            InitializeComponent();
            loggedUser = username;
        }

        private void Staffdashboard_Load(object sender, EventArgs e)
        {
            // ✅ Load staff view by default
            LoadFormInPanel(new staffdashboardview(loggedUser));
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




        private void btnlecture_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewlecturerdetails());
        }

        private void btncourse_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewcoursedetails());
        }

        private void txtexame_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewexame());
        }

        private void btntimetable_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewtimtable());
        }

        private void btnviewfeedback_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new feedback());
        }

        private void btnstudent_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewstudent());
        }

        private void btndashboard_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffdashboardview(loggedUser));
        }

        private void btnlogoutstaff_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Close();   
        }
    }
}
