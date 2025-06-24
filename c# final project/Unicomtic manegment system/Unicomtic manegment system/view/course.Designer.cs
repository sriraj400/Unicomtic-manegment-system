namespace Unicomtic_manegment_system.view
{
    partial class course
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
            txtcoursename = new TextBox();
            btndeletec = new Button();
            btnupdatec = new Button();
            btnaddc = new Button();
            txtcourseidc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comsubjectc = new ComboBox();
            label4 = new Label();
            dataGridViewcourse = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcourse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 88);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(449, 18);
            label1.Name = "label1";
            label1.Size = new Size(144, 48);
            label1.TabIndex = 0;
            label1.Text = "Subject";
            // 
            // txtcoursename
            // 
            txtcoursename.Location = new Point(223, 133);
            txtcoursename.Name = "txtcoursename";
            txtcoursename.Size = new Size(303, 31);
            txtcoursename.TabIndex = 8;
            // 
            // btndeletec
            // 
            btndeletec.BackColor = Color.Blue;
            btndeletec.ForeColor = SystemColors.ControlLightLight;
            btndeletec.Location = new Point(406, 373);
            btndeletec.Name = "btndeletec";
            btndeletec.Size = new Size(120, 47);
            btndeletec.TabIndex = 7;
            btndeletec.Text = "DELETE";
            btndeletec.UseVisualStyleBackColor = false;
            btndeletec.Click += btndeletec_Click;
            // 
            // btnupdatec
            // 
            btnupdatec.BackColor = Color.Blue;
            btnupdatec.ForeColor = SystemColors.ControlLightLight;
            btnupdatec.Location = new Point(200, 373);
            btnupdatec.Name = "btnupdatec";
            btnupdatec.Size = new Size(120, 47);
            btnupdatec.TabIndex = 7;
            btnupdatec.Text = "UPDATE";
            btnupdatec.UseVisualStyleBackColor = false;
            btnupdatec.Click += btnupdatec_Click;
            // 
            // btnaddc
            // 
            btnaddc.BackColor = Color.Blue;
            btnaddc.ForeColor = SystemColors.ControlLightLight;
            btnaddc.Location = new Point(14, 373);
            btnaddc.Name = "btnaddc";
            btnaddc.Size = new Size(120, 47);
            btnaddc.TabIndex = 6;
            btnaddc.Text = "ADD";
            btnaddc.UseVisualStyleBackColor = false;
            btnaddc.Click += btnaddc_Click;
            // 
            // txtcourseidc
            // 
            txtcourseidc.Location = new Point(223, 72);
            txtcourseidc.Name = "txtcourseidc";
            txtcourseidc.Size = new Size(303, 31);
            txtcourseidc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(29, 133);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 1;
            label3.Text = "Subject Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 0;
            label2.Text = "Subject_id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comsubjectc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtcoursename);
            groupBox1.Controls.Add(btndeletec);
            groupBox1.Controls.Add(btnupdatec);
            groupBox1.Controls.Add(btnaddc);
            groupBox1.Controls.Add(txtcourseidc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 512);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course information";
            // 
            // comsubjectc
            // 
            comsubjectc.FormattingEnabled = true;
            comsubjectc.Location = new Point(223, 208);
            comsubjectc.Margin = new Padding(4, 5, 4, 5);
            comsubjectc.Name = "comsubjectc";
            comsubjectc.Size = new Size(301, 33);
            comsubjectc.TabIndex = 10;
            comsubjectc.SelectedIndexChanged += comsubjectc_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(27, 208);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 9;
            label4.Text = "Course Name";
            label4.Click += label4_Click;
            // 
            // dataGridViewcourse
            // 
            dataGridViewcourse.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewcourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcourse.GridColor = SystemColors.ButtonHighlight;
            dataGridViewcourse.Location = new Point(561, 128);
            dataGridViewcourse.Name = "dataGridViewcourse";
            dataGridViewcourse.RowHeadersWidth = 62;
            dataGridViewcourse.Size = new Size(487, 503);
            dataGridViewcourse.TabIndex = 12;
            dataGridViewcourse.CellMouseClick += dataGridView3_CellMouseClick_1;
            // 
            // course
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 687);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewcourse);
            Name = "course";
            Text = "course";
            Load += course_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtcoursename;
        private Button btndeletec;
        private Button btnupdatec;
        private Button btnaddc;
        private TextBox txtcourseidc;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dataGridViewcourse;
        private ComboBox comsubjectc;
        private Label label4;
    }
}