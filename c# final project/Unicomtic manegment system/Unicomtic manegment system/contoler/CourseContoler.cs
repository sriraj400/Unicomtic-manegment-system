using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.contoler
{
    internal class CourseContoler
    {
        // ➕ Add Course
        public void AddCourse(Course course)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO course (courseid, coursename, subjectname)
                    VALUES (@id, @name, @subject)";

                cmd.Parameters.AddWithValue("@id", course.Courseid);
                cmd.Parameters.AddWithValue("@name", course.CourseName);
                cmd.Parameters.AddWithValue("@subject", course.subjectName);

                cmd.ExecuteNonQuery();
            }
        }

        // 📥 Get All Courses
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM course";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            Courseid = Convert.ToInt32(reader["courseid"]),
                            CourseName = reader["coursename"].ToString(),
                            subjectName = reader["subjectname"].ToString()
                        });
                    }
                }
            }
            return courses;
        }

        // ✏️ Update Course
        public void UpdateCourse(Course course)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE course
                    SET coursename = @name,
                        subjectname = @subject
                    WHERE courseid = @id";

                cmd.Parameters.AddWithValue("@name", course.CourseName);
                cmd.Parameters.AddWithValue("@subject", course.subjectName);
                cmd.Parameters.AddWithValue("@id", course.Courseid);

                cmd.ExecuteNonQuery();
            }
        }

        // ❌ Delete Course
        public void DeleteCourse(int courseId)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM course WHERE courseid = @id";
                cmd.Parameters.AddWithValue("@id", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        // 
       
        //opject model cose lodeing
        public List<Course> GetCoursesBySubjectName(string subjectName)
        {
            List<Course> courses = new List<Course>();
            using (SQLiteConnection con = dbconnection.GetConnection())
            {
                string query = "SELECT courseid, coursename, subjectname FROM course WHERE subjectname = @subjectname";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@subjectname", subjectName);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                Courseid = Convert.ToInt32(reader["courseid"]),
                                CourseName = reader["coursename"].ToString(),
                                subjectName = reader["subjectname"].ToString()
                            });
                        }
                    }
                }
            }
            return courses;
        }

    }
}
