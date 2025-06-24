using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.view
{
    public partial class staffdashboardview : Form
    {
        private string loggedStaff;

        public staffdashboardview(string username)
        {
            InitializeComponent();
            this.loggedStaff = username;
        }

        private void staffdashboardview_Load(object sender, EventArgs e)
        {
            labelwels.Text = "Welcome, " + loggedStaff;
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            using (SQLiteConnection con = dbconnection.GetConnection())
            {
                string query = @"SELECT UserName, Mail, Address, Phone_no, NIC_no, UserImage 
                                 FROM Users 
                                 WHERE UserName = @username AND Role = 'staff'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", loggedStaff);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["UserName"].ToString();
                            textBox2.Text = reader["Mail"].ToString();
                            textBox3.Text = reader["Address"].ToString();
                            textBox4.Text = reader["Phone_no"].ToString();
                            textBox5.Text = reader["NIC_no"].ToString();

                            if (reader["UserImage"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["UserImage"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    pictureBoxstaff.Image = Image.FromStream(ms);
                                    pictureBoxstaff.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                            else
                            {
                                pictureBoxstaff.Image = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No staff data found for this user.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void pictureBoxstaff_Click(object sender, EventArgs e)
        {
            // Optional: add code to change image
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Optional
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblNIC_Click(object sender, EventArgs e)
        {

        }
    }
}
