// RegisterView.Designer.cs
namespace Rezerwix_project.Forms
{
    partial class RegisterView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker datePickerBirthDate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLoginLink;
        private System.Windows.Forms.Label lblRegisterMessage;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblConfirmPasswordError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblBirthDateError;

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
            tableLayoutPanelRegister = new TableLayoutPanel();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblUsernameError = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPasswordError = new Label();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPasswordError = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEmailError = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblFirstNameError = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblLastNameError = new Label();
            lblBirthDate = new Label();
            datePickerBirthDate = new DateTimePicker();
            lblBirthDateError = new Label();
            lblRegisterMessage = new Label();
            btnRegister = new Button();
            lblLoginLink = new Label();
            tableLayoutPanelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelRegister
            // 
            tableLayoutPanelRegister.BackColor = Color.FromArgb(45, 45, 48);
            tableLayoutPanelRegister.ColumnCount = 3;
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.Controls.Add(lblTitle, 0, 1);
            tableLayoutPanelRegister.Controls.Add(lblUsername, 1, 3);
            tableLayoutPanelRegister.Controls.Add(txtUsername, 1, 4);
            tableLayoutPanelRegister.Controls.Add(lblUsernameError, 1, 5);
            tableLayoutPanelRegister.Controls.Add(lblPassword, 1, 6);
            tableLayoutPanelRegister.Controls.Add(txtPassword, 1, 7);
            tableLayoutPanelRegister.Controls.Add(lblPasswordError, 1, 8);
            tableLayoutPanelRegister.Controls.Add(lblConfirmPassword, 1, 9);
            tableLayoutPanelRegister.Controls.Add(txtConfirmPassword, 1, 10);
            tableLayoutPanelRegister.Controls.Add(lblConfirmPasswordError, 1, 11);
            tableLayoutPanelRegister.Controls.Add(lblEmail, 1, 12);
            tableLayoutPanelRegister.Controls.Add(txtEmail, 1, 13);
            tableLayoutPanelRegister.Controls.Add(lblEmailError, 1, 14);
            tableLayoutPanelRegister.Controls.Add(lblFirstName, 1, 15);
            tableLayoutPanelRegister.Controls.Add(txtFirstName, 1, 16);
            tableLayoutPanelRegister.Controls.Add(lblFirstNameError, 1, 17);
            tableLayoutPanelRegister.Controls.Add(lblLastName, 1, 18);
            tableLayoutPanelRegister.Controls.Add(txtLastName, 1, 19);
            tableLayoutPanelRegister.Controls.Add(lblLastNameError, 1, 20);
            tableLayoutPanelRegister.Controls.Add(lblBirthDate, 1, 21);
            tableLayoutPanelRegister.Controls.Add(datePickerBirthDate, 1, 22);
            tableLayoutPanelRegister.Controls.Add(lblBirthDateError, 1, 23);
            tableLayoutPanelRegister.Controls.Add(lblRegisterMessage, 1, 24);
            tableLayoutPanelRegister.Controls.Add(btnRegister, 1, 25);
            tableLayoutPanelRegister.Controls.Add(lblLoginLink, 0, 27);
            tableLayoutPanelRegister.Dock = DockStyle.Fill;
            tableLayoutPanelRegister.Location = new Point(10, 10);
            tableLayoutPanelRegister.Name = "tableLayoutPanelRegister";
            tableLayoutPanelRegister.RowCount = 29;
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.Size = new Size(753, 650);
            tableLayoutPanelRegister.TabIndex = 0;
            // 
            // lblTitle
            // 
            tableLayoutPanelRegister.SetColumnSpan(lblTitle, 3);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(3, -5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(747, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rejestracja";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.WhiteSmoke;
            lblUsername.Location = new Point(179, 57);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(60, 60, 60);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(179, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(394, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUsernameError.ForeColor = Color.Tomato;
            lblUsernameError.Location = new Point(179, 105);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(0, 13);
            lblUsernameError.TabIndex = 20;
            lblUsernameError.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.WhiteSmoke;
            lblPassword.Location = new Point(179, 127);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(40, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Hasło:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(60, 60, 60);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(179, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(394, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI", 8.25F);
            lblPasswordError.ForeColor = Color.Tomato;
            lblPasswordError.Location = new Point(179, 175);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 13);
            lblPasswordError.TabIndex = 21;
            lblPasswordError.Visible = false;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Left;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmPassword.ForeColor = Color.WhiteSmoke;
            lblConfirmPassword.Location = new Point(179, 197);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(93, 15);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Potwierdź hasło:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(60, 60, 60);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Dock = DockStyle.Fill;
            txtConfirmPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;
            txtConfirmPassword.Location = new Point(179, 218);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(394, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.Font = new Font("Segoe UI", 8.25F);
            lblConfirmPasswordError.ForeColor = Color.Tomato;
            lblConfirmPasswordError.Location = new Point(179, 245);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(0, 13);
            lblConfirmPasswordError.TabIndex = 22;
            lblConfirmPasswordError.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.WhiteSmoke;
            lblEmail.Location = new Point(179, 267);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(60, 60, 60);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.ForeColor = Color.WhiteSmoke;
            txtEmail.Location = new Point(179, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 8.25F);
            lblEmailError.ForeColor = Color.Tomato;
            lblEmailError.Location = new Point(179, 315);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 13);
            lblEmailError.TabIndex = 23;
            lblEmailError.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Left;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F);
            lblFirstName.ForeColor = Color.WhiteSmoke;
            lblFirstName.Location = new Point(179, 337);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(33, 15);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "Imię:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(60, 60, 60);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.ForeColor = Color.WhiteSmoke;
            txtFirstName.Location = new Point(179, 358);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(394, 23);
            txtFirstName.TabIndex = 10;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 8.25F);
            lblFirstNameError.ForeColor = Color.Tomato;
            lblFirstNameError.Location = new Point(179, 385);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(0, 13);
            lblFirstNameError.TabIndex = 24;
            lblFirstNameError.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F);
            lblLastName.ForeColor = Color.WhiteSmoke;
            lblLastName.Location = new Point(179, 407);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Nazwisko:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(60, 60, 60);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.ForeColor = Color.WhiteSmoke;
            txtLastName.Location = new Point(179, 428);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(394, 23);
            txtLastName.TabIndex = 12;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 8.25F);
            lblLastNameError.ForeColor = Color.Tomato;
            lblLastNameError.Location = new Point(179, 455);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(0, 13);
            lblLastNameError.TabIndex = 25;
            lblLastNameError.Visible = false;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Anchor = AnchorStyles.Left;
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F);
            lblBirthDate.ForeColor = Color.WhiteSmoke;
            lblBirthDate.Location = new Point(179, 477);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(89, 15);
            lblBirthDate.TabIndex = 13;
            lblBirthDate.Text = "Data urodzenia:";
            // 
            // datePickerBirthDate
            // 
            datePickerBirthDate.CalendarForeColor = Color.WhiteSmoke;
            datePickerBirthDate.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            datePickerBirthDate.CalendarTitleBackColor = Color.FromArgb(0, 122, 204);
            datePickerBirthDate.CalendarTitleForeColor = Color.WhiteSmoke;
            datePickerBirthDate.Dock = DockStyle.Fill;
            datePickerBirthDate.Font = new Font("Segoe UI", 9F);
            datePickerBirthDate.Format = DateTimePickerFormat.Short;
            datePickerBirthDate.Location = new Point(179, 498);
            datePickerBirthDate.Name = "datePickerBirthDate";
            datePickerBirthDate.Size = new Size(394, 23);
            datePickerBirthDate.TabIndex = 14;
            // 
            // lblBirthDateError
            // 
            lblBirthDateError.AutoSize = true;
            lblBirthDateError.Font = new Font("Segoe UI", 8.25F);
            lblBirthDateError.ForeColor = Color.Tomato;
            lblBirthDateError.Location = new Point(179, 525);
            lblBirthDateError.Name = "lblBirthDateError";
            lblBirthDateError.Size = new Size(0, 13);
            lblBirthDateError.TabIndex = 26;
            lblBirthDateError.Visible = false;
            // 
            // lblRegisterMessage
            // 
            lblRegisterMessage.Dock = DockStyle.Fill;
            lblRegisterMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegisterMessage.ForeColor = Color.Tomato;
            lblRegisterMessage.Location = new Point(179, 545);
            lblRegisterMessage.Name = "lblRegisterMessage";
            lblRegisterMessage.Size = new Size(394, 25);
            lblRegisterMessage.TabIndex = 17;
            lblRegisterMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblRegisterMessage.Visible = false;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.FromArgb(0, 122, 204);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(276, 573);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 39);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Zarejestruj się";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblLoginLink
            // 
            tableLayoutPanelRegister.SetColumnSpan(lblLoginLink, 3);
            lblLoginLink.Cursor = Cursors.Hand;
            lblLoginLink.Dock = DockStyle.Fill;
            lblLoginLink.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblLoginLink.ForeColor = Color.FromArgb(135, 206, 250);
            lblLoginLink.Location = new Point(3, 625);
            lblLoginLink.Name = "lblLoginLink";
            lblLoginLink.Size = new Size(747, 30);
            lblLoginLink.TabIndex = 16;
            lblLoginLink.Text = "Masz już konto? Zaloguj się";
            lblLoginLink.TextAlign = ContentAlignment.MiddleCenter;
            lblLoginLink.Click += lblLoginLink_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(tableLayoutPanelRegister);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "RegisterView";
            Padding = new Padding(10);
            Size = new Size(773, 670);
            tableLayoutPanelRegister.ResumeLayout(false);
            tableLayoutPanelRegister.PerformLayout();
            ResumeLayout(false);
        }
    }
}
