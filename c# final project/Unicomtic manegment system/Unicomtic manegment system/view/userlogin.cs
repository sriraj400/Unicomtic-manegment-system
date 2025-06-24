using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicomtic_manegment_system.data;

namespace Unicomtic_manegment_system.view
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }


        private void userlogin_Load(object sender, EventArgs e)
        {
            // Add roles to ComboBox on load
            comrole.Items.Clear();
            comrole.Items.AddRange(new string[] { "student", "staff", "lecturer" });
            comrole.SelectedIndex = 0;
        }

        private void btnsigninu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("................Only Use Admin.................");
        }

        private void btnloginu_Click(object sender, EventArgs e)
        {
            string username = txtusersusername.Text.Trim();
            string password = txtuserspassword.Text.Trim();
            string role = comrole.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conn = dbconnection.GetConnection())
                {
                    string query = "SELECT * FROM Users WHERE UserName = @username AND Password = @password AND Role = @role";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                switch (role)
                                {
                                    case "student":
                                    
                                        Studendashboard sd = new Studendashboard(username, username); // UTNumber stored in UserName field
                                        sd.Show();
                                        break;


                                    case "staff":
                                        Staffdashboard st = new Staffdashboard(username);
                                        st.Show();
                                        break;
                                    case "lecturer":
                                        lecturerdashboar ld = new lecturerdashboar(username); // ✅ Username passed
                                        ld.Show();
                                        break;



                                    default:
                                        MessageBox.Show("Unknown role.", "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                }

                                this.Hide(); // Hide login form
                            }
                            else
                            {
                                MessageBox.Show("Invalid username, password, or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            second second = new second();
            second.Show();  
            this.Close();       
        }
    }
}
