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

        // LoginView.Designer.cs
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblMessage = new Label();
            btnLogin = new Button();
            lblRegister = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(45, 45, 48);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(lblUsername, 1, 3);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 4);
            tableLayoutPanel1.Controls.Add(lblPassword, 1, 5);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 6);
            tableLayoutPanel1.Controls.Add(lblMessage, 1, 7);
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 8);
            tableLayoutPanel1.Controls.Add(lblRegister, 0, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(130, 130);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            tableLayoutPanel1.SetColumnSpan(lblTitle, 3);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(3, -100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Logowanie";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F);
            lblUsername.ForeColor = Color.WhiteSmoke;
            lblUsername.Location = new Point(-107, -19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(163, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.FromArgb(60, 60, 60);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(-107, 8);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(344, 30);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F);
            lblPassword.ForeColor = Color.WhiteSmoke;
            lblPassword.Location = new Point(-107, 41);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Hasło:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(60, 60, 60);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(-107, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(344, 30);
            txtPassword.TabIndex = 4;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Tomato;
            lblMessage.Location = new Point(-107, 102);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(344, 25);
            lblMessage.TabIndex = 7;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(-35, 135);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Zaloguj się";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegister
            // 
            tableLayoutPanel1.SetColumnSpan(lblRegister, 3);
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Dock = DockStyle.Fill;
            lblRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblRegister.ForeColor = Color.FromArgb(135, 206, 250);
            lblRegister.Location = new Point(3, 200);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(124, 30);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Nie masz konta? Zarejestruj się";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "LoginView";
            Padding = new Padding(10);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}
