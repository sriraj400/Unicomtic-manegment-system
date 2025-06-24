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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }
        private void LoadFeedbackData()
        {
            FeedbackController controller = new FeedbackController();
            List<Feedback> feedbackList = controller.GetAllFeedback();

            // Bind the list to DataGridView
            dataGridfeedback.DataSource = null;
            dataGridfeedback.DataSource = feedbackList;

            // Optional: Auto column resizing
            dataGridfeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }
    }
}
