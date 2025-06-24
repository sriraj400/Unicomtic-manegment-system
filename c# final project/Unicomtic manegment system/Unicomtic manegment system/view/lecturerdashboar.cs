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
    public partial class lecturerdashboar : Form
    {

        private string currentUser;

        public lecturerdashboar(string username)
        {
            InitializeComponent();
            currentUser = username;

        }
        private void lecturerdashboar_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new lectureviews(currentUser));
        }
        private void LoadFormInPanel(Form form)
        {
            panelmainlecturer.Controls.Clear();                   // Panel clean
            form.TopLevel = false;                         // Child control-ஆ
            form.FormBorderStyle = FormBorderStyle.None;   // Border remove
            form.Dock = DockStyle.Fill;                    // Full panel-க்குள்ள fit
            form.AutoScaleMode = AutoScaleMode.None;       // Prevent auto resize mismatch
            panelmainlecturer.Controls.Add(form);
            form.Show();

        }
        //private void LoadFormInPanel(viewexame form)
        //{
        //    panelmainlecturer.Controls.Clear();                   // Panel clean
        //    form.TopLevel = false;                         // Child control-ஆ
        //    form.FormBorderStyle = FormBorderStyle.None;   // Border remove
        //    form.Dock = DockStyle.Fill;                    // Full panel-க்குள்ள fit
        //    form.AutoScaleMode = AutoScaleMode.None;       // Prevent auto resize mismatch
        //    panelmainlecturer.Controls.Add(form);
        //    form.Show();

        //}
        //private void LoadFormInPanel(viewcoursedetails form)
        //{
        //    panelmainlecturer.Controls.Clear();                   // Panel clean
        //    form.TopLevel = false;                         // Child control-ஆ
        //    form.FormBorderStyle = FormBorderStyle.None;   // Border remove
        //    form.Dock = DockStyle.Fill;                    // Full panel-க்குள்ள fit
        //    form.AutoScaleMode = AutoScaleMode.None;       // Prevent auto resize mismatch
        //    panelmainlecturer.Controls.Add(form);
        //    form.Show();

        //}
        //private void LoadFormInPanel(lectureviews form)
        //{
        //    panelmainlecturer.Controls.Clear();                   // Panel clean
        //    form.TopLevel = false;                         // Child control-ஆ
        //    form.FormBorderStyle = FormBorderStyle.None;   // Border remove
        //    form.Dock = DockStyle.Fill;                    // Full panel-க்குள்ள fit
        //    form.AutoScaleMode = AutoScaleMode.None;       // Prevent auto resize mismatch
        //    panelmainlecturer.Controls.Add(form);
        //    form.Show();

        //}

        private void btnstudent_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewstudent());
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewcoursedetails());
        }

        private void txtexame_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewexame());
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new lectureviews(currentUser));
        }

        private void btnlogoutlecturer_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Close();
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new viewtimtable());
        }
    }
}
