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
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class viewstudent : Form
    {
        public viewstudent()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void viewstudent_Load(object sender, EventArgs e)
        {

        }
        private void LoadStudents()
        {
            List<Student> students = studentController.GetAllStudents();
            dataGridViewstu.DataSource = students;
        }
        private readonly StudentController studentController = new StudentController();
    }
}
