using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.contoler
{
    internal class UserController
    {
        // ✅ Email format validation
        private bool IsValidEmail(string email) =>
            Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        // ✅ Phone number validation (10 digits)
        private bool IsValidPhone(string phone) =>
            Regex.IsMatch(phone, @"^\d{10}$");

        // ✅ Strong password validation
        private bool IsStrongPassword(string password)
        {
            // Min 8 chars, at least 1 lowercase, 1 uppercase, 1 digit, 1 special char
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$");
        }

        // ✅ NIC number validation (Sri Lankan format)
        private bool IsValidNIC(string nic)
        {
            return Regex.IsMatch(nic, @"^\d{9}[VXvx]$") || Regex.IsMatch(nic, @"^\d{12}$");
        }

        // ✅ Add user with full validation
        public string AddUser(Usersignin user)
        {
            if (user == null)
                return "User data is empty.";

            if (string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.Password))
                return "Username and Password are required.";

            if (!IsStrongPassword(user.Password))
                return "Password must be at least 8 characters and include uppercase, lowercase, digit, and special character.";

            if (!IsValidEmail(user.Mail))
                return "Invalid email format.";

            if (!IsValidPhone(user.Phone_no))
                return "Phone number must be 10 digits.";

            if (!IsValidNIC(user.NIC_no))
                return "Invalid NIC number. Use 9-digit + V/X or 12-digit format.";

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO Users 
                    (UserName, Password, Role, Mail, Address, Phone_no, NIC_no, UserImage) 
                    VALUES 
                    (@username, @password, @role, @mail, @address, @phone, @nic, @image)";

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@mail", user.Mail);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@phone", user.Phone_no);
                cmd.Parameters.AddWithValue("@nic", user.NIC_no);
                cmd.Parameters.AddWithValue("@image", user.UserImage ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                return "User added successfully.";
            }
        }

        // ✅ Fetch all users
        public List<Usersignin> GetAllUsers()
        {
            List<Usersignin> users = new List<Usersignin>();

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Users";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new Usersignin
                        {
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString(),
                            Mail = reader["Mail"].ToString(),
                            Address = reader["Address"].ToString(),
                            Phone_no = reader["Phone_no"].ToString(),
                            NIC_no = reader["NIC_no"].ToString(),
                            UserImage = reader["UserImage"] is DBNull ? null : (byte[])reader["UserImage"]
                        });
                    }
                }
            }

            return users;
        }

        // ✅ Delete user by username
        public void DeleteUser(string username)
        {
            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Users WHERE UserName = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Update user
        public string UpdateUser(Usersignin user)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.UserName))
                return "User not valid.";

            using (var conn = dbconnection.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE Users SET 
                        Password = @password,
                        Role = @role,
                        Mail = @mail,
                        Address = @address,
                        Phone_no = @phone,
                        NIC_no = @nic,
                        UserImage = @image
                    WHERE UserName = @username";

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@mail", user.Mail);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@phone", user.Phone_no);
                cmd.Parameters.AddWithValue("@nic", user.NIC_no);
                cmd.Parameters.AddWithValue("@image", user.UserImage ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                return "User updated successfully.";
            }
        }
    }
}
