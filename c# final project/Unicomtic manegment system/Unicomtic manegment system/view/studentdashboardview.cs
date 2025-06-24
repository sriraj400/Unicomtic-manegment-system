using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.view
{
    public partial class studentdashboardview : Form
    {
        private string loggedUser;
        private string loggedStudent;

        public studentdashboardview(string username, string utNumber)
        {
            InitializeComponent();
            loggedUser = username;
            loggedStudent = utNumber;
            LoadAttendancePercentage();
        }

        private void LoadAttendancePercentage()
        {
            int presentDays = 0;
            int totalDays = 0;
            double attendancePercentage = 0;

            string currentMonth = DateTime.Now.ToString("MM");
            string currentYear = DateTime.Now.ToString("yyyy");

            using (SQLiteConnection conn = dbconnection.GetConnection()) // 🔁 using your shared connection
            {
         //       conn.Open();

                string query = @"SELECT Status FROM Attendance 
                         WHERE UTNumber = @ut 
                         AND strftime('%m', Date) = @month 
                         AND strftime('%Y', Date) = @year";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ut", loggedStudent);
                    cmd.Parameters.AddWithValue("@month", currentMonth);
                    cmd.Parameters.AddWithValue("@year", currentYear);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["Status"].ToString();
                            if (status == "Present")
                            {
                                presentDays++;
                            }
                            totalDays++;
                        }
                    }
                }
            }

            if (totalDays > 0)
            {
                attendancePercentage = ((double)presentDays / totalDays) * 100;
            }

            // ✅ Show in label with color
            lblAttendanceStatus.Text = $"Your Overall" +
                $"Attendance:"+
                $"{attendancePercentage:0.##}%";

            if (attendancePercentage >= 90)
            {
                lblAttendanceStatus.ForeColor = Color.Green;
            }
            else
            {
                lblAttendanceStatus.ForeColor = Color.Red;
            }
        }


        private void studentdashboardview_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (SQLiteConnection con = dbconnection.GetConnection())
            {
                string query = "SELECT UserName, Mail, Address, Phone_no, NIC_no, UserImage FROM Users WHERE UserName = @username AND Role = 'student'";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", loggedUser);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["UserName"].ToString();
                            textBox2.Text = reader["Mail"].ToString();
                            textBox3.Text = reader["Address"].ToString();
                            textBox4.Text = reader["Phone_no"].ToString();
                            textBox5.Text = reader["NIC_no"].ToString();

                            if (reader["UserImage"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["UserImage"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    pictureBoxstudent.Image = Image.FromStream(ms);
                                    pictureBoxstudent.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }

                            lblwelcom.Text = "Welcome, " + reader["UserName"].ToString();
                        }
                    }
                }
            }
        }
    }
}
