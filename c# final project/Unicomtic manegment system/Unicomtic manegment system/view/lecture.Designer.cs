namespace Unicomtic_manegment_system.view
{
    partial class l
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
            txtnicl = new TextBox();
            label6 = new Label();
            txtlecturename = new TextBox();
            btndeletel = new Button();
            btnupdatel = new Button();
            btnaddl = new Button();
            dateTimePicker2 = new DateTimePicker();
            txtlectureid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comcoursenamel = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            dataGridView3 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // txtnicl
            // 
            txtnicl.Location = new Point(221, 258);
            txtnicl.Name = "txtnicl";
            txtnicl.Size = new Size(303, 31);
            txtnicl.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(11, 258);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 9;
            label6.Text = "NIC";
            // 
            // txtlecturename
            // 
            txtlecturename.Location = new Point(221, 127);
            txtlecturename.Name = "txtlecturename";
            txtlecturename.Size = new Size(303, 31);
            txtlecturename.TabIndex = 8;
            // 
            // btndeletel
            // 
            btndeletel.BackColor = Color.Blue;
            btndeletel.ForeColor = SystemColors.ControlLightLight;
            btndeletel.Location = new Point(401, 393);
            btndeletel.Name = "btndeletel";
            btndeletel.Size = new Size(120, 47);
            btndeletel.TabIndex = 7;
            btndeletel.Text = "DELETE";
            btndeletel.UseVisualStyleBackColor = false;
            btndeletel.Click += btndeletel_Click;
            // 
            // btnupdatel
            // 
            btnupdatel.BackColor = Color.Blue;
            btnupdatel.ForeColor = SystemColors.ControlLightLight;
            btnupdatel.Location = new Point(206, 393);
            btnupdatel.Name = "btnupdatel";
            btnupdatel.Size = new Size(120, 47);
            btnupdatel.TabIndex = 7;
            btnupdatel.Text = "UPDATE";
            btnupdatel.UseVisualStyleBackColor = false;
            btnupdatel.Click += btnupdatel_Click_1;
            // 
            // btnaddl
            // 
            btnaddl.BackColor = Color.Blue;
            btnaddl.ForeColor = SystemColors.ControlLightLight;
            btnaddl.Location = new Point(11, 393);
            btnaddl.Name = "btnaddl";
            btnaddl.Size = new Size(120, 47);
            btnaddl.TabIndex = 6;
            btnaddl.Text = "ADD";
            btnaddl.UseVisualStyleBackColor = false;
            btnaddl.Click += btnaddl_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(221, 188);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // txtlectureid
            // 
            txtlectureid.Location = new Point(221, 63);
            txtlectureid.Name = "txtlectureid";
            txtlectureid.Size = new Size(303, 31);
            txtlectureid.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(11, 192);
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
            label3.Location = new Point(11, 127);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 1;
            label3.Text = "Lecture Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(11, 67);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 0;
            label2.Text = "Lecture_Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(434, 20);
            label1.Name = "label1";
            label1.Size = new Size(159, 48);
            label1.TabIndex = 0;
            label1.Text = "Lectures";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comcoursenamel);
            groupBox1.Controls.Add(txtnicl);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtlecturename);
            groupBox1.Controls.Add(btndeletel);
            groupBox1.Controls.Add(btnupdatel);
            groupBox1.Controls.Add(btnaddl);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(txtlectureid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 512);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "lecture information";
            // 
            // comcoursenamel
            // 
            comcoursenamel.FormattingEnabled = true;
            comcoursenamel.Location = new Point(221, 315);
            comcoursenamel.Margin = new Padding(4, 5, 4, 5);
            comcoursenamel.Name = "comcoursenamel";
            comcoursenamel.Size = new Size(298, 33);
            comcoursenamel.TabIndex = 11;
            comcoursenamel.SelectedIndexChanged += comcoursenamel_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 315);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 3;
            label5.Text = "Course_name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 97);
            panel1.TabIndex = 8;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ButtonFace;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = SystemColors.ButtonHighlight;
            dataGridView3.Location = new Point(557, 135);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(479, 493);
            dataGridView3.TabIndex = 9;
            dataGridView3.CellMouseClick += dataGridView3_CellMouseClick;
            // 
            // l
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 643);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView3);
            Name = "l";
            Text = "lecture";
            Load += lecture_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtnicl;
        private Label label6;
        private TextBox txtlecturename;
        private Button btndeletel;
        private Button btnupdatel;
        private Button btnaddl;
        private DateTimePicker dateTimePicker2;
        private TextBox txtlectureid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView dataGridView3;
        private Label label5;
        private ComboBox comcoursenamel;
    }
}