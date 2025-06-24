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
    public partial class Subject : Form
    {
        private subjectcontoler subjectController = new subjectcontoler();
        public Subject()
        {
            InitializeComponent();
            LoadSubjects();
        }
        private void LoadSubjects()
        {
            dataGridViewsub.DataSource = null;
            dataGridViewsub.DataSource = subjectController.GetAllSubjects();
        }

        private void ClearForm()
        {
            txtsubjectid.Clear();
            txtsubjectname.Clear();
        }
        private void Subject_Load(object sender, EventArgs e)
        {

        }

        private void btnaddsub_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new subject
                {
                    SubjectId = int.Parse(txtsubjectid.Text),
                    SubjectName = txtsubjectname.Text
                };

                subjectController.AddSubject(subject);
                MessageBox.Show("Subject added successfully.");
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding subject: " + ex.Message);
            }
        }

        private void btnupdatesub_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new subject
                {
                    SubjectId = int.Parse(txtsubjectid.Text),
                    SubjectName = txtsubjectname.Text
                };

                subjectController.UpdateSubject(subject);
                MessageBox.Show("Subject updated successfully.");
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating subject: " + ex.Message);
            }
        }

        private void btndeletesub_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtsubjectid.Text);
                subjectController.DeleteSubject(id);
                MessageBox.Show("Subject deleted successfully.");
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting subject: " + ex.Message);
            }
        }

        private void dataGridViewsub_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewsub.Rows[e.RowIndex];
                txtsubjectid.Text = row.Cells["SubjectId"].Value.ToString();
                txtsubjectname.Text = row.Cells["SubjectName"].Value.ToString();
            }
        }
    }
}
