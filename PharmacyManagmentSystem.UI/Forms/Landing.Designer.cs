namespace PharmacyManagmentSystem.UI.Forms
{
    partial class Landing
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            Password = new Label();
            userName = new Label();
            groupBox1 = new GroupBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            panel2 = new Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.AliceBlue;
            txtPassword.Location = new Point(95, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.AliceBlue;
            txtUserName.Location = new Point(95, 28);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(161, 23);
            txtUserName.TabIndex = 0;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.MidnightBlue;
            Password.Location = new Point(11, 76);
            Password.Name = "Password";
            Password.Size = new Size(76, 20);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.MidnightBlue;
            userName.Location = new Point(11, 29);
            userName.Name = "userName";
            userName.Size = new Size(80, 20);
            userName.TabIndex = 6;
            userName.Text = "Username";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(guna2CircleButton1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(userName);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(Password);
            groupBox1.Location = new Point(293, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 190);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(134, 112);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(83, 43);
            guna2CircleButton1.TabIndex = 2;
            guna2CircleButton1.Text = "Login";
            guna2CircleButton1.Click += login_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Urdu Typesetting", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(110, -9);
            label2.Name = "label2";
            label2.Size = new Size(481, 64);
            label2.TabIndex = 0;
            label2.Text = "Pharmacy Management System";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(guna2ControlBox2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 58);
            panel2.TabIndex = 11;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Right;
            guna2ControlBox2.BackColor = Color.Gray;
            guna2ControlBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2ControlBox2.CustomizableEdges = customizableEdges2;
            guna2ControlBox2.FillColor = Color.FromArgb(0, 0, 0, 0);
            guna2ControlBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(2026, -6);
            guna2ControlBox2.Margin = new Padding(3, 4, 3, 4);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ControlBox2.Size = new Size(35, 49);
            guna2ControlBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 416);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urdu Typesetting", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(246, 89);
            label1.Name = "label1";
            label1.Size = new Size(402, 55);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Pharmacy System\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Urdu Typesetting", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(379, 141);
            label3.Name = "label3";
            label3.Size = new Size(131, 40);
            label3.TabIndex = 0;
            label3.Text = "Please Login";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(695, 477);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(711, 516);
            MinimumSize = new Size(711, 516);
            Name = "Landing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label Password;
        private Label userName;
        private GroupBox groupBox1;
        private Label label2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
    }
}