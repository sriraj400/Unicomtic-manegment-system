namespace Unicomtic_manegment_system.view
{
    partial class Studendashboard
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
            studendashpaneltop = new Panel();
            btnlogoutstudash = new Button();
            label1 = new Label();
            studentdashboardpanalleft = new Panel();
            btndashboard = new Button();
            btnstudent = new Button();
            btntimetable = new Button();
            btnlecture = new Button();
            btnviewfeedback = new Button();
            btncourse = new Button();
            txtexame = new Button();
            panelmainstu = new Panel();
            studendashpaneltop.SuspendLayout();
            studentdashboardpanalleft.SuspendLayout();
            SuspendLayout();
            // 
            // studendashpaneltop
            // 
            studendashpaneltop.BackColor = SystemColors.ActiveCaptionText;
            studendashpaneltop.Controls.Add(btnlogoutstudash);
            studendashpaneltop.Controls.Add(label1);
            studendashpaneltop.Dock = DockStyle.Top;
            studendashpaneltop.Location = new Point(0, 0);
            studendashpaneltop.Name = "studendashpaneltop";
            studendashpaneltop.Size = new Size(1321, 78);
            studendashpaneltop.TabIndex = 0;
            // 
            // btnlogoutstudash
            // 
            btnlogoutstudash.BackColor = Color.Brown;
            btnlogoutstudash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogoutstudash.ForeColor = SystemColors.ControlLightLight;
            btnlogoutstudash.Location = new Point(1164, 18);
            btnlogoutstudash.Name = "btnlogoutstudash";
            btnlogoutstudash.Size = new Size(146, 48);
            btnlogoutstudash.TabIndex = 17;
            btnlogoutstudash.Text = "Logout";
            btnlogoutstudash.UseVisualStyleBackColor = false;
            btnlogoutstudash.Click += btnlogoutstudash_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(320, 48);
            label1.TabIndex = 19;
            label1.Text = "Student dashboard";
            label1.Click += label1_Click;
            // 
            // studentdashboardpanalleft
            // 
            studentdashboardpanalleft.BackColor = SystemColors.ActiveCaptionText;
            studentdashboardpanalleft.Controls.Add(btndashboard);
            studentdashboardpanalleft.Controls.Add(btnstudent);
            studentdashboardpanalleft.Controls.Add(btntimetable);
            studentdashboardpanalleft.Controls.Add(btnlecture);
            studentdashboardpanalleft.Controls.Add(btnviewfeedback);
            studentdashboardpanalleft.Controls.Add(btncourse);
            studentdashboardpanalleft.Controls.Add(txtexame);
            studentdashboardpanalleft.Dock = DockStyle.Left;
            studentdashboardpanalleft.Location = new Point(0, 78);
            studentdashboardpanalleft.Name = "studentdashboardpanalleft";
            studentdashboardpanalleft.Size = new Size(251, 700);
            studentdashboardpanalleft.TabIndex = 1;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = SystemColors.ActiveCaptionText;
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Microsoft Sans Serif", 12F);
            btndashboard.ForeColor = SystemColors.ControlLightLight;
            btndashboard.Location = new Point(6, 17);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(249, 47);
            btndashboard.TabIndex = 20;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // btnstudent
            // 
            btnstudent.BackColor = SystemColors.ActiveCaptionText;
            btnstudent.FlatAppearance.BorderSize = 0;
            btnstudent.FlatStyle = FlatStyle.Flat;
            btnstudent.Font = new Font("Microsoft Sans Serif", 12F);
            btnstudent.ForeColor = SystemColors.ControlLightLight;
            btnstudent.Location = new Point(1, 72);
            btnstudent.Name = "btnstudent";
            btnstudent.Size = new Size(251, 42);
            btnstudent.TabIndex = 18;
            btnstudent.Text = "Student";
            btnstudent.UseVisualStyleBackColor = false;
            btnstudent.Click += btnstudent_Click;
            // 
            // btntimetable
            // 
            btntimetable.BackColor = SystemColors.ActiveCaptionText;
            btntimetable.FlatAppearance.BorderSize = 0;
            btntimetable.FlatStyle = FlatStyle.Flat;
            btntimetable.Font = new Font("Microsoft Sans Serif", 12F);
            btntimetable.ForeColor = SystemColors.ControlLightLight;
            btntimetable.Location = new Point(-1, 265);
            btntimetable.Name = "btntimetable";
            btntimetable.Size = new Size(251, 42);
            btntimetable.TabIndex = 21;
            btntimetable.Text = "Time table";
            btntimetable.UseVisualStyleBackColor = false;
            btntimetable.Click += btntimetable_Click;
            // 
            // btnlecture
            // 
            btnlecture.BackColor = SystemColors.ActiveCaptionText;
            btnlecture.FlatAppearance.BorderSize = 0;
            btnlecture.FlatStyle = FlatStyle.Flat;
            btnlecture.Font = new Font("Microsoft Sans Serif", 12F);
            btnlecture.ForeColor = SystemColors.ControlLightLight;
            btnlecture.Location = new Point(-1, 122);
            btnlecture.Name = "btnlecture";
            btnlecture.Size = new Size(251, 42);
            btnlecture.TabIndex = 16;
            btnlecture.Text = "lecture";
            btnlecture.UseVisualStyleBackColor = false;
            btnlecture.Click += btnlecture_Click;
            // 
            // btnviewfeedback
            // 
            btnviewfeedback.BackColor = SystemColors.ActiveCaptionText;
            btnviewfeedback.FlatAppearance.BorderSize = 0;
            btnviewfeedback.FlatStyle = FlatStyle.Flat;
            btnviewfeedback.Font = new Font("Microsoft Sans Serif", 12F);
            btnviewfeedback.ForeColor = SystemColors.ControlLightLight;
            btnviewfeedback.Location = new Point(1, 313);
            btnviewfeedback.Name = "btnviewfeedback";
            btnviewfeedback.Size = new Size(250, 42);
            btnviewfeedback.TabIndex = 24;
            btnviewfeedback.Text = "Feedback";
            btnviewfeedback.UseVisualStyleBackColor = false;
            btnviewfeedback.Click += btnviewfeedback_Click;
            // 
            // btncourse
            // 
            btncourse.BackColor = SystemColors.ActiveCaptionText;
            btncourse.FlatAppearance.BorderSize = 0;
            btncourse.FlatStyle = FlatStyle.Flat;
            btncourse.Font = new Font("Microsoft Sans Serif", 12F);
            btncourse.ForeColor = SystemColors.ControlLightLight;
            btncourse.Location = new Point(0, 168);
            btncourse.Name = "btncourse";
            btncourse.Size = new Size(251, 42);
            btncourse.TabIndex = 22;
            btncourse.Text = "Course";
            btncourse.UseVisualStyleBackColor = false;
            btncourse.Click += btncourse_Click;
            // 
            // txtexame
            // 
            txtexame.BackColor = SystemColors.ActiveCaptionText;
            txtexame.FlatAppearance.BorderSize = 0;
            txtexame.FlatStyle = FlatStyle.Flat;
            txtexame.Font = new Font("Microsoft Sans Serif", 12F);
            txtexame.ForeColor = SystemColors.ControlLightLight;
            txtexame.Location = new Point(0, 217);
            txtexame.Name = "txtexame";
            txtexame.Size = new Size(251, 42);
            txtexame.TabIndex = 25;
            txtexame.Text = "Exame";
            txtexame.UseVisualStyleBackColor = false;
            txtexame.Click += txtexame_Click;
            // 
            // panelmainstu
            // 
            panelmainstu.Dock = DockStyle.Fill;
            panelmainstu.Location = new Point(251, 78);
            panelmainstu.Name = "panelmainstu";
            panelmainstu.Size = new Size(1070, 700);
            panelmainstu.TabIndex = 2;
            panelmainstu.Paint += panelmainstu_Paint;
            // 
            // Studendashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 778);
            Controls.Add(panelmainstu);
            Controls.Add(studentdashboardpanalleft);
            Controls.Add(studendashpaneltop);
            Name = "Studendashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studendashboard";
            Load += Studendashboard_Load;
            studendashpaneltop.ResumeLayout(false);
            studendashpaneltop.PerformLayout();
            studentdashboardpanalleft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel studendashpaneltop;
        private Panel studentdashboardpanalleft;
        private Panel panelmainstu;
        private Label label1;
        private Button btnlogoutstudash;
        private Button btntimetable;
        private Button btnviewfeedback;
        private Button txtexame;
        private Button btncourse;
        private Button btnstudent;
        private Button btndashboard;
        private Button btnlecture;
    }
}