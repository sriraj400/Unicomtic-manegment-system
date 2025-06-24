using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class Room : Form
    {
        RoomController roomController = new RoomController();

        public Room()
        {
            InitializeComponent();
            LoadRoomData();
            ClearForm();
        }


        // 🔁 Load all rooms into DataGridView
        private void LoadRoomData()
        {
            var roomList = roomController.GetAllRooms();
            dataGridViewroom.DataSource = null;
            dataGridViewroom.DataSource = roomList;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            try
            {
                Rooms room = new Rooms
                {
                    Roomid = int.Parse(txtroomid.Text),
                    RoomName = txtroomname.Text
                };

                roomController.AddRoom(room);
                MessageBox.Show("Room added successfully.");
                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
            }
            ClearForm();
        }

        private void btnupdateroom_Click(object sender, EventArgs e)
        {
            try
            {
                Rooms room = new Rooms
                {
                    Roomid = int.Parse(txtroomid.Text),
                    RoomName = txtroomname.Text
                };

                roomController.UpdateRoom(room);
                MessageBox.Show("Room updated successfully.");
                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
            ClearForm();
        }

        private void btndeleteroom_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = int.Parse(txtroomid.Text);
                roomController.DeleteRoom(roomId);
                MessageBox.Show("Room deleted successfully.");
                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting room: " + ex.Message);
            }
            ClearForm();
        }

        private void dataGridViewroom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewroom.Rows[e.RowIndex];
                txtroomid.Text = row.Cells["Roomid"].Value.ToString();
                txtroomname.Text = row.Cells["RoomName"].Value.ToString();
            }
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtroomid.Clear();
            txtroomname.Clear();
        }
    }
}
