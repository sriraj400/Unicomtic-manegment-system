using System;
using System.Windows.Forms;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.controller;
using System.Data;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.contoler;

namespace Unicomtic_manegment_system.view
{
    public partial class l : Form
    {

        public l()
        {
            InitializeComponent();
            LoadLecturers();
            LoadCourseIDs();
            LoadCourseNames();
        }
        private lecturecontoler controller = new lecturecontoler();

        private void LoadCourseIDs()
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT courseid FROM course";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //     comcoursenamel.Items.Add(reader["coursename"].ToString());
                    }
                }
            }
        }
        //CourseController courseController = new CourseController();
        private void LoadCourseNames()
        {

            //List<string> courseList = courseController.GetAllCourseNames();
            comcoursenamel.Items.Clear(); // comboBox name
            //comcoursenamel.Items.AddRange(courseList.ToArray());
        }
        private void LoadLecturers()
        {
            var lecturers = controller.GetAllLecturers();
            dataGridView3.DataSource = lecturers;
        }

        private void ClearForm()
        {
            txtlectureid.Clear();
            txtlecturename.Clear();
            txtnicl.Clear();
            dateTimePicker2.Value = DateTime.Now;
            comcoursenamel.SelectedIndex = -1;
        }



        private void lecture_Load(object sender, EventArgs e)
        {
            subjectcontoler subjectController = new subjectcontoler();
            List<subject> subjectList = subjectController.GetAllSubjects();

            // Default message row add பண்ணுறோம்
            subjectList.Insert(0, new subject { SubjectId = 0, SubjectName = "-- Select Subject --" });

            comcoursenamel.DataSource = subjectList;
            comcoursenamel.DisplayMember = "SubjectName";
            comcoursenamel.ValueMember = "SubjectId";
            comcoursenamel.SelectedIndex = 0;  // Show default message

            comcoursenamel.DropDownStyle = ComboBoxStyle.DropDownList; // prevent typing
        }

        private void btnaddl_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtlectureid.Text, out int lectureId))
            {
                MessageBox.Show("Please enter valid Lecture ID.");
                return;
            }

            var lec = new lecturer
            {
                Lectureid = lectureId,
                LectureName = txtlecturename.Text,
                DateBirth = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                NIC = txtnicl.Text,
                Coursename = comcoursenamel.Text
            };

            try
            {
                controller.AddLecturer(lec);
                MessageBox.Show("Lecturer added successfully!");
                LoadLecturers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btndeletel_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtlectureid.Text, out int lectureId))
            {
                MessageBox.Show("Please enter valid Lecture ID.");
                return;
            }

            try
            {
                controller.DeleteLecturer(lectureId);
                MessageBox.Show("Lecturer deleted successfully!");
                LoadLecturers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdatel_Click_1(object sender, EventArgs e)
        {

            if (!int.TryParse(txtlectureid.Text, out int lectureId))
            {
                MessageBox.Show("Please enter valid Lecture ID.");
                return;
            }

            var lec = new lecturer
            {
                Lectureid = lectureId,
                LectureName = txtlecturename.Text,
                DateBirth = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                NIC = txtnicl.Text,
                Coursename = comcoursenamel.Text
            };

            try
            {
                controller.UpdateLecturer(lec);
                MessageBox.Show("Lecturer updated successfully!");
                LoadLecturers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView3.Rows[e.RowIndex];

                txtlectureid.Text = row.Cells["Lectureid"].Value.ToString();
                txtlecturename.Text = row.Cells["lectureName"].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(row.Cells["DateBirth"].Value.ToString());
                txtnicl.Text = row.Cells["NIC"].Value.ToString();
                comcoursenamel.Text = row.Cells["Coursename"].Value.ToString();
            }
        }

        private void comcoursenamel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
