using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.view;

namespace Unicomtic_manegment_system.contoler
{
    internal class lecturecontoler
    {
        // ➕ Add Lecturer
        public void AddLecturer(lecturer lec)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO lecture (lectureid, lecturename, datebirth, nic, coursename)
                    VALUES (@id, @name, @dob, @nic, @course)";

                cmd.Parameters.AddWithValue("@id", lec.Lectureid);
                cmd.Parameters.AddWithValue("@name", lec.LectureName);
                cmd.Parameters.AddWithValue("@dob", lec.DateBirth);
                cmd.Parameters.AddWithValue("@nic", lec.NIC);
                cmd.Parameters.AddWithValue("@course", lec.Coursename);

                cmd.ExecuteNonQuery();
            }
        }

        // 📥 Get All Lecturers
        public List<lecturer> GetAllLecturers()
        {
            List<lecturer> lecturers = new List<lecturer>();
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM lecture";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturers.Add(new lecturer
                        {
                            Lectureid = Convert.ToInt32(reader["lectureid"]),
                            LectureName = reader["lecturename"].ToString(),
                            DateBirth = reader["datebirth"].ToString(),
                            NIC = reader["nic"].ToString(),
                            Coursename = reader["coursename"].ToString()
                        });
                    }
                }
            }
            return lecturers;
        }

        // ✏️ Update Lecturer
        public void UpdateLecturer(lecturer lec)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE lecture
                    SET lecturename = @name,
                        datebirth = @dob,
                        nic = @nic,
                        coursename = @course
                    WHERE lectureid = @id";

                cmd.Parameters.AddWithValue("@name", lec.LectureName);
                cmd.Parameters.AddWithValue("@dob", lec.DateBirth);
                cmd.Parameters.AddWithValue("@nic", lec.NIC);
                cmd.Parameters.AddWithValue("@course", lec.Coursename);
                cmd.Parameters.AddWithValue("@id", lec.Lectureid);

                cmd.ExecuteNonQuery();
            }
        }

        // ❌ Delete Lecturer
        public void DeleteLecturer(int lectureId)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM lecture WHERE lectureid = @id";
                cmd.Parameters.AddWithValue("@id", lectureId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
