namespace Rezerwix_project.Forms
{
    partial class EventCardControl
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.lblCategories);
            this.panelCard.Controls.Add(this.btnDetails);
            this.panelCard.Controls.Add(this.lblLocation);
            this.panelCard.Controls.Add(this.lblDate);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Margin = new System.Windows.Forms.Padding(5);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(10);
            this.panelCard.Size = new System.Drawing.Size(280, 150);
            this.panelCard.TabIndex = 0;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblCategories.Location = new System.Drawing.Point(10, 85);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(258, 15);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Kategorie: Sport, Muzyka";
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(178, 107);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(90, 30);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblLocation.Location = new System.Drawing.Point(10, 60);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(258, 20);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Lokalizacja: Miasto";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDate.Location = new System.Drawing.Point(10, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(258, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Data: YYYY-MM-DD HH:MM";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tytuł Wydarzenia";
            // 
            // EventCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCard);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "EventCardControl";
            this.Size = new System.Drawing.Size(280, 150);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblCategories;
    }
}
