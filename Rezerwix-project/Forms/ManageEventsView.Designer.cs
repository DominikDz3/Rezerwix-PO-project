// ManageEventsView.Designer.cs
namespace Rezerwix_project.Forms
{
    partial class ManageEventsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblViewTitle = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnEditSelectedEvent = new System.Windows.Forms.Button();
            this.btnDeleteSelectedEvent = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.panelActions.SuspendLayout();
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
            this.lblViewTitle.Text = "Zarządzaj Wydarzeniami";
            this.lblViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold); // Ustawienie czcionki dla nagłówków
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(10, 116);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(764, 405);
            this.dgvEvents.TabIndex = 2;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnDeleteSelectedEvent);
            this.panelActions.Controls.Add(this.btnEditSelectedEvent);
            this.panelActions.Controls.Add(this.btnAddNewEvent);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(10, 60);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(764, 50);
            this.panelActions.TabIndex = 1;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddNewEvent.FlatAppearance.BorderSize = 0;
            this.btnAddNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewEvent.Location = new System.Drawing.Point(5, 10);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(150, 30);
            this.btnAddNewEvent.TabIndex = 0;
            this.btnAddNewEvent.Text = "Dodaj Nowe Wydarzenie";
            this.btnAddNewEvent.UseVisualStyleBackColor = false;
            // 
            // btnEditSelectedEvent
            // 
            this.btnEditSelectedEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnEditSelectedEvent.FlatAppearance.BorderSize = 0;
            this.btnEditSelectedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelectedEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditSelectedEvent.ForeColor = System.Drawing.Color.White;
            this.btnEditSelectedEvent.Location = new System.Drawing.Point(165, 10);
            this.btnEditSelectedEvent.Name = "btnEditSelectedEvent";
            this.btnEditSelectedEvent.Size = new System.Drawing.Size(150, 30);
            this.btnEditSelectedEvent.TabIndex = 1;
            this.btnEditSelectedEvent.Text = "Edytuj Zaznaczone";
            this.btnEditSelectedEvent.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSelectedEvent
            // 
            this.btnDeleteSelectedEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDeleteSelectedEvent.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelectedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSelectedEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelectedEvent.Location = new System.Drawing.Point(325, 10);
            this.btnDeleteSelectedEvent.Name = "btnDeleteSelectedEvent";
            this.btnDeleteSelectedEvent.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteSelectedEvent.TabIndex = 2;
            this.btnDeleteSelectedEvent.Text = "Usuń Zaznaczone";
            this.btnDeleteSelectedEvent.UseVisualStyleBackColor = false;
            // 
            // ManageEventsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelTitle);
            this.Name = "ManageEventsView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(784, 561);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblViewTitle;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Button btnEditSelectedEvent;
        private System.Windows.Forms.Button btnDeleteSelectedEvent;
    }
}
