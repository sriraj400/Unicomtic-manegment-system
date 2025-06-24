using System;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.model;  // Ensure your model namespace is included

namespace Unicomtic_manegment_system.view
{
    public partial class staffadd : Form
    {
        private staffcontoler staffController = new staffcontoler();

        public staffadd()
        {
            InitializeComponent();
            LoadStaffs();
        }

        private void ClearStaffForm()
        {
            txtstaffid.Clear();
            txtstaffname.Clear();
            txtnic.Clear();
            dateTimePicker2.Value = DateTime.Now;
            comwork.SelectedIndex = -1;
        }

        private void LoadStaffs()
        {
            dataGridVie4.DataSource = null;
            dataGridVie4.DataSource = staffController.GetAllStaff();
        }

        private void btnadds_Click(object sender, EventArgs e)
        {
            var staff = new Staff    // Note: Class name is 'Staff'
            {
                Staffid = int.Parse(txtstaffid.Text),
                Staffname = txtstaffname.Text,
                NIC = txtnic.Text,
                DateOfBirth = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                WorkType = comwork.Text
            };

            try
            {
                staffController.AddStaff(staff);  // use same variable name
                MessageBox.Show("Staff added successfully.");
                LoadStaffs();
                ClearStaffForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdates_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtstaffid.Text, out int staffId))
            {
                MessageBox.Show("Invalid Staff ID");
                return;
            }

            var staff = new Staff
            {
                Staffid = staffId,
                Staffname = txtstaffname.Text,
                NIC = txtnic.Text,
                DateOfBirth = dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                WorkType = comwork.Text
            };

            try
            {
                staffController.UpdateStaff(staff);
                MessageBox.Show("Staff updated successfully.");
                LoadStaffs();
                ClearStaffForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndeletes_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtstaffid.Text, out int staffId))
            {
                MessageBox.Show("Invalid Staff ID");
                return;
            }

            try
            {
                staffController.DeleteStaff(staffId);
                MessageBox.Show("Staff deleted successfully.");
                LoadStaffs();
                ClearStaffForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void dataGridVie4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridVie4.Rows[e.RowIndex];
                txtstaffid.Text = row.Cells["Staffid"].Value.ToString();
                txtstaffname.Text = row.Cells["Staffname"].Value.ToString();
                txtnic.Text = row.Cells["NIC"].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString());
                comwork.Text = row.Cells["WorkType"].Value.ToString();
            }
        }

        private void staffadd_Load(object sender, EventArgs e)
        {

        }
    }
}
