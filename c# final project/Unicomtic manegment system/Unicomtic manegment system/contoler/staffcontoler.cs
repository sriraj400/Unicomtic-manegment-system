using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.data;
using System.Data.SQLite;

namespace Unicomtic_manegment_system.contoler
{
    internal class staffcontoler
    {
        public void AddStaff(Staff staff)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO staff (staffid, staffname, nic, dateofbirth, worktype)
                    VALUES (@staffid, @name, @nic, @dob, @worktype)";

                cmd.Parameters.AddWithValue("@staffid", staff.Staffid);
                cmd.Parameters.AddWithValue("@name", staff.Staffname);
                cmd.Parameters.AddWithValue("@nic", staff.NIC);
                cmd.Parameters.AddWithValue("@dob", staff.DateOfBirth);
                cmd.Parameters.AddWithValue("@worktype", staff.WorkType);

                cmd.ExecuteNonQuery();
            }
        }

        // 🔁 Get All Staff
        public List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT rowid AS id, staffid, staffname, nic, dateofbirth, worktype FROM staff";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            Staffid = Convert.ToInt32(reader["staffid"]),
                            Staffname = reader["staffname"].ToString(),
                            NIC = reader["nic"].ToString(),
                            DateOfBirth = reader["dateofbirth"].ToString(),
                            WorkType = reader["worktype"].ToString()
                        });
                    }
                }
            }

            return staffList;
        }

        // 🔄 Update Staff
        public void UpdateStaff(Staff staff)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE staff
                    SET staffname = @name,
                        nic = @nic,
                        dateofbirth = @dob,
                        worktype = @worktype
                    WHERE staffid = @id";

                cmd.Parameters.AddWithValue("@name", staff.Staffname);
                cmd.Parameters.AddWithValue("@nic", staff.NIC);
                cmd.Parameters.AddWithValue("@dob", staff.DateOfBirth);
                cmd.Parameters.AddWithValue("@worktype", staff.WorkType);
                cmd.Parameters.AddWithValue("@id", staff.Staffid);

                cmd.ExecuteNonQuery();
            }
        }

        // ❌ Delete Staff
        public void DeleteStaff(int staffId)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM staff WHERE staffid = @id";
                cmd.Parameters.AddWithValue("@id", staffId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

