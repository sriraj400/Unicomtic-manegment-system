namespace Unicomtic_manegment_system.view
{
    partial class loginaddmin
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
            btnsignin = new Button();
            btnlogin = new Button();
            txtadminusername = new TextBox();
            txtadminpassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnsignin
            // 
            btnsignin.BackColor = SystemColors.HotTrack;
            btnsignin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignin.ForeColor = SystemColors.ControlLightLight;
            btnsignin.Location = new Point(74, 494);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(194, 61);
            btnsignin.TabIndex = 9;
            btnsignin.Text = "Back";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.HotTrack;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ControlLightLight;
            btnlogin.Location = new Point(629, 494);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(180, 61);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtadminusername
            // 
            txtadminusername.Anchor = AnchorStyles.None;
            txtadminusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadminusername.Location = new Point(384, 185);
            txtadminusername.Name = "txtadminusername";
            txtadminusername.Size = new Size(425, 39);
            txtadminusername.TabIndex = 7;
            txtadminusername.TextChanged += txtadminusername_TextChanged;
            // 
            // txtadminpassword
            // 
            txtadminpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadminpassword.Location = new Point(384, 310);
            txtadminpassword.Name = "txtadminpassword";
            txtadminpassword.PasswordChar = '*';
            txtadminpassword.Size = new Size(425, 39);
            txtadminpassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 295);
            label3.Name = "label3";
            label3.Size = new Size(205, 55);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 169);
            label2.Name = "label2";
            label2.Size = new Size(235, 55);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 41);
            label1.Name = "label1";
            label1.Size = new Size(361, 76);
            label1.TabIndex = 4;
            label1.Text = "Admin Login";
            // 
            // loginaddmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(881, 641);
            Controls.Add(btnsignin);
            Controls.Add(btnlogin);
            Controls.Add(txtadminusername);
            Controls.Add(txtadminpassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginaddmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginaddmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsignin;
        private Button btnlogin;
        private TextBox txtadminusername;
        private TextBox txtadminpassword;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}