using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class Usersigninu : Form
    {
        public Usersigninu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnsigninu_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtusersusername.Text) || string.IsNullOrWhiteSpace(txtuserspassword.Text))
                {
                    MessageBox.Show("Username and password are required.");
                    return;
                }

                // ✅ Role validation
                string[] allowedRoles = { "student", "staff", "lecturer" };
                string inputRole = comrole.Text.Trim().ToLower();

                if (!allowedRoles.Contains(inputRole))
                {
                    MessageBox.Show("Invalid role! Please select student, staff, or lecturer.");
                    return;
                }



                // Convert image to byte[]
                byte[] imageBytes = null;
                if (userimage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        userimage.Image.Save(ms, userimage.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                // ✅ Create model object
                Usersignin newUser = new Usersignin
                {
                    UserName = txtusersusername.Text.Trim(),
                    Password = txtuserspassword.Text.Trim(),
                    Role = inputRole,
                    Mail = txtmail.Text.Trim(),
                    Address = txtaddress.Text.Trim(),
                    Phone_no = tetphoneno.Text.Trim(),
                    NIC_no = txtnic.Text.Trim(),
                    UserImage = imageBytes
                };

                // ✅ Add to DB
                UserController controller = new UserController();
                string result = controller.AddUser(newUser);
                MessageBox.Show(result);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtusersusername.SelectedIndex = -1;
            
            txtuserspassword.Clear();
            comrole.SelectedIndex = -1;
            txtmail.Clear();
            txtaddress.Clear();
            tetphoneno.Clear();
            txtnic.Clear();
            userimage.Image = null;
        }

        private void imagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                userimage.Image = new Bitmap(ofd.FileName);
            }
        }

        private void Usersigninu_Load(object sender, EventArgs e)
        {
            comrole.Items.Clear();
            comrole.Items.AddRange(new string[] { "student", "staff", "lecturer" });
            comrole.SelectedIndex = 0; // default
            LoadUTNumbers();
        }

        private void btnuserlogins_Click(object sender, EventArgs e)
        {
            admindashboard seccond = new admindashboard(); // Create new instance of second form
            seccond.Show(); // Show the second form
            this.Hide();
        }
        private void LoadUTNumbers()
        {
            using (SQLiteConnection conn = dbconnection.GetConnection())
            {
                //    conn.Open();
                string query = "SELECT utnumber FROM Student";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtusersusername.Items.Add(reader["utnumber"].ToString());
                    }
                }
            }
        }
        private void txtusersusername_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    }
}
