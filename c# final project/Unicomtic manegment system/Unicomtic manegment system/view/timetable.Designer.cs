namespace Unicomtic_manegment_system.view
{
    partial class timetable
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
            btnPrevWeek = new Button();
            dataGridViewTimetable = new DataGridView();
            btnNextWeek = new Button();
            btnsave = new Button();
            btnubdate = new Button();
            btndelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).BeginInit();
            SuspendLayout();
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.BackColor = SystemColors.ControlText;
            btnPrevWeek.ForeColor = SystemColors.ControlLightLight;
            btnPrevWeek.Location = new Point(30, 591);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(111, 46);
            btnPrevWeek.TabIndex = 5;
            btnPrevWeek.Text = "LastWeek";
            btnPrevWeek.UseVisualStyleBackColor = false;
            btnPrevWeek.Click += btnPrevWeek_Click;
            // 
            // dataGridViewTimetable
            // 
            dataGridViewTimetable.AllowUserToOrderColumns = true;
            dataGridViewTimetable.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetable.Location = new Point(12, 79);
            dataGridViewTimetable.Name = "dataGridViewTimetable";
            dataGridViewTimetable.RowHeadersWidth = 62;
            dataGridViewTimetable.Size = new Size(1060, 478);
            dataGridViewTimetable.TabIndex = 4;
            // 
            // btnNextWeek
            // 
            btnNextWeek.BackColor = SystemColors.ActiveCaptionText;
            btnNextWeek.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNextWeek.ForeColor = SystemColors.ControlLightLight;
            btnNextWeek.Location = new Point(960, 584);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(112, 46);
            btnNextWeek.TabIndex = 6;
            btnNextWeek.Text = "NextWeek";
            btnNextWeek.UseVisualStyleBackColor = false;
            btnNextWeek.Click += btnNextWeek_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DarkGreen;
            btnsave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.ForeColor = SystemColors.ControlLightLight;
            btnsave.Location = new Point(257, 591);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 46);
            btnsave.TabIndex = 8;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnubdate
            // 
            btnubdate.BackColor = SystemColors.HotTrack;
            btnubdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnubdate.ForeColor = SystemColors.ControlLightLight;
            btnubdate.Location = new Point(527, 590);
            btnubdate.Name = "btnubdate";
            btnubdate.Size = new Size(112, 46);
            btnubdate.TabIndex = 9;
            btnubdate.Text = "Ubdate";
            btnubdate.UseVisualStyleBackColor = false;
            btnubdate.Click += btnubdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.DarkGreen;
            btndelete.ForeColor = SystemColors.ControlLightLight;
            btndelete.Location = new Point(752, 585);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 46);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(450, 3, 450, 0);
            label1.Size = new Size(1205, 57);
            label1.TabIndex = 11;
            label1.Text = "ADD Time Table";
            label1.Click += label1_Click;
            // 
            // timetable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1103, 643);
            Controls.Add(label1);
            Controls.Add(btndelete);
            Controls.Add(btnubdate);
            Controls.Add(btnsave);
            Controls.Add(btnNextWeek);
            Controls.Add(btnPrevWeek);
            Controls.Add(dataGridViewTimetable);
            Name = "timetable";
            Text = "timetable";
            Load += timetable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPrevWeek;
        private DataGridView dataGridViewTimetable;
        private Button btnNextWeek;
        private Button btnsave;
        private Button btnubdate;
        private Button btndelete;
        private Label label1;
    }
}