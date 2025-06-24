using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.contoler
{
    internal class DashboardController
    {
        public int GetStudentCount()
        {
            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
            //    conn.Open();
                string query = "SELECT COUNT(*) FROM student";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetLectureCount()
        {
            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
            //    conn.Open();
                string query = "SELECT COUNT(*) FROM lecture";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetStaffCount()
        {
            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
          //      conn.Open();
                string query = "SELECT COUNT(*) FROM staff";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //public double CalculateAttendance()
        //{
        //    using (SQLiteConnection conn = dbconnection.GetConnection())
        //    {
        //    //    conn.Open();
        //        string query = "SELECT AVG(attendance_percent) FROM student_attendance";
        //        SQLiteCommand cmd = new SQLiteCommand(query, conn);
        //        object result = cmd.ExecuteScalar();
        //        return result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
        //    }
        //}


        public static List<Feedback> GetAllFeedbacks()
        {
            List<Feedback> feedbackList = new List<Feedback>();

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
            //    conn.Open();
                string query = "SELECT Name, Rating, Message FROM Feedback ORDER BY SubmittedAt DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedbackList.Add(new Feedback
                            {
                                Name = reader["Name"].ToString(),
                                Rating = reader["Rating"].ToString(),
                                Message = reader["Message"].ToString()
                            });
                        }
                    }
                }
            }

            return feedbackList;
        }
    }
}
