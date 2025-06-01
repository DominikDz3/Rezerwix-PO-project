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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTitle = new Panel();
            lblViewTitle = new Label();
            dgvEvents = new DataGridView();
            panelActions = new Panel();
            btnDeleteSelectedEvent = new Button();
            btnEditSelectedEvent = new Button();
            btnAddNewEvent = new Button();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lblViewTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(13, 15);
            panelTitle.Margin = new Padding(4, 5, 4, 5);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1019, 77);
            panelTitle.TabIndex = 0;
            // 
            // lblViewTitle
            // 
            lblViewTitle.Dock = DockStyle.Fill;
            lblViewTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblViewTitle.ForeColor = Color.FromArgb(45, 45, 48);
            lblViewTitle.Location = new Point(0, 0);
            lblViewTitle.Margin = new Padding(4, 0, 4, 0);
            lblViewTitle.Name = "lblViewTitle";
            lblViewTitle.Padding = new Padding(7, 0, 0, 0);
            lblViewTitle.Size = new Size(1019, 77);
            lblViewTitle.TabIndex = 0;
            lblViewTitle.Text = "Zarządzaj Wydarzeniami";
            lblViewTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(13, 178);
            dgvEvents.Margin = new Padding(4, 5, 4, 5);
            dgvEvents.MultiSelect = false;
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(1019, 623);
            dgvEvents.TabIndex = 2;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnDeleteSelectedEvent);
            panelActions.Controls.Add(btnEditSelectedEvent);
            panelActions.Controls.Add(btnAddNewEvent);
            panelActions.Dock = DockStyle.Top;
            panelActions.Location = new Point(13, 92);
            panelActions.Margin = new Padding(4, 5, 4, 5);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1019, 77);
            panelActions.TabIndex = 1;
            // 
            // btnDeleteSelectedEvent
            // 
            btnDeleteSelectedEvent.BackColor = Color.FromArgb(217, 83, 79);
            btnDeleteSelectedEvent.FlatAppearance.BorderSize = 0;
            btnDeleteSelectedEvent.FlatStyle = FlatStyle.Flat;
            btnDeleteSelectedEvent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteSelectedEvent.ForeColor = Color.White;
            btnDeleteSelectedEvent.Location = new Point(438, 15);
            btnDeleteSelectedEvent.Margin = new Padding(4, 5, 4, 5);
            btnDeleteSelectedEvent.Name = "btnDeleteSelectedEvent";
            btnDeleteSelectedEvent.Size = new Size(200, 46);
            btnDeleteSelectedEvent.TabIndex = 2;
            btnDeleteSelectedEvent.Text = "Usuń Zaznaczone";
            btnDeleteSelectedEvent.UseVisualStyleBackColor = false;
            // 
            // btnEditSelectedEvent
            // 
            btnEditSelectedEvent.BackColor = Color.FromArgb(240, 173, 78);
            btnEditSelectedEvent.FlatAppearance.BorderSize = 0;
            btnEditSelectedEvent.FlatStyle = FlatStyle.Flat;
            btnEditSelectedEvent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditSelectedEvent.ForeColor = Color.White;
            btnEditSelectedEvent.Location = new Point(230, 15);
            btnEditSelectedEvent.Margin = new Padding(4, 5, 4, 5);
            btnEditSelectedEvent.Name = "btnEditSelectedEvent";
            btnEditSelectedEvent.Size = new Size(200, 46);
            btnEditSelectedEvent.TabIndex = 1;
            btnEditSelectedEvent.Text = "Edytuj Zaznaczone";
            btnEditSelectedEvent.UseVisualStyleBackColor = false;
            // 
            // btnAddNewEvent
            // 
            btnAddNewEvent.BackColor = Color.FromArgb(40, 167, 69);
            btnAddNewEvent.FlatAppearance.BorderSize = 0;
            btnAddNewEvent.FlatStyle = FlatStyle.Flat;
            btnAddNewEvent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAddNewEvent.ForeColor = Color.White;
            btnAddNewEvent.Location = new Point(7, 15);
            btnAddNewEvent.Margin = new Padding(4, 5, 4, 5);
            btnAddNewEvent.Name = "btnAddNewEvent";
            btnAddNewEvent.Size = new Size(215, 46);
            btnAddNewEvent.TabIndex = 0;
            btnAddNewEvent.Text = "Dodaj Nowe Wydarzenie";
            btnAddNewEvent.UseVisualStyleBackColor = false;
            // 
            // ManageEventsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(dgvEvents);
            Controls.Add(panelActions);
            Controls.Add(panelTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ManageEventsView";
            Padding = new Padding(13, 15, 13, 15);
            Size = new Size(1045, 863);
            panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
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
