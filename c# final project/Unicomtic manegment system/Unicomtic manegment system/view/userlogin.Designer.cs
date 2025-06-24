namespace Unicomtic_manegment_system.view
{
    partial class userlogin
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
            comrole = new ComboBox();
            label4 = new Label();
            btnsigninu = new Button();
            btnloginu = new Button();
            txtusersusername = new TextBox();
            txtuserspassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonb = new Button();
            SuspendLayout();
            // 
            // comrole
            // 
            comrole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comrole.FormattingEnabled = true;
            comrole.Location = new Point(438, 414);
            comrole.Name = "comrole";
            comrole.Size = new Size(424, 40);
            comrole.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 399);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 55);
            label4.TabIndex = 24;
            label4.Text = "Role";
            // 
            // btnsigninu
            // 
            btnsigninu.BackColor = SystemColors.HotTrack;
            btnsigninu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsigninu.ForeColor = SystemColors.ControlLightLight;
            btnsigninu.Location = new Point(353, 533);
            btnsigninu.Name = "btnsigninu";
            btnsigninu.Size = new Size(194, 61);
            btnsigninu.TabIndex = 22;
            btnsigninu.Text = "Sigin";
            btnsigninu.UseVisualStyleBackColor = false;
            btnsigninu.Click += btnsigninu_Click;
            // 
            // btnloginu
            // 
            btnloginu.BackColor = SystemColors.HotTrack;
            btnloginu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnloginu.ForeColor = SystemColors.ControlLightLight;
            btnloginu.Location = new Point(682, 533);
            btnloginu.Name = "btnloginu";
            btnloginu.Size = new Size(180, 61);
            btnloginu.TabIndex = 23;
            btnloginu.Text = "Login";
            btnloginu.UseVisualStyleBackColor = false;
            btnloginu.Click += btnloginu_Click;
            // 
            // txtusersusername
            // 
            txtusersusername.Anchor = AnchorStyles.None;
            txtusersusername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusersusername.Location = new Point(438, 178);
            txtusersusername.Margin = new Padding(4, 5, 4, 5);
            txtusersusername.Name = "txtusersusername";
            txtusersusername.Size = new Size(424, 45);
            txtusersusername.TabIndex = 18;
            // 
            // txtuserspassword
            // 
            txtuserspassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuserspassword.Location = new Point(438, 291);
            txtuserspassword.Margin = new Padding(4, 5, 4, 5);
            txtuserspassword.Name = "txtuserspassword";
            txtuserspassword.PasswordChar = '*';
            txtuserspassword.Size = new Size(424, 45);
            txtuserspassword.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 281);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 55);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 55);
            label2.TabIndex = 17;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 76);
            label1.TabIndex = 15;
            label1.Text = "Users Login";
            // 
            // buttonb
            // 
            buttonb.BackColor = SystemColors.HotTrack;
            buttonb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonb.ForeColor = SystemColors.ControlLightLight;
            buttonb.Location = new Point(60, 533);
            buttonb.Name = "buttonb";
            buttonb.Size = new Size(194, 61);
            buttonb.TabIndex = 26;
            buttonb.Text = "Back";
            buttonb.UseVisualStyleBackColor = false;
            buttonb.Click += buttonb_Click;
            // 
            // userlogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(928, 724);
            Controls.Add(buttonb);
            Controls.Add(comrole);
            Controls.Add(label4);
            Controls.Add(btnsigninu);
            Controls.Add(btnloginu);
            Controls.Add(txtusersusername);
            Controls.Add(txtuserspassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "userlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userlogin";
            Load += userlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comrole;
        private Label label4;
        private Button btnsigninu;
        private Button btnloginu;
        private TextBox txtusersusername;
        private TextBox txtuserspassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonb;
    }
}