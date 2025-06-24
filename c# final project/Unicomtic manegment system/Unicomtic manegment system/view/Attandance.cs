using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.view
{
    public partial class Attandance : Form
    {
        public Attandance()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Attandance_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "Present", "Absent" });
            cmbStatus.SelectedIndex = 0;

            LoadUTNumbers(); // fill UT numbers
            LoadAttendanceForDate(DateTime.Today); // load today's data

        }
        private void LoadUTNumbers()
        {
            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                //    conn.Open();
                string query = "SELECT utnumber FROM Student";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtusersusername.Items.Add(reader["utnumber"].ToString());
                    }
                }
            }
        }
        private void cmbUTNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUTNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedUT = txtusersusername.SelectedItem.ToString();

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                //    conn.Open();
                string query = "SELECT studentname FROM Student WHERE utnumber = @ut";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ut", selectedUT);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtStudentName.Text = result.ToString();
                    }
                }
            }
        }

        private void btnaddd_Click(object sender, EventArgs e)
        {
            string utNumber = txtusersusername.Text;
            string name = txtStudentName.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string status = cmbStatus.Text;

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                //  conn.Open();

                // Prevent duplicate entry for same date + student
                string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE UTNumber = @ut AND Date = @date";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ut", utNumber);
                    checkCmd.Parameters.AddWithValue("@date", date);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("❗ Already marked attendance for this student today.");
                        return;
                    }
                }

                // Save
                string query = "INSERT INTO Attendance (UTNumber, StudentName, Date, Status) VALUES (@ut, @name, @date, @status)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ut", utNumber);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("✅ Attendance Saved Successfully!");
            LoadAttendanceForDate(dtpDate.Value); // Refresh view
        }

        private void LoadAttendanceForDate(DateTime selectedDate)
        {
            string date = selectedDate.ToString("yyyy-MM-dd");

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                //   conn.Open();
                string query = "SELECT UTNumber, StudentName, Status FROM Attendance WHERE Date = @date";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@date", date);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // << IMPORTANT LINE TO FIX EMPTY GRID
                    dataGridViewAttendance.DataSource = dt;
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceForDate(dtpDate.Value);
        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAttendance_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAttendance.Rows[e.RowIndex];

                txtusersusername.Text = row.Cells["UTNumber"].Value.ToString();
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
                dtpDate.Value = dtpDate.Value; // Keep current date
            }
        }

        private void btnubdate_Click(object sender, EventArgs e)
        {
            string utNumber = txtusersusername.Text;
            string name = txtStudentName.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string status = cmbStatus.Text;

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                string query = "UPDATE Attendance SET StudentName = @name, Status = @status WHERE UTNumber = @ut AND Date = @date";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ut", utNumber);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@status", status);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("✅ Attendance Updated!");
                    else
                        MessageBox.Show("❗ Update Failed. Record not found.");
                }
            }

            LoadAttendanceForDate(dtpDate.Value); // Refresh grid
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string utNumber = txtusersusername.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            DialogResult result = MessageBox.Show("Are you sure you want to delete this attendance record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection conn = dbconnection.GetConnection())
                {
                    string query = "DELETE FROM Attendance WHERE UTNumber = @ut AND Date = @date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ut", utNumber);
                        cmd.Parameters.AddWithValue("@date", date);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("✅ Attendance Deleted!");
                        else
                            MessageBox.Show("❗ Delete Failed. Record not found.");
                    }
                }

                LoadAttendanceForDate(dtpDate.Value); // Refresh grid
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchAttendanceForDate();
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            SearchAttendanceForDate();
        }
        private void SearchAttendanceForDate()
        {
            string searchText = txtSearch.Text.Trim();
            string selectedDate = dtpDate.Value.ToString("yyyy-MM-dd");

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                string query = @"SELECT UTNumber, StudentName, Status 
                         FROM Attendance 
                         WHERE Date = @date 
                         AND (UTNumber LIKE @search OR StudentName LIKE @search)";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@date", selectedDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewAttendance.DataSource = dt;
                }
            }
        }

       

      

      

        private void dtpDate_VisibleChanged_1(object sender, EventArgs e)
        {
            SearchAttendanceForDate();
        }
    }
}