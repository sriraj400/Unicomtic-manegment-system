using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.controller;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class studentadd : Form
    {
        private readonly StudentController studentController = new StudentController();

        public studentadd()
        {
            InitializeComponent();
        }

        private void studentadd_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadCourseNames();
        }

        private void LoadCourseNames()
        {
            subjectcontoler courseController = new subjectcontoler();
            List<subject> subjects = courseController.GetAllCourse();

            comcousernames.DataSource = subjects;
            comcousernames.DisplayMember = "SubjectName";
            comcousernames.ValueMember = "SubjectId";
            comcousernames.SelectedIndex = -1;
            comcousernames.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ClearForm()
        {
            txtutnumber.Clear();
            txtstudentname.Clear();
            txtnics.Clear();
            comcousernames.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                {
                    UTNumber = int.Parse(txtutnumber.Text),
                    StudentName = txtstudentname.Text,
                    DateBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    NIC = txtnics.Text,
                    Coursename = ((subject)comcousernames.SelectedItem).SubjectName
                };

                studentController.AddStudent(student);
                MessageBox.Show("Student added successfully!");
                LoadStudents();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadStudents()
        {
            List<Student> students = studentController.GetAllStudents();
            dataGridViewstudent.DataSource = students;
        }

        private void dataGridViewstudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewstudent.Rows.Count)
            {
                DataGridViewRow row = dataGridViewstudent.Rows[e.RowIndex];

                txtutnumber.Text = row.Cells["UTNumber"].Value?.ToString() ?? "";
                txtstudentname.Text = row.Cells["StudentName"].Value?.ToString() ?? "";
                txtnics.Text = row.Cells["NIC"].Value?.ToString() ?? "";
                comcousernames.Text = row.Cells["Coursename"].Value?.ToString() ?? "";

                if (DateTime.TryParse(row.Cells["DateBirth"].Value?.ToString(), out DateTime dob))
                {
                    dateTimePicker1.Value = dob;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Today;
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                {
                    UTNumber = int.Parse(txtutnumber.Text),
                    StudentName = txtstudentname.Text,
                    DateBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    NIC = txtnics.Text,
                    Coursename = ((subject)comcousernames.SelectedItem).SubjectName
                };

                studentController.UpdateStudent(student);
                MessageBox.Show("Student updated successfully!");
                LoadStudents();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int utnumber = int.Parse(txtutnumber.Text);

                DialogResult result = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    studentController.DeleteStudent(utnumber);
                    MessageBox.Show("Student deleted successfully!");
                    LoadStudents();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
        }
    }
}
