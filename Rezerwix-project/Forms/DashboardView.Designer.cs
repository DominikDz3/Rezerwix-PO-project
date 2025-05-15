// DashboardView.Designer.cs
namespace Rezerwix_project.Forms
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogoutDashboard = new System.Windows.Forms.Button();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWelcome.Location = new System.Drawing.Point(25, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(194, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Witaj, Użytkowniku!";
            // 
            // btnLogoutDashboard
            // 
            this.btnLogoutDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoutDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btnLogoutDashboard.FlatAppearance.BorderSize = 0;
            this.btnLogoutDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogoutDashboard.ForeColor = System.Drawing.Color.White;
            this.btnLogoutDashboard.Location = new System.Drawing.Point(555, 25); // Dostosuj pozycję X w zależności od szerokości
            this.btnLogoutDashboard.Name = "btnLogoutDashboard";
            this.btnLogoutDashboard.Size = new System.Drawing.Size(120, 35);
            this.btnLogoutDashboard.TabIndex = 1;
            this.btnLogoutDashboard.Text = "Wyloguj";
            this.btnLogoutDashboard.UseVisualStyleBackColor = false;
            // this.btnLogoutDashboard.Click += new System.EventHandler(this.BtnLogoutDashboard_Click); // Podłączane w DashboardView.cs
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaceholder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPlaceholder.Location = new System.Drawing.Point(28, 80);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(647, 60);
            this.lblPlaceholder.TabIndex = 2;
            this.lblPlaceholder.Text = "To jest Twój Dashboard. \r\nMożesz tu dodać listę wydarzeń, rezerwacji itp.";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.btnLogoutDashboard);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(700, 500); // Przykładowy rozmiar, dostosuj
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogoutDashboard;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}
