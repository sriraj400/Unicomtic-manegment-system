namespace Unicomtic_manegment_system.view
{
    partial class feedback
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
            dataGridfeedback = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnview = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridfeedback).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridfeedback
            // 
            dataGridfeedback.BackgroundColor = SystemColors.ButtonFace;
            dataGridfeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridfeedback.GridColor = SystemColors.ButtonHighlight;
            dataGridfeedback.Location = new Point(8, 86);
            dataGridfeedback.Margin = new Padding(2);
            dataGridfeedback.Name = "dataGridfeedback";
            dataGridfeedback.RowHeadersWidth = 62;
            dataGridfeedback.Size = new Size(717, 220);
            dataGridfeedback.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 63);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(241, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Feed Back";
            // 
            // btnview
            // 
            btnview.BackColor = Color.Blue;
            btnview.ForeColor = SystemColors.ControlLightLight;
            btnview.Location = new Point(50, 334);
            btnview.Margin = new Padding(2);
            btnview.Name = "btnview";
            btnview.Size = new Size(110, 34);
            btnview.TabIndex = 14;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnview_Click;
            // 
            // feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 386);
            Controls.Add(dataGridfeedback);
            Controls.Add(panel1);
            Controls.Add(btnview);
            Margin = new Padding(2);
            Name = "feedback";
            Text = "feedback";
            Load += feedback_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridfeedback).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridfeedback;
        private Panel panel1;
        private Label label1;
        private Button btnview;
    }
}