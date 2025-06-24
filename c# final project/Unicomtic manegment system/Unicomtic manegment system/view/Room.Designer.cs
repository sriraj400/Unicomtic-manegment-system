namespace Unicomtic_manegment_system.view
{
    partial class Room
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
            txtroomname = new TextBox();
            btndeleteroom = new Button();
            btnupdateroom = new Button();
            btnaddroom = new Button();
            txtroomid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridViewroom = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewroom).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 88);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(449, 18);
            label1.Name = "label1";
            label1.Size = new Size(199, 48);
            label1.TabIndex = 0;
            label1.Text = "Room Add";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtroomname);
            groupBox1.Controls.Add(btndeleteroom);
            groupBox1.Controls.Add(btnupdateroom);
            groupBox1.Controls.Add(btnaddroom);
            groupBox1.Controls.Add(txtroomid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 512);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course information";
            // 
            // txtroomname
            // 
            txtroomname.Location = new Point(223, 133);
            txtroomname.Name = "txtroomname";
            txtroomname.Size = new Size(303, 31);
            txtroomname.TabIndex = 8;
            // 
            // btndeleteroom
            // 
            btndeleteroom.BackColor = Color.Blue;
            btndeleteroom.ForeColor = SystemColors.ControlLightLight;
            btndeleteroom.Location = new Point(406, 373);
            btndeleteroom.Name = "btndeleteroom";
            btndeleteroom.Size = new Size(120, 47);
            btndeleteroom.TabIndex = 7;
            btndeleteroom.Text = "DELETE";
            btndeleteroom.UseVisualStyleBackColor = false;
            btndeleteroom.Click += btndeleteroom_Click;
            // 
            // btnupdateroom
            // 
            btnupdateroom.BackColor = Color.Blue;
            btnupdateroom.ForeColor = SystemColors.ControlLightLight;
            btnupdateroom.Location = new Point(200, 373);
            btnupdateroom.Name = "btnupdateroom";
            btnupdateroom.Size = new Size(120, 47);
            btnupdateroom.TabIndex = 7;
            btnupdateroom.Text = "UPDATE";
            btnupdateroom.UseVisualStyleBackColor = false;
            btnupdateroom.Click += btnupdateroom_Click;
            // 
            // btnaddroom
            // 
            btnaddroom.BackColor = Color.Blue;
            btnaddroom.ForeColor = SystemColors.ControlLightLight;
            btnaddroom.Location = new Point(14, 373);
            btnaddroom.Name = "btnaddroom";
            btnaddroom.Size = new Size(120, 47);
            btnaddroom.TabIndex = 6;
            btnaddroom.Text = "ADD";
            btnaddroom.UseVisualStyleBackColor = false;
            btnaddroom.Click += btnaddroom_Click;
            // 
            // txtroomid
            // 
            txtroomid.Location = new Point(223, 72);
            txtroomid.Name = "txtroomid";
            txtroomid.Size = new Size(303, 31);
            txtroomid.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 1;
            label3.Text = "RoomName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 0;
            label2.Text = "Roomid";
            label2.Click += label2_Click;
            // 
            // dataGridViewroom
            // 
            dataGridViewroom.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewroom.GridColor = SystemColors.ButtonHighlight;
            dataGridViewroom.Location = new Point(561, 132);
            dataGridViewroom.Name = "dataGridViewroom";
            dataGridViewroom.RowHeadersWidth = 62;
            dataGridViewroom.Size = new Size(487, 503);
            dataGridViewroom.TabIndex = 18;
            dataGridViewroom.CellMouseClick += dataGridViewroom_CellMouseClick;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 644);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewroom);
            Name = "Room";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room";
            Load += Room_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewroom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtroomname;
        private Button btndeleteroom;
        private Button btnupdateroom;
        private Button btnaddroom;
        private TextBox txtroomid;
        private Label label3;
        private Label label2;
        private DataGridView dataGridViewroom;
    }
}