namespace Rezerwix_project.Forms
{
    partial class LoginView
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblRegister;
        private Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblRegister = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Logowanie";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(50, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nazwa użytkownika *";
            // 
            // lblPassword
            // 
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(50, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Hasło *";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(50, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(50, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Zaloguj się";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegister
            // 
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblRegister.ForeColor = Color.FromArgb(0, 122, 204);
            lblRegister.Location = new Point(115, 275);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(200, 15);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Nie masz konta? Zarejestruj się";
            lblRegister.Click += lblRegister_Click;
            // 
            // LoginView
            // 
            BackColor = Color.FromArgb(45, 45, 48);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblRegister);
            Name = "LoginView";
            Size = new Size(400, 320);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
