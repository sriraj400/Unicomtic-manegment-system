using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.contoler
{
    internal class FeedbackController
    {
        public void AddFeedback(Feedback feedback)
        {
            using (var conn = dbconnection.GetConnection())
            {
                string query = @"INSERT INTO Feedback (Name, Rating, Message, SubmittedAt)
                                 VALUES (@Name, @Rating, @Message, @SubmittedAt)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", feedback.Name);
                    cmd.Parameters.AddWithValue("@Rating", feedback.Rating);
                    cmd.Parameters.AddWithValue("@Message", feedback.Message);
                    cmd.Parameters.AddWithValue("@SubmittedAt", feedback.SubmittedAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Feedback> GetAllFeedback()
        {
            var list = new List<Feedback>();

            using (var conn = dbconnection.GetConnection())
            {
                string query = "SELECT * FROM Feedback";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Feedback
                        {
                           
                            Name = reader["Name"].ToString(),
                            Rating = reader["Rating"].ToString(),
                            Message = reader["Message"].ToString(),
                            SubmittedAt = reader["SubmittedAt"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}
