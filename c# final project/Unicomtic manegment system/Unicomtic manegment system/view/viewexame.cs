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
    public partial class viewexame : Form
    {
        private object markController;

        public viewexame()
        {
            InitializeComponent();
            LoadUtMarks();
        }

        private void vieweExame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewexame_Load(object sender, EventArgs e)
        {

        }
        private UtMarkController UtMarkController = new UtMarkController();
        private void LoadUtMarks()
        {
            dataGridexame.DataSource = null;
            dataGridexame.DataSource = UtMarkController.GetAllUtMarks();
        }
    }
}
