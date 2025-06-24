using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.contoler
{
    internal class TimetableController
    {
        // Insert
        public int AddTimetable(Timetable t)
        {
            using (var conn = dbconnection.GetConnection())
            {
           //     conn.Open();
                var cmd = new SQLiteCommand(
                    "INSERT INTO timetable (Date, Day, Time, Session, Lab, Subject) VALUES (@Date, @Day, @Time, @Session, @Lab, @Subject); SELECT last_insert_rowid();", conn);

                cmd.Parameters.AddWithValue("@Date", t.Date);
                cmd.Parameters.AddWithValue("@Day", t.Day);
                cmd.Parameters.AddWithValue("@Time", t.Time);
                cmd.Parameters.AddWithValue("@Session", t.Session);
                cmd.Parameters.AddWithValue("@Lab", t.Lab);
                cmd.Parameters.AddWithValue("@Subject", t.Subject);

                long lastId = (long)cmd.ExecuteScalar();
                return (int)lastId;
            }
        }

        // Update
        public void UpdateTimetable(Timetable t)
        {
            using (var conn = dbconnection.GetConnection()) // connection எடுத்துக்கொள்கிறோம்
            {
                

                using (var cmd = new SQLiteCommand(conn)) // command தயார் செய்கிறோம்
                {
                    cmd.CommandText = "PRAGMA busy_timeout = 3000;"; // 3 seconds wait
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"
                UPDATE timetable
                SET date = @date, day = @day, time = @time, session = @session, lab = @lab, subject = @subject
                WHERE id = @id";

                    cmd.Parameters.AddWithValue("@id", t.Id);
                    cmd.Parameters.AddWithValue("@date", t.Date);
                    cmd.Parameters.AddWithValue("@day", t.Day);
                    cmd.Parameters.AddWithValue("@time", t.Time);
                    cmd.Parameters.AddWithValue("@session", t.Session);
                    cmd.Parameters.AddWithValue("@lab", t.Lab);
                    cmd.Parameters.AddWithValue("@subject", t.Subject);

                    cmd.ExecuteNonQuery(); // UPDATE செய்கிறோம்
                }
            }
        }

        // Delete
        public void DeleteTimetable(int id)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM timetable WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Get All
        public List<Timetable> GetAll()
        {
            List<Timetable> list = new List<Timetable>();
            using (var conn = dbconnection.GetConnection())
            {
            //    conn.Open();
                string query = "SELECT * FROM timetable";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Timetable
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Date = reader["date"].ToString(),
                            Day = reader["day"].ToString(),
                            Time = reader["time"].ToString(),
                            Session = reader["session"].ToString(),
                            Lab = reader["lab"].ToString(),
                            Subject = reader["subject"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        public List<Timetable> GetTimetableForWeek(DateTime weekStart)
        {
            List<Timetable> list = new List<Timetable>();
            using (var conn = dbconnection.GetConnection())
            {
           //     conn.Open();

                DateTime weekEnd = weekStart.AddDays(6);
                string startStr = weekStart.ToString("dd.MM.yyyy");
                string endStr = weekEnd.ToString("dd.MM.yyyy");

                var cmd = new SQLiteCommand("SELECT * FROM timetable WHERE Date >= @startDate AND Date <= @endDate", conn);
                cmd.Parameters.AddWithValue("@startDate", startStr);
                cmd.Parameters.AddWithValue("@endDate", endStr);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Timetable
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Date = reader["Date"].ToString(),
                        Day = reader["Day"].ToString(),
                        Time = reader["Time"].ToString(),
                        Session = reader["Session"].ToString(),
                        Lab = reader["Lab"].ToString(),
                        Subject = reader["Subject"].ToString()
                    });
                }
            }
            return list;
        }

        public List<Timetable> GetAllTimetable()
        {
            List<Timetable> list = new List<Timetable>();
            using (var conn = dbconnection.GetConnection())
            {
           //     conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM timetable ORDER BY Date, Time", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Timetable
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Date = reader["Date"].ToString(),
                        Day = reader["Day"].ToString(),
                        Time = reader["Time"].ToString(),
                        Session = reader["Session"].ToString(),
                        Lab = reader["Lab"].ToString(),
                        Subject = reader["Subject"].ToString()
                    });
                }
            }
            return list;
        
    }
}
}
