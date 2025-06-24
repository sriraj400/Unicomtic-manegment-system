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
using Unicomtic_manegment_system.controller;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class course : Form
    {
        CourseContoler CourseContoler = new CourseContoler();
        public course()
        {
            InitializeComponent();
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnaddc_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = int.Parse(txtcourseidc.Text);
                string courseName = txtcoursename.Text;
                string subjectName = comsubjectc.Text;

                Course course = new Course
                {
                    Courseid = courseId,
                    CourseName = courseName,
                    subjectName = subjectName
                };

                CourseContoler.AddCourse(course);
                MessageBox.Show("✅ Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndeletec_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = int.Parse(txtcourseidc.Text);

                CourseContoler.DeleteCourse(courseId);
                MessageBox.Show("🗑️ Course deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdatec_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId = int.Parse(txtcourseidc.Text);
                string courseName = txtcoursename.Text;
                string subjectName = comsubjectc.Text;

                Course course = new Course
                {
                    Courseid = courseId,
                    CourseName = courseName,
                    subjectName = subjectName
                };

                CourseContoler.UpdateCourse(course);
                MessageBox.Show("✅ Course updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // clear code 
        private void ClearFields()
        {
            txtcourseidc.Clear();
            txtcoursename.Clear();
            comsubjectc.SelectedIndex = -1;
            comsubjectc.Text = "";
        }


        private void course_Load(object sender, EventArgs e)
        {
            LoadCourses();
            subjectcontoler subjectController = new subjectcontoler();
            List<subject> subjectList = subjectController.GetAllSubjects();

            // Default message row add பண்ணுறோம்
            subjectList.Insert(0, new subject { SubjectId = 0, SubjectName = "-- Select Subject --" });

            comsubjectc.DataSource = subjectList;
            comsubjectc.DisplayMember = "SubjectName";
            comsubjectc.ValueMember = "SubjectId";
            comsubjectc.SelectedIndex = 0;  // Show default message

            comsubjectc.DropDownStyle = ComboBoxStyle.DropDownList; // prevent typing


        }



        // datagried view show 

        private void LoadCourses()
        {
            dataGridViewcourse.DataSource = null;
            dataGridViewcourse.DataSource = CourseContoler.GetAllCourses();
        }

        private void dataGridView3_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewcourse.Rows[e.RowIndex];

                txtcourseidc.Text = row.Cells["Courseid"].Value.ToString();
                txtcoursename.Text = row.Cells["CourseName"].Value.ToString();
                comsubjectc.Text = row.Cells["subjectName"].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comsubjectc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
