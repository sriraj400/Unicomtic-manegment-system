using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.controller
{
    internal class StudentController
    {
        public List<int> GetAllUtNumbers()
        {
            var utNumbers = new List<int>();
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT utnumber FROM student";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        utNumbers.Add(Convert.ToInt32(reader["utnumber"]));
                    }
                }
            }
            return utNumbers;
        }


        // ➕ Add Student
        public void AddStudent(Student student)
        {
            if (student == null) return;

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Student (utnumber, studentname, datebirth, nic, coursename)
                                    VALUES (@utnumber, @name, @dob, @nic, @coursename)";

                cmd.Parameters.AddWithValue("@utnumber", student.UTNumber);
                cmd.Parameters.AddWithValue("@name", student.StudentName);
                cmd.Parameters.AddWithValue("@dob", student.DateBirth);
                cmd.Parameters.AddWithValue("@nic", student.NIC);
                cmd.Parameters.AddWithValue("@coursename", student.Coursename); 

                cmd.ExecuteNonQuery();
            }
        }

        // 📃 Get All Students
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                string query = "SELECT * FROM student";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            UTNumber = Convert.ToInt32(reader["utnumber"]),
                            StudentName = reader["studentname"].ToString(),
                            DateBirth = reader["datebirth"].ToString(),
                            NIC = reader["nic"].ToString(),
                            Coursename = reader["coursename"].ToString()
                        });
                    }
                }
            }

            return students;
        }
        // ✏️ Update Student
        public void UpdateStudent(Student student)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE student 
                                    SET studentname = @name, 
                                        datebirth = @dob, 
                                        nic = @nic, 
                                        coursename = @coursename
                                    WHERE utnumber = @utnumber";
                cmd.Parameters.AddWithValue("@name", student.StudentName);
                cmd.Parameters.AddWithValue("@dob", student.DateBirth);
                cmd.Parameters.AddWithValue("@nic", student.NIC);
                cmd.Parameters.AddWithValue("@coursename", student.Coursename);
                cmd.Parameters.AddWithValue("@utnumber", student.UTNumber);

                cmd.ExecuteNonQuery();
            }
        }

        // ❌ Delete Student
        public void DeleteStudent(int utnumber)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM student WHERE utnumber = @utnumber";
                cmd.Parameters.AddWithValue("@utnumber", utnumber);

                cmd.ExecuteNonQuery();
            }
        }
    }
}