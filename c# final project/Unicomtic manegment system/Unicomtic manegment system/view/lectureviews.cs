using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Unicomtic_manegment_system.view
{
    public partial class lectureviews : Form
    {

        private string loggedUser;
        private string username;

        public lectureviews(string username)
        {
            InitializeComponent();
            loggedUser = username;
        }

        private void lectureviews_Load(object sender, EventArgs e)
        {
            LoadLecturerData(); // Triggers on load
        }

        private void LoadLecturerData()
        {
            using (SQLiteConnection con = dbconnection.GetConnection())
            {
                string query = "SELECT UserName, Mail, Address, Phone_no, NIC_no, UserImage FROM Users WHERE UserName = @username AND Role = 'lecturer'";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", loggedUser);

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
                                    pictureBoxlecturer.Image = Image.FromStream(ms);
                                    pictureBoxlecturer.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                            else
                            {
                                pictureBoxlecturer.Image = null;
                            }
                            labelwelcome.Text = "Welcome, " + loggedUser;
                        }
                    }
                }
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}