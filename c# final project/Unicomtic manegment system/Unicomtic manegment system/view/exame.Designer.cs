namespace Unicomtic_manegment_system.view
{
    partial class exame
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
            commarks = new ComboBox();
            label6 = new Label();
            txtexameide = new TextBox();
            btndeletee = new Button();
            btnupdatee = new Button();
            btnadde = new Button();
            groupBox1 = new GroupBox();
            coms = new ComboBox();
            comc = new ComboBox();
            label7 = new Label();
            comutnumbere = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridexame = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridexame).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 105);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(476, 28);
            label1.Name = "label1";
            label1.Size = new Size(130, 48);
            label1.TabIndex = 0;
            label1.Text = "Exame";
            // 
            // commarks
            // 
            commarks.FormattingEnabled = true;
            commarks.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            commarks.Location = new Point(223, 361);
            commarks.Name = "commarks";
            commarks.Size = new Size(303, 33);
            commarks.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(14, 357);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 9;
            label6.Text = "Marks";
            // 
            // txtexameide
            // 
            txtexameide.Location = new Point(223, 133);
            txtexameide.Name = "txtexameide";
            txtexameide.Size = new Size(303, 31);
            txtexameide.TabIndex = 8;
            // 
            // btndeletee
            // 
            btndeletee.BackColor = Color.Blue;
            btndeletee.ForeColor = SystemColors.ControlLightLight;
            btndeletee.Location = new Point(403, 400);
            btndeletee.Name = "btndeletee";
            btndeletee.Size = new Size(120, 47);
            btndeletee.TabIndex = 7;
            btndeletee.Text = "DELETE";
            btndeletee.UseVisualStyleBackColor = false;
            btndeletee.Click += btndeletee_Click;
            // 
            // btnupdatee
            // 
            btnupdatee.BackColor = Color.Blue;
            btnupdatee.ForeColor = SystemColors.ControlLightLight;
            btnupdatee.Location = new Point(207, 400);
            btnupdatee.Name = "btnupdatee";
            btnupdatee.Size = new Size(120, 47);
            btnupdatee.TabIndex = 7;
            btnupdatee.Text = "UPDATE";
            btnupdatee.UseVisualStyleBackColor = false;
            btnupdatee.Click += btnupdatee_Click;
            // 
            // btnadde
            // 
            btnadde.BackColor = Color.Blue;
            btnadde.ForeColor = SystemColors.ControlLightLight;
            btnadde.Location = new Point(14, 400);
            btnadde.Name = "btnadde";
            btnadde.Size = new Size(120, 47);
            btnadde.TabIndex = 6;
            btnadde.Text = "ADD";
            btnadde.UseVisualStyleBackColor = false;
            btnadde.Click += btnadde_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(coms);
            groupBox1.Controls.Add(comc);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comutnumbere);
            groupBox1.Controls.Add(commarks);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtexameide);
            groupBox1.Controls.Add(btndeletee);
            groupBox1.Controls.Add(btnupdatee);
            groupBox1.Controls.Add(btnadde);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 512);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exame information";
            // 
            // coms
            // 
            coms.FormattingEnabled = true;
            coms.Location = new Point(221, 305);
            coms.Name = "coms";
            coms.Size = new Size(302, 33);
            coms.TabIndex = 15;
            // 
            // comc
            // 
            comc.FormattingEnabled = true;
            comc.Location = new Point(220, 260);
            comc.Name = "comc";
            comc.Size = new Size(303, 33);
            comc.TabIndex = 14;
            comc.SelectedIndexChanged += comc_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(18, 260);
            label7.Name = "label7";
            label7.Size = new Size(171, 28);
            label7.TabIndex = 13;
            label7.Text = "Course_name";
            // 
            // comutnumbere
            // 
            comutnumbere.FormattingEnabled = true;
            comutnumbere.Location = new Point(223, 72);
            comutnumbere.Margin = new Padding(4, 5, 4, 5);
            comutnumbere.Name = "comutnumbere";
            comutnumbere.Size = new Size(300, 33);
            comutnumbere.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(223, 197);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 5;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(14, 305);
            label5.Name = "label5";
            label5.Size = new Size(175, 28);
            label5.TabIndex = 3;
            label5.Text = "Subject_name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 198);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
            label4.TabIndex = 2;
            label4.Text = "Exame date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(14, 133);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 1;
            label3.Text = "Exame_id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 0;
            label2.Text = "UT Number";
            // 
            // dataGridexame
            // 
            dataGridexame.BackgroundColor = SystemColors.ButtonFace;
            dataGridexame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridexame.GridColor = SystemColors.ButtonHighlight;
            dataGridexame.Location = new Point(551, 143);
            dataGridexame.Name = "dataGridexame";
            dataGridexame.RowHeadersWidth = 62;
            dataGridexame.Size = new Size(497, 493);
            dataGridexame.TabIndex = 9;
            dataGridexame.CellMouseClick += dataGridexame_CellMouseClick;
            // 
            // exame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 643);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridexame);
            Name = "exame";
            Text = "exame";
            Load += exame_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridexame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox commarks;
        private Label label6;
        private TextBox txtexameide;
        private Button btndeletee;
        private Button btnupdatee;
        private Button btnadde;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridexame;
        private ComboBox comutnumbere;
        private Label label7;
        private ComboBox coms;
        private ComboBox comc;
    }
}