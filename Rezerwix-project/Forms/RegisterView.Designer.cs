namespace Rezerwix_project.Forms
{
    partial class RegisterView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker datePickerBirthDate;
        private System.Windows.Forms.Label lblLoginLink;
        private System.Windows.Forms.Button btnRegister;

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
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblEmail = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBirthDate = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            datePickerBirthDate = new DateTimePicker();
            lblLoginLink = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rejestracja";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(50, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nazwa użytkownika *";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(50, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Hasło *";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9.75F);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(50, 210);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(109, 17);
            lblConfirmPassword.TabIndex = 3;
            lblConfirmPassword.Text = "Potwierdź hasło *";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(50, 270);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 17);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email *";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(50, 330);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(41, 17);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "Imię *";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(260, 330);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(72, 17);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Nazwisko *";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9.75F);
            lblBirthDate.ForeColor = Color.White;
            lblBirthDate.Location = new Point(50, 390);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(106, 17);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Data urodzenia *";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(50, 110);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 25);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(50, 170);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(400, 25);
            txtPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(50, 230);
            txtConfirmPassword.MaxLength = 100;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(400, 25);
            txtConfirmPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 30, 30);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(50, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 25);
            txtEmail.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(30, 30, 30);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(50, 350);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(190, 25);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(30, 30, 30);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(260, 350);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(190, 25);
            txtLastName.TabIndex = 6;
            // 
            // datePickerBirthDate
            // 
            datePickerBirthDate.CalendarFont = new Font("Segoe UI", 9F);
            datePickerBirthDate.CalendarForeColor = Color.White;
            datePickerBirthDate.CalendarMonthBackground = Color.FromArgb(30, 30, 30);
            datePickerBirthDate.CalendarTitleBackColor = Color.FromArgb(0, 122, 204);
            datePickerBirthDate.CalendarTitleForeColor = Color.White;
            datePickerBirthDate.CalendarTrailingForeColor = Color.Gray;
            datePickerBirthDate.Format = DateTimePickerFormat.Short;
            datePickerBirthDate.Location = new Point(50, 410);
            datePickerBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datePickerBirthDate.Name = "datePickerBirthDate";
            datePickerBirthDate.Size = new Size(190, 25);
            datePickerBirthDate.TabIndex = 7;
            // 
            // lblLoginLink
            // 
            lblLoginLink.AutoSize = true;
            lblLoginLink.Cursor = Cursors.Hand;
            lblLoginLink.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblLoginLink.ForeColor = Color.FromArgb(0, 122, 204);
            lblLoginLink.Location = new Point(180, 510);
            lblLoginLink.Name = "lblLoginLink";
            lblLoginLink.Size = new Size(133, 15);
            lblLoginLink.TabIndex = 9;
            lblLoginLink.Text = "Masz konto? Zaloguj się";
            lblLoginLink.Click += this.lblLoginLink_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 122, 204);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(150, 460);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 40);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Zarejestruj się";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            Controls.Add(lblLoginLink);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F);
            ForeColor = Color.White;
            Name = "RegisterView";
            Size = new Size(500, 530);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
