namespace Rezerwix_project.Forms
{
    partial class MyProfileView
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

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblViewTitle = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gbUserDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelUserDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsernameInfo = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPassword = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblProfileMessage = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.gbUserDetails.SuspendLayout();
            this.tableLayoutPanelUserDetails.SuspendLayout();
            this.gbChangePassword.SuspendLayout();
            this.tableLayoutPanelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblViewTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(10, 10);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(764, 50);
            this.panelTitle.TabIndex = 0;
            // 
            // lblViewTitle
            // 
            this.lblViewTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblViewTitle.Location = new System.Drawing.Point(0, 0);
            this.lblViewTitle.Name = "lblViewTitle";
            this.lblViewTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblViewTitle.Size = new System.Drawing.Size(764, 50);
            this.lblViewTitle.TabIndex = 0;
            this.lblViewTitle.Text = "Mój Profil";
            this.lblViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.gbUserDetails, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.gbChangePassword, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.lblProfileMessage, 0, 1);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(10, 65);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(764, 486);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // gbUserDetails
            // 
            this.gbUserDetails.Controls.Add(this.tableLayoutPanelUserDetails);
            this.gbUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbUserDetails.Location = new System.Drawing.Point(3, 3);
            this.gbUserDetails.Name = "gbUserDetails";
            this.gbUserDetails.Padding = new System.Windows.Forms.Padding(10);
            this.gbUserDetails.Size = new System.Drawing.Size(758, 240); // Dostosuj wysokość
            this.gbUserDetails.TabIndex = 0;
            this.gbUserDetails.TabStop = false;
            this.gbUserDetails.Text = "Dane Użytkownika";
            // 
            // tableLayoutPanelUserDetails
            // 
            this.tableLayoutPanelUserDetails.ColumnCount = 2;
            this.tableLayoutPanelUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserDetails.Controls.Add(this.lblUsernameInfo, 0, 0);
            this.tableLayoutPanelUserDetails.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanelUserDetails.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanelUserDetails.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanelUserDetails.Controls.Add(this.lblLastName, 0, 2);
            this.tableLayoutPanelUserDetails.Controls.Add(this.txtLastName, 1, 2);
            this.tableLayoutPanelUserDetails.Controls.Add(this.lblEmail, 0, 3);
            this.tableLayoutPanelUserDetails.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanelUserDetails.Controls.Add(this.lblDateOfBirth, 0, 4);
            this.tableLayoutPanelUserDetails.Controls.Add(this.dtpDateOfBirth, 1, 4);
            this.tableLayoutPanelUserDetails.Controls.Add(this.btnSaveChanges, 1, 5);
            this.tableLayoutPanelUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserDetails.Location = new System.Drawing.Point(10, 28);
            this.tableLayoutPanelUserDetails.Name = "tableLayoutPanelUserDetails";
            this.tableLayoutPanelUserDetails.RowCount = 6;
            this.tableLayoutPanelUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelUserDetails.Size = new System.Drawing.Size(738, 202);
            this.tableLayoutPanelUserDetails.TabIndex = 0;
            // 
            // lblUsernameInfo
            // 
            this.lblUsernameInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsernameInfo.AutoSize = true;
            this.lblUsernameInfo.Location = new System.Drawing.Point(3, 6);
            this.lblUsernameInfo.Name = "lblUsernameInfo";
            this.lblUsernameInfo.Size = new System.Drawing.Size(122, 17);
            this.lblUsernameInfo.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(153, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true; // Nazwa użytkownika zazwyczaj nieedytowalna
            this.txtUsername.Size = new System.Drawing.Size(582, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(36, 17);
            this.lblFirstName.Text = "Imię:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(153, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(582, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 17);
            this.lblLastName.Text = "Nazwisko:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.Location = new System.Drawing.Point(153, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(582, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(153, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(582, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(3, 126);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(99, 17);
            this.lblDateOfBirth.Text = "Data urodzenia:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(153, 123);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(153, 155);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 34);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Zapisz Zmiany";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.tableLayoutPanelPassword);
            this.gbChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbChangePassword.Location = new System.Drawing.Point(3, 279); // Po lblProfileMessage
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Padding = new System.Windows.Forms.Padding(10);
            this.gbChangePassword.Size = new System.Drawing.Size(758, 204); // Dostosuj wysokość
            this.gbChangePassword.TabIndex = 1;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Zmiana Hasła";
            // 
            // tableLayoutPanelPassword
            // 
            this.tableLayoutPanelPassword.ColumnCount = 2;
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPassword.Controls.Add(this.lblCurrentPassword, 0, 0);
            this.tableLayoutPanelPassword.Controls.Add(this.txtCurrentPassword, 1, 0);
            this.tableLayoutPanelPassword.Controls.Add(this.lblNewPassword, 0, 1);
            this.tableLayoutPanelPassword.Controls.Add(this.txtNewPassword, 1, 1);
            this.tableLayoutPanelPassword.Controls.Add(this.lblConfirmNewPassword, 0, 2);
            this.tableLayoutPanelPassword.Controls.Add(this.txtConfirmNewPassword, 1, 2);
            this.tableLayoutPanelPassword.Controls.Add(this.btnChangePassword, 1, 3);
            this.tableLayoutPanelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPassword.Location = new System.Drawing.Point(10, 28);
            this.tableLayoutPanelPassword.Name = "tableLayoutPanelPassword";
            this.tableLayoutPanelPassword.RowCount = 4;
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelPassword.Size = new System.Drawing.Size(738, 166);
            this.tableLayoutPanelPassword.TabIndex = 0;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(3, 6);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(98, 17);
            this.lblCurrentPassword.Text = "Aktualne hasło:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurrentPassword.Location = new System.Drawing.Point(153, 3);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.Size = new System.Drawing.Size(582, 23);
            this.txtCurrentPassword.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(3, 36);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(79, 17);
            this.lblNewPassword.Text = "Nowe hasło:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.Location = new System.Drawing.Point(153, 33);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(582, 23);
            this.txtNewPassword.TabIndex = 1;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(3, 66);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(127, 17);
            this.lblConfirmNewPassword.Text = "Potwierdź nowe hasło:";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(153, 63);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '●';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(582, 23);
            this.txtConfirmNewPassword.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(153, 93);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(150, 34);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Zmień Hasło";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // lblProfileMessage
            // 
            this.lblProfileMessage.AutoSize = true;
            this.lblProfileMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfileMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProfileMessage.ForeColor = System.Drawing.Color.Green; // Domyślnie na sukces
            this.lblProfileMessage.Location = new System.Drawing.Point(3, 246);
            this.lblProfileMessage.Name = "lblProfileMessage";
            this.lblProfileMessage.Size = new System.Drawing.Size(758, 30);
            this.lblProfileMessage.TabIndex = 2;
            this.lblProfileMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfileMessage.Visible = false;
            // 
            // MyProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.panelTitle);
            this.Name = "MyProfileView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(784, 561);
            this.panelTitle.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.gbUserDetails.ResumeLayout(false);
            this.tableLayoutPanelUserDetails.ResumeLayout(false);
            this.tableLayoutPanelUserDetails.PerformLayout();
            this.gbChangePassword.ResumeLayout(false);
            this.tableLayoutPanelPassword.ResumeLayout(false);
            this.tableLayoutPanelPassword.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblViewTitle;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserDetails;
        private System.Windows.Forms.Label lblUsernameInfo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox gbChangePassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblProfileMessage;
    }
}
