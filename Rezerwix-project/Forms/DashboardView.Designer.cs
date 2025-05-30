namespace Rezerwix_project.Forms
{
    partial class DashboardView
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnUpcomingEvents = new System.Windows.Forms.Button();
            this.btnMyTickets = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblContentWelcome = new System.Windows.Forms.Label();
            this.lblContentPlaceholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1 (Menu Panel)
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelMenu);
            this.splitContainerMain.Panel1MinSize = 200;
            // 
            // splitContainerMain.Panel2 (Content Panel)
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelContent);
            this.splitContainerMain.Size = new System.Drawing.Size(900, 600);
            this.splitContainerMain.SplitterDistance = 220;
            this.splitContainerMain.SplitterWidth = 1;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAdminPanel);
            this.panelMenu.Controls.Add(this.btnMyProfile);
            this.panelMenu.Controls.Add(this.btnMyTickets);
            this.panelMenu.Controls.Add(this.btnUpcomingEvents);
            this.panelMenu.Controls.Add(this.lblMenuTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panelMenu.Size = new System.Drawing.Size(220, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(10, 10);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(200, 60);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Rezerwix";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpcomingEvents
            // 
            this.btnUpcomingEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.btnUpcomingEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpcomingEvents.FlatAppearance.BorderSize = 0;
            this.btnUpcomingEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpcomingEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpcomingEvents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpcomingEvents.Location = new System.Drawing.Point(10, 70);
            this.btnUpcomingEvents.Name = "btnUpcomingEvents";
            this.btnUpcomingEvents.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpcomingEvents.Size = new System.Drawing.Size(200, 45);
            this.btnUpcomingEvents.TabIndex = 1;
            this.btnUpcomingEvents.Text = "Nadchodzące Wydarzenia";
            this.btnUpcomingEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpcomingEvents.UseVisualStyleBackColor = false;
            // 
            // btnMyTickets
            // 
            this.btnMyTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.btnMyTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyTickets.FlatAppearance.BorderSize = 0;
            this.btnMyTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTickets.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMyTickets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMyTickets.Location = new System.Drawing.Point(10, 115);
            this.btnMyTickets.Name = "btnMyTickets";
            this.btnMyTickets.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMyTickets.Size = new System.Drawing.Size(200, 45);
            this.btnMyTickets.TabIndex = 2;
            this.btnMyTickets.Text = "Moje Bilety";
            this.btnMyTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyTickets.UseVisualStyleBackColor = false;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.btnMyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMyProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMyProfile.Location = new System.Drawing.Point(10, 160);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMyProfile.Size = new System.Drawing.Size(200, 45);
            this.btnMyProfile.TabIndex = 3;
            this.btnMyProfile.Text = "Mój Profil";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.UseVisualStyleBackColor = false;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.btnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnAdminPanel.Location = new System.Drawing.Point(10, 205);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminPanel.Size = new System.Drawing.Size(200, 45);
            this.btnAdminPanel.TabIndex = 4;
            this.btnAdminPanel.Text = "Panel Administratora";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(10, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.lblContentWelcome);
            this.panelContent.Controls.Add(this.lblContentPlaceholder);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(679, 600);
            this.panelContent.TabIndex = 0;
            // 
            // lblContentWelcome
            // 
            this.lblContentWelcome.AutoSize = true;
            this.lblContentWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContentWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblContentWelcome.Location = new System.Drawing.Point(23, 20);
            this.lblContentWelcome.Name = "lblContentWelcome";
            this.lblContentWelcome.Size = new System.Drawing.Size(194, 30);
            this.lblContentWelcome.TabIndex = 0;
            this.lblContentWelcome.Text = "Witaj, Użytkowniku!";
            // 
            // lblContentPlaceholder
            // 
            this.lblContentPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContentPlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContentPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblContentPlaceholder.Location = new System.Drawing.Point(189, 270);
            this.lblContentPlaceholder.Name = "lblContentPlaceholder";
            this.lblContentPlaceholder.Size = new System.Drawing.Size(300, 60);
            this.lblContentPlaceholder.TabIndex = 1;
            this.lblContentPlaceholder.Text = "Wybierz opcję z menu po lewej stronie.";
            this.lblContentPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(900, 600);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnUpcomingEvents;
        private System.Windows.Forms.Button btnMyTickets;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblContentWelcome;
        private System.Windows.Forms.Label lblContentPlaceholder;
    }
}