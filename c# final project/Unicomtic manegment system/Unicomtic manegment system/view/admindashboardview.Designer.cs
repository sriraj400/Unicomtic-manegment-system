namespace Unicomtic_manegment_system.view
{
    partial class admindashboardview
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblut = new Label();
            lblAttendances = new Label();
            lblUTNumber = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            lblAttendance = new Label();
            lblTodayClasses = new Label();
            feedbackPanel = new Panel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblStaffCount = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            lblLectureCount = new Label();
            lblStudentCount = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            sri = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_2;
            // 
            // lblut
            // 
            lblut.AutoSize = true;
            lblut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblut.Location = new Point(424, 127);
            lblut.Name = "lblut";
            lblut.Size = new Size(76, 28);
            lblut.TabIndex = 14;
            lblut.Text = "label11";
            lblut.Click += lblut_Click;
            // 
            // lblAttendances
            // 
            lblAttendances.AutoSize = true;
            lblAttendances.Location = new Point(420, 215);
            lblAttendances.Name = "lblAttendances";
            lblAttendances.Size = new Size(69, 25);
            lblAttendances.TabIndex = 13;
            lblAttendances.Text = "label11";
            // 
            // lblUTNumber
            // 
            lblUTNumber.AutoSize = true;
            lblUTNumber.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUTNumber.ForeColor = Color.DarkSlateBlue;
            lblUTNumber.Location = new Point(79, 140);
            lblUTNumber.Name = "lblUTNumber";
            lblUTNumber.Size = new Size(198, 45);
            lblUTNumber.TabIndex = 12;
            lblUTNumber.Text = "UT_Number";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblut);
            panel5.Controls.Add(lblAttendances);
            panel5.Controls.Add(lblUTNumber);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(lblAttendance);
            panel5.Controls.Add(lblTodayClasses);
            panel5.Location = new Point(28, 276);
            panel5.Name = "panel5";
            panel5.Size = new Size(634, 318);
            panel5.TabIndex = 16;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.business;
            pictureBox5.Location = new Point(0, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(121, 127);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(162, 18);
            label10.Name = "label10";
            label10.Size = new Size(227, 90);
            label10.TabIndex = 10;
            label10.Text = "Student \r\nAttandance %";
            // 
            // lblAttendance
            // 
            lblAttendance.AutoSize = true;
            lblAttendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttendance.ForeColor = Color.Coral;
            lblAttendance.Location = new Point(79, 215);
            lblAttendance.Margin = new Padding(4, 0, 4, 0);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(167, 38);
            lblAttendance.TabIndex = 3;
            lblAttendance.Text = "Attendance";
            // 
            // lblTodayClasses
            // 
            lblTodayClasses.AutoSize = true;
            lblTodayClasses.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayClasses.Location = new Point(420, 8);
            lblTodayClasses.Margin = new Padding(4, 0, 4, 0);
            lblTodayClasses.Name = "lblTodayClasses";
            lblTodayClasses.Size = new Size(114, 76);
            lblTodayClasses.TabIndex = 4;
            lblTodayClasses.Text = "Today's\r\nClasses";
            // 
            // feedbackPanel
            // 
            feedbackPanel.Location = new Point(18, 127);
            feedbackPanel.Name = "feedbackPanel";
            feedbackPanel.Size = new Size(343, 188);
            feedbackPanel.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(147, 91);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = Properties.Resources.vecteezy_icon_illustration_of_teaching_education_education_7567572;
            pictureBox4.Location = new Point(7, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(165, 46);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 38);
            label7.TabIndex = 0;
            label7.Text = "Feed Back ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(136, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 30);
            label8.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(127, 82);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 30);
            label9.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(feedbackPanel);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(668, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 318);
            panel4.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.Screenshot_2025_06_22_130209;
            pictureBox3.Location = new Point(3, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(101, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 38);
            label4.TabIndex = 0;
            label4.Text = "Staff Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(136, 91);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 30);
            label5.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblStaffCount);
            panel3.Location = new Point(741, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 156);
            panel3.TabIndex = 14;
            // 
            // lblStaffCount
            // 
            lblStaffCount.AutoSize = true;
            lblStaffCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffCount.Location = new Point(127, 82);
            lblStaffCount.Margin = new Padding(4, 0, 4, 0);
            lblStaffCount.Name = "lblStaffCount";
            lblStaffCount.Size = new Size(0, 30);
            lblStaffCount.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.vecteezy_business_man_icon_;
            pictureBox2.Location = new Point(3, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(101, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 38);
            label2.TabIndex = 0;
            label2.Text = "Lecturers Count";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblLectureCount);
            panel2.Location = new Point(381, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 156);
            panel2.TabIndex = 13;
            // 
            // lblLectureCount
            // 
            lblLectureCount.AutoSize = true;
            lblLectureCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLectureCount.Location = new Point(136, 91);
            lblLectureCount.Margin = new Padding(4, 0, 4, 0);
            lblLectureCount.Name = "lblLectureCount";
            lblLectureCount.Size = new Size(0, 30);
            lblLectureCount.TabIndex = 1;
            // 
            // lblStudentCount
            // 
            lblStudentCount.AutoSize = true;
            lblStudentCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentCount.Location = new Point(147, 91);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(0, 30);
            lblStudentCount.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.download__4_;
            pictureBox1.Location = new Point(3, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblStudentCount);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(sri);
            panel1.Location = new Point(25, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 156);
            panel1.TabIndex = 12;
            // 
            // sri
            // 
            sri.AutoSize = true;
            sri.BackColor = SystemColors.ControlLightLight;
            sri.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sri.ForeColor = Color.Indigo;
            sri.Location = new Point(101, 26);
            sri.Margin = new Padding(4, 0, 4, 0);
            sri.Name = "sri";
            sri.Size = new Size(219, 38);
            sri.TabIndex = 0;
            sri.Text = "Students Count";
            // 
            // admindashboardview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 644);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "admindashboardview";
            Text = "admindashboardview";
            Load += admindashboardview_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label sri;
        private Label lblLectureCount;
        private Label lblStaffCount;
        private Label lblAttendance;
        private Label lblTodayClasses;
        private Label lblFeedback;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblStudentCount;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel feedbackPanel;
        private Label label10;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label lblUTNumber;
        private System.Windows.Forms.Timer timer1;
        private Label lblAttendances;
        private Label lblut;
    }
}