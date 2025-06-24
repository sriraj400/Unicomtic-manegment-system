using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.controller;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class exame : Form
    {
        private UtMarkController markController = new UtMarkController();

        public exame()
        {
            InitializeComponent();
            LoadUtMarks();
            LoadMarksComboBox();
            LoadSubjectComboBox();
            LoadUtNumberComboBox();


        }

        private void LoadUtMarks()
        {
            dataGridexame.DataSource = null;
            dataGridexame.DataSource = markController.GetAllUtMarks();
        }

        private void ClearForm()
        {
            comutnumbere.Text = "";
            txtexameide.Text = "";
            coms.Text = "";
            commarks.Text = "";
            dateTimePicker2.Value = DateTime.Now;
        }


        private void exame_Load(object sender, EventArgs e)
        {

        }

        private void btnadde_Click(object sender, EventArgs e)
        {
            try
            {
                var mark = new Exame
                {
                    UtNumber = int.Parse(comutnumbere.Text),
                    ExameId = int.Parse(txtexameide.Text),
                    ExameDate = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                    SubjectName = coms.Text,
                    CourseName = comc.Text,
                    Marks = int.Parse(commarks.Text)
                };

                markController.AddUtMark(mark);
                MessageBox.Show("Mark added successfully.");
                LoadUtMarks();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding mark: " + ex.Message);
            }
        }

        private void btnupdatee_Click(object sender, EventArgs e)
        {
            try
            {
                var mark = new Exame
                {
                    UtNumber = int.Parse(comutnumbere.Text),
                    ExameId = int.Parse(txtexameide.Text),
                    ExameDate = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                    SubjectName = coms.Text,
                    CourseName = comc.Text,
                    Marks = int.Parse(commarks.Text)
                };

                markController.UpdateUtMark(mark);
                MessageBox.Show("Mark updated successfully.");
                LoadUtMarks();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating mark: " + ex.Message);
            }
        }

        private void btndeletee_Click(object sender, EventArgs e)
        {
            try
            {
                int exameId = int.Parse(txtexameide.Text);
                markController.DeleteUtMark(exameId);
                MessageBox.Show("Mark deleted successfully.");
                LoadUtMarks();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting mark: " + ex.Message);
            }

        }

        private void dataGridexame_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridexame.Rows[e.RowIndex];
                comutnumbere.Text = row.Cells["UtNumber"].Value.ToString();
                txtexameide.Text = row.Cells["ExameId"].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(row.Cells["ExameDate"].Value.ToString());
                coms.Text = row.Cells["SubjectName"].Value.ToString();
                comc.Text = row.Cells["CourseName"].Value.ToString();
                commarks.Text = row.Cells["Marks"].Value.ToString();
            }

        }
        private void LoadMarksComboBox()
        {
            commarks.Items.Clear(); // ComboBox name: commarks

            for (int i = 1; i <= 100; i++)
            {
                commarks.Items.Add(i.ToString());
            }

            commarks.SelectedIndex = 0; // Default = 1
            commarks.DropDownStyle = ComboBoxStyle.DropDownList; // ⛔ Typing disable
        }


        //ut number  show in combobox
        private void LoadUtNumberComboBox()
        {
            comutnumbere.Items.Clear(); // comboBox name: comutnumbere

            StudentController studentController = new StudentController();
            List<int> utNumbers = studentController.GetAllUtNumbers();

            foreach (int ut in utNumbers)
            {
                comutnumbere.Items.Add(ut.ToString());
            }

            if (comutnumbere.Items.Count > 0)
                comutnumbere.SelectedIndex = 0; // Default select
            comutnumbere.DropDownStyle = ComboBoxStyle.DropDownList;//this use not type 
        }

        private void LoadSubjectComboBox()
        {
            subjectcontoler subjectController = new subjectcontoler();
            List<subject> subjects = subjectController.GetAllSubjects();  // get list

            comc.DataSource = subjects;
            comc.DisplayMember = "SubjectName";  // what you see
            comc.ValueMember = "SubjectId";      // what is stored

            comc.SelectedIndex = -1;  // nothing selected at start
            comc.DropDownStyle = ComboBoxStyle.DropDownList; // prevent typing
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comc.SelectedItem != null)
            {
                subject selectedSubject = (subject)comc.SelectedItem;
                CourseContoler courseContoler = new CourseContoler();
                List<Course> courses = courseContoler.GetCoursesBySubjectName(selectedSubject.SubjectName);

                coms.DataSource = courses;
                coms.DisplayMember = "CourseName";
                coms.ValueMember = "CourseId";
                coms.SelectedIndex = -1;
                coms.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
    }
}
