namespace Unicomtic_manegment_system.view
{
    partial class Attandance
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtusersusername = new ComboBox();
            txtStudentName = new TextBox();
            cmbStatus = new ComboBox();
            dataGridViewAttendance = new DataGridView();
            btnaddd = new Button();
            btndel = new Button();
            btnubdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dtpDate = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 112);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(302, 33);
            label1.Name = "label1";
            label1.Size = new Size(342, 54);
            label1.TabIndex = 0;
            label1.Text = "Attandance\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 255);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 6;
            label2.Text = "UT_Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 194);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 389);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 6;
            label4.Text = "Attendance Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 323);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 6;
            label5.Text = "Student_Name";
            // 
            // txtusersusername
            // 
            txtusersusername.FormattingEnabled = true;
            txtusersusername.Location = new Point(220, 252);
            txtusersusername.Name = "txtusersusername";
            txtusersusername.Size = new Size(300, 33);
            txtusersusername.TabIndex = 8;
            txtusersusername.SelectedIndexChanged += cmbUTNumber_SelectedIndexChanged_1;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(220, 320);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(300, 31);
            txtStudentName.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(220, 386);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(298, 33);
            cmbStatus.TabIndex = 10;
            cmbStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(540, 189);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 62;
            dataGridViewAttendance.Size = new Size(494, 429);
            dataGridViewAttendance.TabIndex = 11;
            dataGridViewAttendance.CellContentClick += dataGridViewAttendance_CellContentClick;
            dataGridViewAttendance.CellMouseClick += dataGridViewAttendance_CellMouseClick;
            // 
            // btnaddd
            // 
            btnaddd.BackColor = Color.DarkGreen;
            btnaddd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddd.ForeColor = SystemColors.ControlLightLight;
            btnaddd.Location = new Point(26, 524);
            btnaddd.Name = "btnaddd";
            btnaddd.Size = new Size(112, 52);
            btnaddd.TabIndex = 12;
            btnaddd.Text = "ADD";
            btnaddd.UseVisualStyleBackColor = false;
            btnaddd.Click += btnaddd_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.DarkGreen;
            btndel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndel.ForeColor = SystemColors.ControlLightLight;
            btndel.Location = new Point(204, 524);
            btndel.Name = "btndel";
            btndel.Size = new Size(112, 52);
            btndel.TabIndex = 16;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // btnubdate
            // 
            btnubdate.BackColor = Color.DarkGreen;
            btnubdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnubdate.ForeColor = SystemColors.ControlLightLight;
            btnubdate.Location = new Point(394, 524);
            btnubdate.Name = "btnubdate";
            btnubdate.Size = new Size(112, 52);
            btnubdate.TabIndex = 17;
            btnubdate.Text = "Ubdate";
            btnubdate.UseVisualStyleBackColor = false;
            btnubdate.Click += btnubdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGreen;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(922, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 52);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnserch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(719, 131);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(197, 31);
            txtSearch.TabIndex = 19;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(220, 194);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(298, 31);
            dtpDate.TabIndex = 20;
            dtpDate.VisibleChanged += dtpDate_VisibleChanged_1;
            // 
            // Attandance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 639);
            Controls.Add(dtpDate);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnubdate);
            Controls.Add(btndel);
            Controls.Add(btnaddd);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(cmbStatus);
            Controls.Add(txtStudentName);
            Controls.Add(txtusersusername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Attandance";
            Text = "Attandance";
            Load += Attandance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox txtusersusername;
        private TextBox txtStudentName;
        private ComboBox cmbStatus;
        private DataGridView dataGridViewAttendance;
        private Button btnaddd;
        private Button btndel;
        private Button btnubdate;
        private Button btnSearch;
        private TextBox txtSearch;
        private DateTimePicker dtpDate;
    }
}