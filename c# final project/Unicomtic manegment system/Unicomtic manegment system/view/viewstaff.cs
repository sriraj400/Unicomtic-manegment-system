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
    public partial class viewstaff : Form
    {
        public viewstaff()
        {
            InitializeComponent();
            LoadStaffs();
        }

        private void viewstaff_Load(object sender, EventArgs e)
        {

        }
        private void LoadStaffs()
        {
            dataGridVie4.DataSource = null;
            dataGridVie4.DataSource = staffController.GetAllStaff();
        }
        private staffcontoler staffController = new staffcontoler();
    }
}
