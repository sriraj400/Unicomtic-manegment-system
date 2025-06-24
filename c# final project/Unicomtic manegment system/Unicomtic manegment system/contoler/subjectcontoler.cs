using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.view;
using System.Collections.Generic;


namespace Unicomtic_manegment_system.contoler
{
    internal class subjectcontoler
    {
        // Add Subject
        public void AddSubject(subject subject)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO subject (subjectid, subjectname)
                    VALUES (@id, @name)";
                cmd.Parameters.AddWithValue("@id", subject.SubjectId);
                cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                cmd.ExecuteNonQuery();
            }
        }

        // Get All Subjects
        public List<subject> GetAllSubjects()
        {
            var subjects = new List<subject>();

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT subjectid, subjectname FROM subject";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new subject
                        {
                            SubjectId = Convert.ToInt32(reader["subjectid"]),
                            SubjectName = reader["subjectname"].ToString()
                        });
                    }
                }
            }

            return subjects;
        }

       

        // To return just names (used in ComboBox)
        public List<string> GetSubjects()
        {
            List<string> subjects = new List<string>();

            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                string query = "SELECT subjectname FROM subject";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(reader["subjectname"].ToString());
                    }
                }
            }

            return subjects;
        }


        // Update Subject
        public void UpdateSubject(subject subject)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE subject
                    SET subjectname = @name
                    WHERE subjectid = @id";
                cmd.Parameters.AddWithValue("@id", subject.SubjectId);
                cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Subject
        public void DeleteSubject(int subjectId)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM subject WHERE subjectid = @id";
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd.ExecuteNonQuery();
            }
        }
        //subject name show the course form 
        public List<subject> GetAllSubject()
        {
            List<subject> subjectList = new List<subject>();

            using (SQLiteConnection con = dbconnection.GetConnection())
            {
                string query = "SELECT SubjectId, SubjectName FROM Subject";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subject sub = new subject
                        {
                            SubjectId = Convert.ToInt32(reader["SubjectId"]),
                            SubjectName = reader["SubjectName"].ToString()
                        };

                        subjectList.Add(sub);
                    }
                }
            }

            return subjectList;
        }


        public List<subject> GetAllCourse()
        {
            List<subject> subjectList = new List<subject>();
            using (SQLiteConnection con = dbconnection.GetConnection())
            {
                string query = "SELECT SubjectId, SubjectName FROM subject";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subject sub = new subject
                        {
                            SubjectId = Convert.ToInt32(reader["SubjectId"]),
                            SubjectName = reader["SubjectName"].ToString()
                        };
                        subjectList.Add(sub);
                    }
                }
            }
            return subjectList;
        }
    }
}

    
