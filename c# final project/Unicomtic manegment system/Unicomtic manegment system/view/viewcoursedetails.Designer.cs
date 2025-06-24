namespace Unicomtic_manegment_system.view
{
    partial class viewcoursedetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            dataGridViewcourse = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcourse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(283, 33);
            label1.Name = "label1";
            label1.Size = new Size(544, 54);
            label1.TabIndex = 0;
            label1.Text = "View Course Details";
            // 
            // dataGridViewcourse
            // 
            dataGridViewcourse.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewcourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcourse.Location = new Point(105, 110);
            dataGridViewcourse.Margin = new Padding(4, 5, 4, 5);
            dataGridViewcourse.Name = "dataGridViewcourse";
            dataGridViewcourse.RowHeadersWidth = 62;
            dataGridViewcourse.Size = new Size(811, 524);
            dataGridViewcourse.TabIndex = 1;
            // 
            // viewcoursedetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 643);
            Controls.Add(dataGridViewcourse);
            Controls.Add(panel1);
            Name = "viewcoursedetails";
            Text = "viewcoursedetails";
            Load += viewcoursedetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewcourse;
    }
}