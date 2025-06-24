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
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class viewtimtable : Form
    {
        public viewtimtable()
        {
            InitializeComponent();
        }

        private void viewtimtable_Load(object sender, EventArgs e)
        {
            LoadTimetable();
        }
        private void LoadTimetable()
        {
            TimetableController controller = new TimetableController();
            List<Timetable> data = controller.GetAllTimetable();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Session", "Session");
            dataGridView1.Columns.Add("Lab", "Lab");
            dataGridView1.Columns.Add("Subject", "Subject");

            foreach (var row in data)
            {
                dataGridView1.Rows.Add(row.Date, row.Day, row.Time, row.Session, row.Lab, row.Subject);
            }

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }



}


