namespace Rezerwix_project.Forms
{
    partial class AddEditEventForm
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.gbEventDetails = new System.Windows.Forms.GroupBox();
            this.numPricePerTicket = new System.Windows.Forms.NumericUpDown();
            this.lblPricePerTicket = new System.Windows.Forms.Label();
            this.numAvailableSeats = new System.Windows.Forms.NumericUpDown();
            this.lblAvailableSeats = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFormMessage = new System.Windows.Forms.Label();
            this.gbEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPricePerTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitleForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitleForm.Location = new System.Drawing.Point(12, 9);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(168, 25);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Dodaj Wydarzenie";
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEventTitle.Location = new System.Drawing.Point(14, 50);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(104, 15);
            this.lblEventTitle.TabIndex = 1;
            this.lblEventTitle.Text = "Tytuł Wydarzenia*:";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEventTitle.Location = new System.Drawing.Point(17, 68);
            this.txtEventTitle.MaxLength = 100;
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(450, 23);
            this.txtEventTitle.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.Location = new System.Drawing.Point(14, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(38, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Opis*:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(17, 118);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(450, 96);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStartDate.Location = new System.Drawing.Point(14, 226);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(106, 15);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Data Rozpoczęcia*:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(17, 244);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEndDate.Location = new System.Drawing.Point(264, 226);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(112, 15);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "Data Zakończenia*:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(267, 244);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocation.Location = new System.Drawing.Point(14, 278);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 15);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Lokalizacja*:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocation.Location = new System.Drawing.Point(17, 296);
            this.txtLocation.MaxLength = 100;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(450, 23);
            this.txtLocation.TabIndex = 4;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategories.Location = new System.Drawing.Point(14, 330);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(64, 15);
            this.lblCategories.TabIndex = 11;
            this.lblCategories.Text = "Kategorie*:";
            // 
            // clbCategories
            // 
            this.clbCategories.CheckOnClick = true;
            this.clbCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Location = new System.Drawing.Point(17, 348);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(200, 94);
            this.clbCategories.TabIndex = 5;
            // 
            // gbEventDetails
            // 
            this.gbEventDetails.Controls.Add(this.numPricePerTicket);
            this.gbEventDetails.Controls.Add(this.lblPricePerTicket);
            this.gbEventDetails.Controls.Add(this.numAvailableSeats);
            this.gbEventDetails.Controls.Add(this.lblAvailableSeats);
            this.gbEventDetails.Controls.Add(this.dtpEventDate);
            this.gbEventDetails.Controls.Add(this.lblEventDate);
            this.gbEventDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbEventDetails.Location = new System.Drawing.Point(17, 450);
            this.gbEventDetails.Name = "gbEventDetails";
            this.gbEventDetails.Size = new System.Drawing.Size(450, 130);
            this.gbEventDetails.TabIndex = 6;
            this.gbEventDetails.TabStop = false;
            this.gbEventDetails.Text = "Szczegóły Terminu/Biletów (dla tego wydarzenia)";
            // 
            // numPricePerTicket
            // 
            this.numPricePerTicket.DecimalPlaces = 2;
            this.numPricePerTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPricePerTicket.Location = new System.Drawing.Point(130, 88);
            this.numPricePerTicket.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numPricePerTicket.Name = "numPricePerTicket";
            this.numPricePerTicket.Size = new System.Drawing.Size(120, 23);
            this.numPricePerTicket.TabIndex = 2;
            this.numPricePerTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPricePerTicket
            // 
            this.lblPricePerTicket.AutoSize = true;
            this.lblPricePerTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPricePerTicket.Location = new System.Drawing.Point(10, 90);
            this.lblPricePerTicket.Name = "lblPricePerTicket";
            this.lblPricePerTicket.Size = new System.Drawing.Size(89, 15);
            this.lblPricePerTicket.TabIndex = 18;
            this.lblPricePerTicket.Text = "Cena za bilet*:";
            // 
            // numAvailableSeats
            // 
            this.numAvailableSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numAvailableSeats.Location = new System.Drawing.Point(130, 58);
            this.numAvailableSeats.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numAvailableSeats.Name = "numAvailableSeats";
            this.numAvailableSeats.Size = new System.Drawing.Size(120, 23);
            this.numAvailableSeats.TabIndex = 1;
            this.numAvailableSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAvailableSeats
            // 
            this.lblAvailableSeats.AutoSize = true;
            this.lblAvailableSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailableSeats.Location = new System.Drawing.Point(10, 60);
            this.lblAvailableSeats.Name = "lblAvailableSeats";
            this.lblAvailableSeats.Size = new System.Drawing.Size(103, 15);
            this.lblAvailableSeats.TabIndex = 16;
            this.lblAvailableSeats.Text = "Dostępne miejsca*:";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEventDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(130, 28);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEventDate.TabIndex = 0;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEventDate.Location = new System.Drawing.Point(10, 30);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(100, 15);
            this.lblEventDate.TabIndex = 14;
            this.lblEventDate.Text = "Data wydarzenia*:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(367, 605);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(247, 605);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblFormMessage
            // 
            this.lblFormMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormMessage.ForeColor = System.Drawing.Color.Red;
            this.lblFormMessage.Location = new System.Drawing.Point(17, 583);
            this.lblFormMessage.Name = "lblFormMessage";
            this.lblFormMessage.Size = new System.Drawing.Size(450, 19);
            this.lblFormMessage.TabIndex = 16;
            this.lblFormMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormMessage.Visible = false;
            // 
            // AddEditEventForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 651);
            this.Controls.Add(this.lblFormMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEventDetails);
            this.Controls.Add(this.clbCategories);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtEventTitle);
            this.Controls.Add(this.lblEventTitle);
            this.Controls.Add(this.lblTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj/Edytuj Wydarzenie";
            this.gbEventDetails.ResumeLayout(false);
            this.gbEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPricePerTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.GroupBox gbEventDetails;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblAvailableSeats;
        private System.Windows.Forms.NumericUpDown numAvailableSeats;
        private System.Windows.Forms.Label lblPricePerTicket;
        private System.Windows.Forms.NumericUpDown numPricePerTicket;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFormMessage;
    }
}
