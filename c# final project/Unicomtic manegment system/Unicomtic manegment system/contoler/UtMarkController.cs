using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.data; // dbconnection class இருக்கும் இடம்
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.contoler
{
    public class UtMarkController
    {
        // Add UT Mark
        public void AddUtMark(Exame mark)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO ut_marks (utnumber, exameid, examedate, subjectname,coursename, marks)
                    VALUES (@utnumber, @exameid, @examedate, @subjectname,@coursename, @marks)";

                cmd.Parameters.AddWithValue("@utnumber", mark.UtNumber);
                cmd.Parameters.AddWithValue("@exameid", mark.ExameId);
                cmd.Parameters.AddWithValue("@examedate", mark.ExameDate);
                cmd.Parameters.AddWithValue("@subjectname", mark.SubjectName);
                cmd.Parameters.AddWithValue("@coursename", mark.CourseName);
                cmd.Parameters.AddWithValue("@marks", mark.Marks);

                cmd.ExecuteNonQuery();
            }
        }

        // Get all UT Marks
        public List<Exame> GetAllUtMarks()
        {
            var list = new List<Exame>();
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT utnumber, exameid, examedate, subjectname,coursename, marks FROM ut_marks";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mark = new Exame
                        {
                            UtNumber = Convert.ToInt32(reader["utnumber"]),
                            ExameId = Convert.ToInt32(reader["exameid"]),
                            ExameDate = reader["examedate"].ToString(),
                            SubjectName = reader["subjectname"].ToString(),
                            CourseName = reader["coursename"].ToString(),
                            Marks = Convert.ToInt32(reader["marks"])
                        };
                        list.Add(mark);
                    }
                }
            }
            return list;
        }

        // Update UT Mark by ExameId (unique key)
        public void UpdateUtMark(Exame mark)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE ut_marks
                    SET utnumber = @utnumber,
                        examedate = @examedate,
                        subjectname = @subjectname,
                        coursename=@coursename,
                        marks = @marks
                    WHERE exameid = @exameid";

                cmd.Parameters.AddWithValue("@utnumber", mark.UtNumber);
                cmd.Parameters.AddWithValue("@examedate", mark.ExameDate);
                cmd.Parameters.AddWithValue("@subjectname", mark.SubjectName);
                cmd.Parameters.AddWithValue("@coursename", mark.CourseName);
                cmd.Parameters.AddWithValue("@marks", mark.Marks);
                cmd.Parameters.AddWithValue("@exameid", mark.ExameId);

                cmd.ExecuteNonQuery();
            }
        }

        // Delete UT Mark by ExameId
        public void DeleteUtMark(int exameId)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM ut_marks WHERE exameid = @exameid";
                cmd.Parameters.AddWithValue("@exameid", exameId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
