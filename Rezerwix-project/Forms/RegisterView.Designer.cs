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
            tableLayoutPanelRegister = new TableLayoutPanel();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblBirthDate = new Label();
            datePickerBirthDate = new DateTimePicker();
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
            tableLayoutPanelRegister.Controls.Add(lblPassword, 1, 5);
            tableLayoutPanelRegister.Controls.Add(txtPassword, 1, 6);
            tableLayoutPanelRegister.Controls.Add(lblConfirmPassword, 1, 7);
            tableLayoutPanelRegister.Controls.Add(txtConfirmPassword, 1, 8);
            tableLayoutPanelRegister.Controls.Add(lblEmail, 1, 9);
            tableLayoutPanelRegister.Controls.Add(txtEmail, 1, 10);
            tableLayoutPanelRegister.Controls.Add(lblFirstName, 1, 11);
            tableLayoutPanelRegister.Controls.Add(txtFirstName, 1, 12);
            tableLayoutPanelRegister.Controls.Add(lblLastName, 1, 13);
            tableLayoutPanelRegister.Controls.Add(txtLastName, 1, 14);
            tableLayoutPanelRegister.Controls.Add(lblBirthDate, 1, 15);
            tableLayoutPanelRegister.Controls.Add(datePickerBirthDate, 1, 16);
            tableLayoutPanelRegister.Controls.Add(lblRegisterMessage, 1, 17);
            tableLayoutPanelRegister.Controls.Add(btnRegister, 1, 18);
            tableLayoutPanelRegister.Controls.Add(lblLoginLink, 0, 20);
            tableLayoutPanelRegister.Dock = DockStyle.Fill;
            tableLayoutPanelRegister.Location = new Point(10, 10);
            tableLayoutPanelRegister.Name = "tableLayoutPanelRegister";
            tableLayoutPanelRegister.RowCount = 22;
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.Size = new Size(753, 528);
            tableLayoutPanelRegister.TabIndex = 0;
            // 
            // lblTitle
            // 
            tableLayoutPanelRegister.SetColumnSpan(lblTitle, 3);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(3, -1);
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
            lblUsername.Location = new Point(179, 64);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(142, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.FromArgb(60, 60, 60);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(179, 87);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(394, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.WhiteSmoke;
            lblPassword.Location = new Point(179, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Hasło:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(60, 60, 60);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(179, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(394, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Left;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmPassword.ForeColor = Color.WhiteSmoke;
            lblConfirmPassword.Location = new Point(179, 164);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(116, 20);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Potwierdź hasło:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.BackColor = Color.FromArgb(60, 60, 60);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;
            txtConfirmPassword.Location = new Point(179, 187);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(394, 27);
            txtConfirmPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.WhiteSmoke;
            lblEmail.Location = new Point(179, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(60, 60, 60);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.ForeColor = Color.WhiteSmoke;
            txtEmail.Location = new Point(179, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Left;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F);
            lblFirstName.ForeColor = Color.WhiteSmoke;
            lblFirstName.Location = new Point(179, 264);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(41, 20);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "Imię:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.BackColor = Color.FromArgb(60, 60, 60);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.ForeColor = Color.WhiteSmoke;
            txtFirstName.Location = new Point(179, 287);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(394, 27);
            txtFirstName.TabIndex = 10;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F);
            lblLastName.ForeColor = Color.WhiteSmoke;
            lblLastName.Location = new Point(179, 314);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Nazwisko:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = Color.FromArgb(60, 60, 60);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.ForeColor = Color.WhiteSmoke;
            txtLastName.Location = new Point(179, 337);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(394, 27);
            txtLastName.TabIndex = 12;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Anchor = AnchorStyles.Left;
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F);
            lblBirthDate.ForeColor = Color.WhiteSmoke;
            lblBirthDate.Location = new Point(179, 364);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(114, 20);
            lblBirthDate.TabIndex = 13;
            lblBirthDate.Text = "Data urodzenia:";
            // 
            // datePickerBirthDate
            // 
            datePickerBirthDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datePickerBirthDate.BackColor = Color.FromArgb(60, 60, 60);
            datePickerBirthDate.CalendarForeColor = Color.WhiteSmoke;
            datePickerBirthDate.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            datePickerBirthDate.CalendarTitleBackColor = Color.FromArgb(0, 122, 204);
            datePickerBirthDate.CalendarTitleForeColor = Color.WhiteSmoke;
            datePickerBirthDate.Font = new Font("Segoe UI", 9F);
            datePickerBirthDate.Format = DateTimePickerFormat.Short;
            datePickerBirthDate.Location = new Point(179, 387);
            datePickerBirthDate.Name = "datePickerBirthDate";
            datePickerBirthDate.Size = new Size(394, 27);
            datePickerBirthDate.TabIndex = 14;
            // 
            // lblRegisterMessage
            // 
            lblRegisterMessage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRegisterMessage.Font = new Font("Segoe UI", 9F);
            lblRegisterMessage.ForeColor = Color.Tomato;
            lblRegisterMessage.Location = new Point(179, 416);
            lblRegisterMessage.Name = "lblRegisterMessage";
            lblRegisterMessage.Size = new Size(394, 20);
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
            btnRegister.Location = new Point(276, 442);
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
            lblLoginLink.Location = new Point(3, 499);
            lblLoginLink.Name = "lblLoginLink";
            lblLoginLink.Size = new Size(747, 30);
            lblLoginLink.TabIndex = 16;
            lblLoginLink.Text = "Masz już konto? Zaloguj się";
            lblLoginLink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            Controls.Add(tableLayoutPanelRegister);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "RegisterView";
            Padding = new Padding(10);
            Size = new Size(773, 548);
            tableLayoutPanelRegister.ResumeLayout(false);
            tableLayoutPanelRegister.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegister;
        private System.Windows.Forms.Label lblRegisterMessage;

    }
}
