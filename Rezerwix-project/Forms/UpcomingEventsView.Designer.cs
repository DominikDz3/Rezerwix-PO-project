namespace Rezerwix_project.Forms
{
    partial class UpcomingEventsView
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
            this.flowLayoutPanelEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.txtSearchEvents = new System.Windows.Forms.TextBox();
            this.lblSearchEvents = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelFilters.SuspendLayout();
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
            this.lblViewTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblViewTitle.Location = new System.Drawing.Point(0, 0);
            this.lblViewTitle.Name = "lblViewTitle";
            this.lblViewTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblViewTitle.Size = new System.Drawing.Size(764, 50);
            this.lblViewTitle.TabIndex = 0;
            this.lblViewTitle.Text = "Nadchodzące Wydarzenia";
            this.lblViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelFilters.Controls.Add(this.btnClearFilters);
            this.panelFilters.Controls.Add(this.btnApplyFilters);
            this.panelFilters.Controls.Add(this.cmbCategoryFilter);
            this.panelFilters.Controls.Add(this.lblCategoryFilter);
            this.panelFilters.Controls.Add(this.txtSearchEvents);
            this.panelFilters.Controls.Add(this.lblSearchEvents);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(10, 60);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Padding = new System.Windows.Forms.Padding(5);
            this.panelFilters.Size = new System.Drawing.Size(764, 45);
            this.panelFilters.TabIndex = 1;
            // 
            // lblSearchEvents
            // 
            this.lblSearchEvents.AutoSize = true;
            this.lblSearchEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearchEvents.Location = new System.Drawing.Point(8, 14);
            this.lblSearchEvents.Name = "lblSearchEvents";
            this.lblSearchEvents.Size = new System.Drawing.Size(69, 15);
            this.lblSearchEvents.TabIndex = 0;
            this.lblSearchEvents.Text = "Wyszukaj:";
            // 
            // txtSearchEvents
            // 
            this.txtSearchEvents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchEvents.Location = new System.Drawing.Point(83, 11);
            this.txtSearchEvents.Name = "txtSearchEvents";
            this.txtSearchEvents.Size = new System.Drawing.Size(200, 23);
            this.txtSearchEvents.TabIndex = 1;
            // 
            // lblCategoryFilter
            // 
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategoryFilter.Location = new System.Drawing.Point(295, 14);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(64, 15);
            this.lblCategoryFilter.TabIndex = 2;
            this.lblCategoryFilter.Text = "Kategoria:";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(365, 11);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(180, 23);
            this.cmbCategoryFilter.TabIndex = 3;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnApplyFilters.FlatAppearance.BorderSize = 0;
            this.btnApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnApplyFilters.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilters.Location = new System.Drawing.Point(555, 9);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(90, 27);
            this.btnApplyFilters.TabIndex = 4;
            this.btnApplyFilters.Text = "Filtruj";
            this.btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClearFilters.FlatAppearance.BorderSize = 0;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(655, 9);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(90, 27);
            this.btnClearFilters.TabIndex = 5;
            this.btnClearFilters.Text = "Wyczyść";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelEvents
            // 
            this.flowLayoutPanelEvents.AutoScroll = true;
            this.flowLayoutPanelEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEvents.Location = new System.Drawing.Point(10, 115);
            this.flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            this.flowLayoutPanelEvents.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelEvents.Size = new System.Drawing.Size(764, 436);
            this.flowLayoutPanelEvents.TabIndex = 2;
            // 
            // UpcomingEventsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.flowLayoutPanelEvents);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelTitle);
            this.Name = "UpcomingEventsView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(784, 561);
            this.panelTitle.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblViewTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvents;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblSearchEvents;
        private System.Windows.Forms.TextBox txtSearchEvents;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnClearFilters;
    }
}
