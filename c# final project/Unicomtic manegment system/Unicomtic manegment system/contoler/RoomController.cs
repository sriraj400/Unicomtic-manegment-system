using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.contoler
{
    internal class RoomController
    {

        // ➕ Add Room
        public void AddRoom(Rooms room)
        {
            if (room == null) return;

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Room (Roomid, RoomName)
                                    VALUES (@id, @name)";
                cmd.Parameters.AddWithValue("@id", room.Roomid);
                cmd.Parameters.AddWithValue("@name", room.RoomName);

                cmd.ExecuteNonQuery();
            }
        }

        // ✏️ Update Room
        public void UpdateRoom(Rooms room)
        {
            if (room == null) return;

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Room 
                                    SET RoomName = @name 
                                    WHERE Roomid = @id";
                cmd.Parameters.AddWithValue("@id", room.Roomid);
                cmd.Parameters.AddWithValue("@name", room.RoomName);

                cmd.ExecuteNonQuery();
            }
        }

        // ❌ Delete Room
        public void DeleteRoom(int roomId)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Room WHERE Roomid = @id";
                cmd.Parameters.AddWithValue("@id", roomId);
                cmd.ExecuteNonQuery();
            }
        }

        // 📋 Get All Rooms
        public List<Rooms> GetAllRooms()
        {
            List<Rooms> rooms = new List<Rooms>();

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Roomid, RoomName FROM Room";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Rooms
                        {
                            Roomid = Convert.ToInt32(reader["Roomid"]),
                            RoomName = reader["RoomName"].ToString()
                        });
                    }
                }
            }

            return rooms;
     
        }

    }
}

