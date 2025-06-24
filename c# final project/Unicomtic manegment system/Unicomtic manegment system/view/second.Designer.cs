namespace Unicomtic_manegment_system.view
{
    partial class second
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
            btnuersview = new Button();
            btnadminview = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnuersview
            // 
            btnuersview.BackColor = SystemColors.HotTrack;
            btnuersview.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnuersview.ForeColor = SystemColors.ControlLightLight;
            btnuersview.Location = new Point(563, 422);
            btnuersview.Name = "btnuersview";
            btnuersview.Size = new Size(285, 78);
            btnuersview.TabIndex = 5;
            btnuersview.Text = "Users";
            btnuersview.UseVisualStyleBackColor = false;
            btnuersview.Click += btnuersview_Click;
            // 
            // btnadminview
            // 
            btnadminview.BackColor = SystemColors.HotTrack;
            btnadminview.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadminview.ForeColor = SystemColors.ControlLightLight;
            btnadminview.Location = new Point(563, 249);
            btnadminview.Name = "btnadminview";
            btnadminview.Size = new Size(285, 78);
            btnadminview.TabIndex = 6;
            btnadminview.Text = "Admin";
            btnadminview.UseMnemonic = false;
            btnadminview.UseVisualStyleBackColor = false;
            btnadminview.Click += btnadminview_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuText;
            label1.Font = new Font("Microsoft Sans Serif", 31F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(-12, 36);
            label1.Margin = new Padding(4, 0, 0, 8);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 15, 0, 25);
            label1.Size = new Size(916, 111);
            label1.TabIndex = 4;
            label1.Text = "Unicomtic management system";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unilogo;
            pictureBox1.Location = new Point(27, 172);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // second
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = Properties.Resources.images__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 677);
            Controls.Add(pictureBox1);
            Controls.Add(btnuersview);
            Controls.Add(btnadminview);
            Controls.Add(label1);
            Name = "second";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "second";
            Load += second_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnuersview;
        private Button btnadminview;
        private Label label1;
        private PictureBox pictureBox1;
    }
}