namespace Unicomtic_manegment_system.view
{
    partial class studentadd
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
            dataGridViewstudent = new DataGridView();
            groupBox1 = new GroupBox();
            comcousernames = new ComboBox();
            txtnics = new TextBox();
            label6 = new Label();
            txtstudentname = new TextBox();
            btndelete = new Button();
            btnupdate = new Button();
            btnadd = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtutnumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstudent).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewstudent
            // 
            dataGridViewstudent.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewstudent.GridColor = SystemColors.ButtonHighlight;
            dataGridViewstudent.Location = new Point(576, 140);
            dataGridViewstudent.Name = "dataGridViewstudent";
            dataGridViewstudent.RowHeadersWidth = 62;
            dataGridViewstudent.Size = new Size(458, 494);
            dataGridViewstudent.TabIndex = 6;
            dataGridViewstudent.CellContentClick += dataGridViewstudent_CellContentClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comcousernames);
            groupBox1.Controls.Add(txtnics);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtstudentname);
            groupBox1.Controls.Add(btndelete);
            groupBox1.Controls.Add(btnupdate);
            groupBox1.Controls.Add(btnadd);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtutnumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 512);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student information";
            // 
            // comcousernames
            // 
            comcousernames.FormattingEnabled = true;
            comcousernames.Location = new Point(229, 321);
            comcousernames.Name = "comcousernames";
            comcousernames.Size = new Size(303, 33);
            comcousernames.TabIndex = 11;
         //   comcousernames.SelectedIndexChanged += comcousernames_SelectedIndexChanged;
            // 
            // txtnics
            // 
            txtnics.Location = new Point(229, 263);
            txtnics.Name = "txtnics";
            txtnics.Size = new Size(303, 31);
            txtnics.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(20, 263);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 9;
            label6.Text = "NIC";
            // 
            // txtstudentname
            // 
            txtstudentname.Location = new Point(229, 133);
            txtstudentname.Name = "txtstudentname";
            txtstudentname.Size = new Size(303, 31);
            txtstudentname.TabIndex = 8;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Blue;
            btndelete.ForeColor = SystemColors.ControlLightLight;
            btndelete.Location = new Point(409, 400);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(120, 46);
            btndelete.TabIndex = 7;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Blue;
            btnupdate.ForeColor = SystemColors.ControlLightLight;
            btnupdate.Location = new Point(213, 400);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(120, 46);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Blue;
            btnadd.ForeColor = SystemColors.ControlLightLight;
            btnadd.Location = new Point(20, 400);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(120, 46);
            btnadd.TabIndex = 6;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(229, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2025, 6, 18, 20, 14, 28, 0);
            // 
            // txtutnumber
            // 
            txtutnumber.Location = new Point(229, 71);
            txtutnumber.Name = "txtutnumber";
            txtutnumber.Size = new Size(303, 31);
            txtutnumber.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(20, 321);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 3;
            label5.Text = "Course name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 198);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 2;
            label4.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(20, 133);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 1;
            label3.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(20, 71);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 0;
            label2.Text = "UT Number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 90);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(457, 22);
            label1.Name = "label1";
            label1.Size = new Size(152, 48);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // studentadd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 644);
            Controls.Add(dataGridViewstudent);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "studentadd";
            Text = "studentadd";
            Load += studentadd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewstudent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewstudent;
        private GroupBox groupBox1;
        private TextBox txtnics;
        private Label label6;
        private TextBox txtstudentname;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private DateTimePicker dateTimePicker1;
        private TextBox txtutnumber;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private ComboBox comcousernames;
    }
}