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
    public partial class viewcoursedetails : Form
    {
        public viewcoursedetails()
        {
            InitializeComponent();
            LoadSubjects();
        }
            

        private void viewcoursedetails_Load(object sender, EventArgs e)
        {

        }
        private void LoadSubjects()
        {
            dataGridViewcourse.DataSource = null;
            dataGridViewcourse.DataSource = subjectController.GetAllSubjects();
        }
        private subjectcontoler subjectController = new subjectcontoler();
    }
}
