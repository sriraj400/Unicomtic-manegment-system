using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new admindashboardview());
        }
        private void LoadFormInPanel(studentadd form)
        {
            panelmaina.Controls.Clear();                   // Panel clean
            form.TopLevel = false;                         // Child control-ஆ
            form.FormBorderStyle = FormBorderStyle.None;   // Border remove
            form.Dock = DockStyle.Fill;                    // Full panel-க்குள்ள fit
            form.AutoScaleMode = AutoScaleMode.None;       // Prevent auto resize mismatch
            panelmaina.Controls.Add(form);
            form.Show();

        }
        private void LoadFormInPanel(l form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(staffadd form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(course form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(exame form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(timetable form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(feedback form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(Subject form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }

        private void LoadFormInPanel(Room form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;  // ✅ Fix: Set this to false
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }

        private void LoadFormInPanel(admindashboardview form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }
        private void LoadFormInPanel(Attandance form)
        {
            panelmaina.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            panelmaina.Controls.Add(form);
            form.Show();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new studentadd());
        }

        private void btnlecture_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new l());
        }



        private void btnstaff_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new staffadd());
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new course());
        }

        private void txtexame_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new exame());
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new timetable());
        }

        private void btnviewfeedback_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new feedback());
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new admindashboardview());

        }

        private void btnsuba_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Subject());
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Room());

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loginaddmin loginaddmin = new loginaddmin();
            loginaddmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Attandance());
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            Usersigninu usersigninu = new Usersigninu();
            usersigninu.Show();
            this.Hide();
        }

        //private void btnviewdts_Click(object sender, EventArgs e)
        //{
        //    LoadFormInPanel(new studentadd());
        //}
    }
}
