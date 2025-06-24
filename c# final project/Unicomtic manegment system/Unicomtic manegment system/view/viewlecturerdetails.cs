using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;

namespace Unicomtic_manegment_system.view
{
    public partial class viewlecturerdetails : Form
    {
        public viewlecturerdetails()
        {
            InitializeComponent();
            LoadLecturers();
        }

        private void viewlecturerdetails_Load(object sender, EventArgs e)
        {

        }
        private void LoadLecturers()
        {
            var lecturers = controller.GetAllLecturers();
            dataGridViewlec.DataSource = lecturers;
        }
        private lecturecontoler controller = new lecturecontoler();
    }

}
