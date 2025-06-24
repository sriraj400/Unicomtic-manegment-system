namespace Unicomtic_manegment_system.view
{
    partial class Addfeedback
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
            label1 = new Label();
            panel1 = new Panel();
            rtxtFeedback = new RichTextBox();
            button1 = new Button();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            cmbRating = new ComboBox();
            btnclear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(198, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(404, 35);
            label1.TabIndex = 0;
            label1.Text = "Add feedback Details";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 67);
            panel1.TabIndex = 3;
            // 
            // rtxtFeedback
            // 
            rtxtFeedback.Location = new Point(41, 165);
            rtxtFeedback.Name = "rtxtFeedback";
            rtxtFeedback.Size = new Size(679, 152);
            rtxtFeedback.TabIndex = 4;
            rtxtFeedback.Text = "";
            rtxtFeedback.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(41, 334);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 83);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 6;
            label2.Text = "UT_Number";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(189, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 25);
            txtName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 125);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 8;
            label3.Text = "Rating";
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(189, 125);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(243, 23);
            cmbRating.TabIndex = 9;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.HotTrack;
            btnclear.ForeColor = SystemColors.ControlLightLight;
            btnclear.Location = new Point(520, 334);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(111, 40);
            btnclear.TabIndex = 10;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // Addfeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(734, 386);
            Controls.Add(btnclear);
            Controls.Add(cmbRating);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(rtxtFeedback);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Addfeedback";
            Text = "viewfeedback";
            Load += Addfeedback_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RichTextBox rtxtFeedback;
        private Button button1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private ComboBox cmbRating;
        private Button btnclear;
    }
}