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
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;


namespace Unicomtic_manegment_system.view
{
    public partial class admindashboardview : Form
    {
        DashboardController dashboardController = new DashboardController();

        public admindashboardview()
        {
            InitializeComponent();
        }
        private DataTable studentAttendanceTable;
        private int currentStudentIndex = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admindashboardview_Load(object sender, EventArgs e)
        {

            ShowTodayAttendanceStatus();
            LoadStudentMonthlyAttendance(); // ← Load all % data
            timer1.Interval = 3000; // 3 seconds rotate
            timer1.Start();
            LoadFeedback();
            lblStudentCount.Text = dashboardController.GetStudentCount().ToString();
            lblLectureCount.Text = dashboardController.GetLectureCount().ToString();
            lblStaffCount.Text = dashboardController.GetStaffCount().ToString();
            //   lblAttendance.Text = dashboardController.CalculateAttendance().ToString("F2") + "%";

            //   lblTodayClasses.Text = dashboardController.GetTodayClasses(); // Optional
            // lblFeedback.Text = dashboardController.GetLatestFeedback();   // Optional
        }

        private void lblStaffCount_Click(object sender, EventArgs e)
        {

        }
        private void LoadFeedback()
        {
            List<Feedback> feedbacks = DashboardController.GetAllFeedbacks();
            feedbackPanel.Controls.Clear(); // FlowLayoutPanel or Panel

            foreach (var fb in feedbacks)
            {
                Panel card = new Panel();
                card.BackColor = Color.WhiteSmoke;
                card.Width = feedbackPanel.Width - 30;
                card.Height = 120;
                card.Padding = new Padding(10);
                card.Margin = new Padding(5);

                Label lblName = new Label();
                lblName.Text = $"👤 {fb.Name} ({fb.Rating}⭐)";
                lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblName.AutoSize = true;
                lblName.ForeColor = Color.DarkBlue;
                lblName.Padding = new Padding(50, 5, 0, 0);

                Label lblMsg = new Label();
                lblMsg.Text = fb.Message;
                lblMsg.Font = new Font("Segoe UI", 9);
                lblMsg.AutoSize = true;
                lblMsg.MaximumSize = new Size(card.Width - 20, 0);

                card.Controls.Add(lblName);
                card.Controls.Add(lblMsg);
                lblMsg.Top = lblName.Bottom + 5;

                feedbackPanel.Controls.Add(card);
            }
        }

        private void feedbackPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTodayClasses_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudentMonthlyAttendance()
        {
            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                string query = @"
            SELECT 
                UTNumber,
                ROUND(
                    100.0 * 
                    SUM(CASE WHEN Status = 'Present' THEN 1 ELSE 0 END) / 
                    COUNT(*), 
                2) AS AttendancePercentage
            FROM Attendance
            WHERE STRFTIME('%Y-%m', Date) = STRFTIME('%Y-%m', 'now') -- current month
            GROUP BY UTNumber;
        ";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    studentAttendanceTable = new DataTable();
                    adapter.Fill(studentAttendanceTable);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void lblUTNumber_Click(object sender, EventArgs e)
        {

        }

        private void ShowTodayAttendanceStatus()
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                // conn.Open(); // OPEN IS IMPORTANT

                string query = "SELECT COUNT(UTNumber) FROM Attendance WHERE Date = @date";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", today);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Date label - always show today's date
                    lblut.Text = $"📅 Date: {today}";

                    // Attendance count or No class
                    if (count > 0)
                    {
                        lblAttendances.Text = $"🟢 Attendance Marked: {count} students";
                        lblAttendances.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblAttendances.Text = "❌ No Class Today";
                        lblAttendances.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            if (studentAttendanceTable == null || studentAttendanceTable.Rows.Count == 0)
            {
                lblUTNumber.Text = "No data";
                lblAttendance.Text = "0%";
                return;
            }

            DataRow row = studentAttendanceTable.Rows[currentStudentIndex];
            string utNumber = row["UTNumber"].ToString();
            double percent = Convert.ToDouble(row["AttendancePercentage"]);

            lblUTNumber.Text = $"UT: {utNumber}";
            lblAttendance.Text = $"Attendance: {percent}%";

            // Set color
            if (percent >= 90)
            {
                lblAttendance.ForeColor = Color.Green;
            }
            else
            {
                lblAttendance.ForeColor = Color.Red;
            }

            // Move to next student
            currentStudentIndex++;
            if (currentStudentIndex >= studentAttendanceTable.Rows.Count)
            {
                currentStudentIndex = 0;
            }
        }

        private void lblut_Click(object sender, EventArgs e)
        {

        }
    }
}
