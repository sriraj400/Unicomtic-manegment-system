using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Unicomtic_manegment_system.view
{
    partial class studentdashboardview
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
            pictureBoxstudent = new PictureBox();
            Studentdashboard = new ListBox();
            lblUserName = new Label();
            lblMail = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblNIC = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblWelcome = new Label();
            panel1 = new Panel();
            lblwelcom = new Label();
            lblAttendanceStatus = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxstudent).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxstudent
            // 
            pictureBoxstudent.BackColor = SystemColors.ControlLightLight;
            pictureBoxstudent.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxstudent.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxstudent.Location = new Point(681, 83);
            pictureBoxstudent.Name = "pictureBoxstudent";
            pictureBoxstudent.Size = new Size(370, 302);
            pictureBoxstudent.TabIndex = 1;
            pictureBoxstudent.TabStop = false;
            // 
            // Studentdashboard
            // 
            Studentdashboard.BackColor = SystemColors.AppWorkspace;
            Studentdashboard.FormattingEnabled = true;
            Studentdashboard.ItemHeight = 25;
            Studentdashboard.Location = new Point(-3, 83);
            Studentdashboard.Name = "Studentdashboard";
            Studentdashboard.Size = new Size(673, 604);
            Studentdashboard.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = SystemColors.AppWorkspace;
            lblUserName.FlatStyle = FlatStyle.Flat;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.Desktop;
            lblUserName.Location = new Point(34, 192);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(132, 32);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "UserName";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = SystemColors.AppWorkspace;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMail.ForeColor = SystemColors.Desktop;
            lblMail.Location = new Point(39, 275);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(64, 32);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.AppWorkspace;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.Desktop;
            lblAddress.Location = new Point(39, 350);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(106, 32);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.AppWorkspace;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = SystemColors.Desktop;
            lblPhone.Location = new Point(34, 427);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 32);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "PhoneNo";
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.BackColor = SystemColors.AppWorkspace;
            lblNIC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIC.ForeColor = SystemColors.Desktop;
            lblNIC.Location = new Point(39, 527);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(56, 32);
            lblNIC.TabIndex = 7;
            lblNIC.Text = "NIC";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(246, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 37);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Navy;
            textBox2.Location = new Point(246, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 37);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Navy;
            textBox3.Location = new Point(246, 345);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(370, 37);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Navy;
            textBox4.Location = new Point(246, 422);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(370, 37);
            textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Navy;
            textBox5.Location = new Point(246, 522);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(370, 37);
            textBox5.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(544, 37);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 25);
            lblWelcome.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblwelcom);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 83);
            panel1.TabIndex = 9;
            // 
            // lblwelcom
            // 
            lblwelcom.AutoSize = true;
            lblwelcom.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcom.ForeColor = Color.Purple;
            lblwelcom.Location = new Point(54, 23);
            lblwelcom.Margin = new Padding(4, 0, 4, 0);
            lblwelcom.Name = "lblwelcom";
            lblwelcom.Padding = new Padding(429, 0, 429, 0);
            lblwelcom.Size = new Size(979, 48);
            lblwelcom.TabIndex = 0;
            lblwelcom.Text = "label1";
            // 
            // lblAttendanceStatus
            // 
            lblAttendanceStatus.AutoSize = true;
            lblAttendanceStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttendanceStatus.Location = new Point(669, 610);
            lblAttendanceStatus.Name = "lblAttendanceStatus";
            lblAttendanceStatus.Size = new Size(96, 38);
            lblAttendanceStatus.TabIndex = 10;
            lblAttendanceStatus.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.business1;
            pictureBox1.Location = new Point(748, 427);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // studentdashboardview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1063, 691);
            Controls.Add(pictureBox1);
            Controls.Add(lblAttendanceStatus);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblNIC);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblMail);
            Controls.Add(lblUserName);
            Controls.Add(Studentdashboard);
            Controls.Add(pictureBoxstudent);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "studentdashboardview";
            Text = "studentdashboardview";
            Load += studentdashboardview_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxstudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxstudent;
        private ListBox Studentdashboard;
        private Label lblUserName;
        private Label lblMail;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblNIC;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel paneltopstu;
        private Label lblWelcome;
        private Panel panel1;
        private Label lblwelcom;
        private Label lblAttendanceStatus;
        private PictureBox pictureBox1;
    }
}