namespace ExodusLogin
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            Exit = new Button();
            SetLogin = new Button();
            Info = new Label();
            pictureBox1 = new PictureBox();
            MailBox = new TextBox();
            PasswordBox = new TextBox();
            MailLabel = new Label();
            PasswordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderColor = Color.Magenta;
            Exit.FlatAppearance.MouseDownBackColor = Color.Black;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.ForeColor = Color.Magenta;
            Exit.Location = new Point(205, 203);
            Exit.Name = "Exit";
            Exit.Size = new Size(168, 32);
            Exit.TabIndex = 0;
            Exit.Text = "Exit Application";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // SetLogin
            // 
            SetLogin.FlatAppearance.BorderColor = Color.Magenta;
            SetLogin.FlatAppearance.MouseDownBackColor = Color.Black;
            SetLogin.FlatStyle = FlatStyle.Flat;
            SetLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SetLogin.ForeColor = Color.Magenta;
            SetLogin.Location = new Point(12, 203);
            SetLogin.Name = "SetLogin";
            SetLogin.Size = new Size(172, 32);
            SetLogin.TabIndex = 1;
            SetLogin.Text = "Login to Exodus Mod Menu";
            SetLogin.UseVisualStyleBackColor = true;
            SetLogin.Click += SetLogin_Click;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Dock = DockStyle.Top;
            Info.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Info.ForeColor = Color.Magenta;
            Info.Location = new Point(0, 0);
            Info.Name = "Info";
            Info.Size = new Size(223, 15);
            Info.TabIndex = 2;
            Info.Text = "Login Helper For Exodus Mod Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(274, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 96);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MailBox
            // 
            MailBox.BorderStyle = BorderStyle.None;
            MailBox.Location = new Point(12, 85);
            MailBox.Name = "MailBox";
            MailBox.Size = new Size(162, 16);
            MailBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Location = new Point(12, 129);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(162, 16);
            PasswordBox.TabIndex = 5;
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MailLabel.ForeColor = Color.Magenta;
            MailLabel.Location = new Point(9, 67);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(44, 15);
            MailLabel.TabIndex = 6;
            MailLabel.Text = "Email:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.Magenta;
            PasswordLabel.Location = new Point(9, 111);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(69, 15);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "Password:";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(385, 247);
            Controls.Add(PasswordLabel);
            Controls.Add(MailLabel);
            Controls.Add(PasswordBox);
            Controls.Add(MailBox);
            Controls.Add(pictureBox1);
            Controls.Add(Info);
            Controls.Add(SetLogin);
            Controls.Add(Exit);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Welcome";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button SetLogin;
        private Label Info;
        private PictureBox pictureBox1;
        private TextBox MailBox;
        private TextBox PasswordBox;
        private Label MailLabel;
        private Label PasswordLabel;
    }
}