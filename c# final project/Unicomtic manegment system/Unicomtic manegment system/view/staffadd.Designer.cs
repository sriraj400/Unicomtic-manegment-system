namespace Unicomtic_manegment_system.view
{
    partial class staffadd
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
            groupBox1 = new GroupBox();
            comwork = new ComboBox();
            label6 = new Label();
            txtstaffname = new TextBox();
            btndeletes = new Button();
            btnupdates = new Button();
            btnadds = new Button();
            dateTimePicker2 = new DateTimePicker();
            txtnic = new TextBox();
            txtstaffid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridVie4 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVie4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comwork);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtstaffname);
            groupBox1.Controls.Add(btndeletes);
            groupBox1.Controls.Add(btnupdates);
            groupBox1.Controls.Add(btnadds);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(txtnic);
            groupBox1.Controls.Add(txtstaffid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 512);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff information";
            // 
            // comwork
            // 
            comwork.FormattingEnabled = true;
            comwork.Location = new Point(220, 328);
            comwork.Margin = new Padding(4, 5, 4, 5);
            comwork.Name = "comwork";
            comwork.Size = new Size(298, 33);
            comwork.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(13, 328);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 9;
            label6.Text = "Work";
            // 
            // txtstaffname
            // 
            txtstaffname.Location = new Point(220, 133);
            txtstaffname.Name = "txtstaffname";
            txtstaffname.Size = new Size(303, 31);
            txtstaffname.TabIndex = 8;
            // 
            // btndeletes
            // 
            btndeletes.BackColor = Color.Blue;
            btndeletes.ForeColor = SystemColors.ControlLightLight;
            btndeletes.Location = new Point(400, 400);
            btndeletes.Name = "btndeletes";
            btndeletes.Size = new Size(120, 47);
            btndeletes.TabIndex = 7;
            btndeletes.Text = "DELETE";
            btndeletes.UseVisualStyleBackColor = false;
            btndeletes.Click += btndeletes_Click;
            // 
            // btnupdates
            // 
            btnupdates.BackColor = Color.Blue;
            btnupdates.ForeColor = SystemColors.ControlLightLight;
            btnupdates.Location = new Point(204, 400);
            btnupdates.Name = "btnupdates";
            btnupdates.Size = new Size(120, 47);
            btnupdates.TabIndex = 7;
            btnupdates.Text = "UPDATE";
            btnupdates.UseVisualStyleBackColor = false;
            btnupdates.Click += btnupdates_Click;
            // 
            // btnadds
            // 
            btnadds.BackColor = Color.Blue;
            btnadds.ForeColor = SystemColors.ControlLightLight;
            btnadds.Location = new Point(11, 400);
            btnadds.Name = "btnadds";
            btnadds.Size = new Size(120, 47);
            btnadds.TabIndex = 6;
            btnadds.Text = "ADD";
            btnadds.UseVisualStyleBackColor = false;
            btnadds.Click += btnadds_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(220, 197);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // txtnic
            // 
            txtnic.Location = new Point(220, 263);
            txtnic.Name = "txtnic";
            txtnic.Size = new Size(303, 31);
            txtnic.TabIndex = 4;
            // 
            // txtstaffid
            // 
            txtstaffid.Location = new Point(220, 72);
            txtstaffid.Name = "txtstaffid";
            txtstaffid.Size = new Size(303, 31);
            txtstaffid.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 263);
            label5.Name = "label5";
            label5.Size = new Size(56, 28);
            label5.TabIndex = 3;
            label5.Text = "NIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(11, 198);
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
            label3.Location = new Point(11, 133);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 1;
            label3.Text = "Staff Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 0;
            label2.Text = "Staff_Id";
            // 
            // dataGridVie4
            // 
            dataGridVie4.BackgroundColor = SystemColors.ButtonFace;
            dataGridVie4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVie4.GridColor = SystemColors.ButtonHighlight;
            dataGridVie4.Location = new Point(554, 132);
            dataGridVie4.Name = "dataGridVie4";
            dataGridVie4.RowHeadersWidth = 62;
            dataGridVie4.Size = new Size(481, 500);
            dataGridVie4.TabIndex = 12;
            dataGridVie4.CellMouseClick += dataGridVie4_CellMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 98);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(481, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 48);
            label1.TabIndex = 0;
            label1.Text = "Staff";
            // 
            // staffadd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 643);
            Controls.Add(groupBox1);
            Controls.Add(dataGridVie4);
            Controls.Add(panel1);
            Name = "staffadd";
            Text = "staffadd";
            Load += staffadd_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVie4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtstaffname;
        private Button btndeletes;
        private Button btnupdates;
        private Button btnadds;
        private DateTimePicker dateTimePicker2;
        private TextBox txtnic;
        private TextBox txtstaffid;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridVie4;
        private Panel panel1;
        private Label label1;
        private ComboBox comwork;
        private Label label6;
    }
}