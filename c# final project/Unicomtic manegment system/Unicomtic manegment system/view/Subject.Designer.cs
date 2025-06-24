namespace Unicomtic_manegment_system.view
{
    partial class Subject
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
            groupBox1 = new GroupBox();
            txtsubjectname = new TextBox();
            btndeletesub = new Button();
            btnupdatesub = new Button();
            btnaddsub = new Button();
            txtsubjectid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridViewsub = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsub).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 88);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(449, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 48);
            label1.TabIndex = 0;
            label1.Text = "Course";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtsubjectname);
            groupBox1.Controls.Add(btndeletesub);
            groupBox1.Controls.Add(btnupdatesub);
            groupBox1.Controls.Add(btnaddsub);
            groupBox1.Controls.Add(txtsubjectid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 512);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course information";
            // 
            // txtsubjectname
            // 
            txtsubjectname.Location = new Point(223, 133);
            txtsubjectname.Name = "txtsubjectname";
            txtsubjectname.Size = new Size(303, 31);
            txtsubjectname.TabIndex = 8;
            // 
            // btndeletesub
            // 
            btndeletesub.BackColor = Color.Blue;
            btndeletesub.ForeColor = SystemColors.ControlLightLight;
            btndeletesub.Location = new Point(406, 373);
            btndeletesub.Name = "btndeletesub";
            btndeletesub.Size = new Size(120, 47);
            btndeletesub.TabIndex = 7;
            btndeletesub.Text = "DELETE";
            btndeletesub.UseVisualStyleBackColor = false;
            btndeletesub.Click += btndeletesub_Click;
            // 
            // btnupdatesub
            // 
            btnupdatesub.BackColor = Color.Blue;
            btnupdatesub.ForeColor = SystemColors.ControlLightLight;
            btnupdatesub.Location = new Point(200, 373);
            btnupdatesub.Name = "btnupdatesub";
            btnupdatesub.Size = new Size(120, 47);
            btnupdatesub.TabIndex = 7;
            btnupdatesub.Text = "UPDATE";
            btnupdatesub.UseVisualStyleBackColor = false;
            btnupdatesub.Click += btnupdatesub_Click;
            // 
            // btnaddsub
            // 
            btnaddsub.BackColor = Color.Blue;
            btnaddsub.ForeColor = SystemColors.ControlLightLight;
            btnaddsub.Location = new Point(14, 373);
            btnaddsub.Name = "btnaddsub";
            btnaddsub.Size = new Size(120, 47);
            btnaddsub.TabIndex = 6;
            btnaddsub.Text = "ADD";
            btnaddsub.UseVisualStyleBackColor = false;
            btnaddsub.Click += btnaddsub_Click;
            // 
            // txtsubjectid
            // 
            txtsubjectid.Location = new Point(223, 72);
            txtsubjectid.Name = "txtsubjectid";
            txtsubjectid.Size = new Size(303, 31);
            txtsubjectid.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 1;
            label3.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 0;
            label2.Text = "Course_id";
            // 
            // dataGridViewsub
            // 
            dataGridViewsub.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewsub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsub.GridColor = SystemColors.ButtonHighlight;
            dataGridViewsub.Location = new Point(561, 122);
            dataGridViewsub.Name = "dataGridViewsub";
            dataGridViewsub.RowHeadersWidth = 62;
            dataGridViewsub.Size = new Size(487, 503);
            dataGridViewsub.TabIndex = 15;
            dataGridViewsub.CellMouseClick += dataGridViewsub_CellMouseClick;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 643);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewsub);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Subject";
            Text = "Subject";
            Load += Subject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtsubjectname;
        private Button btndeletesub;
        private Button btnupdatesub;
        private Button btnaddsub;
        private TextBox txtsubjectid;
        private Label label3;
        private Label label2;
        private DataGridView dataGridViewsub;
    }
}