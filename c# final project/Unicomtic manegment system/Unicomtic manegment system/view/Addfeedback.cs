using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class Addfeedback : Form
    {
        public Addfeedback()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addfeedback_Load(object sender, EventArgs e)
        {
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList; // 🔒 Prevent typing
            cmbRating.Items.Clear(); // Optional: Clears if already filled
            cmbRating.Items.AddRange(new string[] {"--selected_item--", "Excellent", "Good", "Average", "Poor", "Very Poor" });
            cmbRating.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string rating = cmbRating.SelectedItem.ToString();
            string message = rtxtFeedback.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter your name and feedback.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Feedback feedback = new Feedback
            {
                Name = name,
                Rating = rating,
                Message = message,
                SubmittedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            FeedbackController controller = new FeedbackController();
            controller.AddFeedback(feedback);

            MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            cmbRating.SelectedIndex = 0;
            rtxtFeedback.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cmbRating.SelectedIndex = 0;
            rtxtFeedback.Clear();
        }
    }
}
