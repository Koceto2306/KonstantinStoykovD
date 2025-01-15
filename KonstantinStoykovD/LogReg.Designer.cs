namespace VolleyballRecruitmentApp
{
    partial class LogReg
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.BackgroundImage = Image.FromFile("VRAS.jpg");

            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            radioLogin = new RadioButton();
            radioRegister = new RadioButton();

            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(800, 500);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(800, 562);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(800, 625);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 2;
            txtEmail.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(800, 688);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(970, 688);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 50);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(650, 500);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            lblUsername.BackColor = Color.Transparent;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(650, 562);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(104, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            lblPassword.BackColor = Color.Transparent;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(650, 625);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 23);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            lblEmail.Visible = false;
            lblEmail.BackColor = Color.Transparent;
            // 
            // radioLogin
            // 
            radioLogin.AutoSize = true;
            radioLogin.Location = new Point(850, 450);
            radioLogin.Name = "radioLogin";
            radioLogin.Size = new Size(77, 34);
            radioLogin.TabIndex = 8;
            radioLogin.TabStop = true;
            radioLogin.Text = "Login";
            radioLogin.UseVisualStyleBackColor = true;
            radioLogin.CheckedChanged += RadioLogin_CheckedChanged;
            radioLogin.BackColor = Color.Transparent;
            // 
            // radioRegister
            // 
            radioRegister.AutoSize = true;
            radioRegister.Location = new Point(950, 450);
            radioRegister.Name = "radioRegister";
            radioRegister.Size = new Size(94, 34);
            radioRegister.TabIndex = 9;
            radioRegister.TabStop = true;
            radioRegister.Text = "Register";
            radioRegister.UseVisualStyleBackColor = true;
            radioRegister.CheckedChanged += RadioRegister_CheckedChanged;
            radioRegister.BackColor = Color.Transparent;
            // 
            // LogReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            // Set form properties for full screen
            FormBorderStyle = FormBorderStyle.None; // Remove the border
            WindowState = FormWindowState.Maximized; // Maximize the window
            // Set the BackgroundImage properties
            BackgroundImageLayout = ImageLayout.Stretch; // Make the background image stretch
            // Set the client size based on screen resolution
            ClientSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Controls.Add(radioRegister);
            Controls.Add(radioLogin);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogReg"; // Update name to match class
            Text = "Volleyball Recruitment Agency";
//            Load += LogReg_Load; // Ensure event handler is correct
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail; // Email TextBox
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister; // Register Button
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail; // Email Label
        private System.Windows.Forms.RadioButton radioLogin; // RadioButton for Login
        private System.Windows.Forms.RadioButton radioRegister; // RadioButton for Register
    }
}
