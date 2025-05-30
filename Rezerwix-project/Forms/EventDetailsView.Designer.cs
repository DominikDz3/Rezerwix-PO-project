// EventDetailsView.Designer.cs
namespace Rezerwix_project.Forms
{
    partial class EventDetailsView
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.lblEventDates = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.reservationPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblAvailableSeats = new System.Windows.Forms.Label();
            this.lblPricePerTicket = new System.Windows.Forms.Label();
            this.lblReservationSectionTitle = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.reservationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.lblEventTitle, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.lblEventDates, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.lblLocation, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.lblCategories, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.richTextBoxDescription, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.reservationPanel, 0, 5);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(15, 15);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(754, 531);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEventTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEventTitle.Location = new System.Drawing.Point(3, 0);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(748, 40);
            this.lblEventTitle.TabIndex = 0;
            this.lblEventTitle.Text = "Tytuł Wydarzenia";
            this.lblEventTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEventDates
            // 
            this.lblEventDates.AutoSize = true;
            this.lblEventDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventDates.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEventDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEventDates.Location = new System.Drawing.Point(3, 40);
            this.lblEventDates.Name = "lblEventDates";
            this.lblEventDates.Size = new System.Drawing.Size(748, 25);
            this.lblEventDates.TabIndex = 1;
            this.lblEventDates.Text = "Data: YYYY-MM-DD HH:MM - YYYY-MM-DD HH:MM";
            this.lblEventDates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblLocation.Location = new System.Drawing.Point(3, 65);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(748, 25);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Lokalizacja: Miasto";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI Italic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCategories.Location = new System.Drawing.Point(3, 90);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(748, 25);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Kategorie: Sport, Muzyka";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.White;
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(3, 118);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(748, 210);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "Długi opis wydarzenia...";
            // 
            // reservationPanel
            // 
            this.reservationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.reservationPanel.Controls.Add(this.btnBack);
            this.reservationPanel.Controls.Add(this.btnReserve);
            this.reservationPanel.Controls.Add(this.lblTotalPrice);
            this.reservationPanel.Controls.Add(this.numTickets);
            this.reservationPanel.Controls.Add(this.lblNumberOfTickets);
            this.reservationPanel.Controls.Add(this.lblAvailableSeats);
            this.reservationPanel.Controls.Add(this.lblPricePerTicket);
            this.reservationPanel.Controls.Add(this.lblReservationSectionTitle);
            this.reservationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationPanel.Location = new System.Drawing.Point(3, 334);
            this.reservationPanel.Name = "reservationPanel";
            this.reservationPanel.Padding = new System.Windows.Forms.Padding(10);
            this.reservationPanel.Size = new System.Drawing.Size(748, 194);
            this.reservationPanel.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 149);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(562, 90);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(170, 45);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Zarezerwuj Bilety";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(562, 55);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(170, 23);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Łącznie: 0.00 zł";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTickets
            // 
            this.numTickets.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numTickets.Location = new System.Drawing.Point(152, 105);
            this.numTickets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(70, 25);
            this.numTickets.TabIndex = 4;
            this.numTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTickets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumberOfTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblNumberOfTickets.Location = new System.Drawing.Point(15, 107);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(86, 17);
            this.lblNumberOfTickets.TabIndex = 3;
            this.lblNumberOfTickets.Text = "Liczba biletów:";
            // 
            // lblAvailableSeats
            // 
            this.lblAvailableSeats.AutoSize = true;
            this.lblAvailableSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAvailableSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblAvailableSeats.Location = new System.Drawing.Point(15, 75);
            this.lblAvailableSeats.Name = "lblAvailableSeats";
            this.lblAvailableSeats.Size = new System.Drawing.Size(107, 17);
            this.lblAvailableSeats.TabIndex = 2;
            this.lblAvailableSeats.Text = "Dostępne miejsca:";
            // 
            // lblPricePerTicket
            // 
            this.lblPricePerTicket.AutoSize = true;
            this.lblPricePerTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPricePerTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblPricePerTicket.Location = new System.Drawing.Point(15, 45);
            this.lblPricePerTicket.Name = "lblPricePerTicket";
            this.lblPricePerTicket.Size = new System.Drawing.Size(91, 17);
            this.lblPricePerTicket.TabIndex = 1;
            this.lblPricePerTicket.Text = "Cena za bilet: ";
            // 
            // lblReservationSectionTitle
            // 
            this.lblReservationSectionTitle.AutoSize = true;
            this.lblReservationSectionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReservationSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblReservationSectionTitle.Location = new System.Drawing.Point(13, 10);
            this.lblReservationSectionTitle.Name = "lblReservationSectionTitle";
            this.lblReservationSectionTitle.Size = new System.Drawing.Size(141, 21);
            this.lblReservationSectionTitle.TabIndex = 0;
            this.lblReservationSectionTitle.Text = "Zarezerwuj Bilety";
            // 
            // EventDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "EventDetailsView";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(784, 561);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.reservationPanel.ResumeLayout(false);
            this.reservationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.Label lblEventDates;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Panel reservationPanel;
        private System.Windows.Forms.Label lblReservationSectionTitle;
        private System.Windows.Forms.Label lblPricePerTicket;
        private System.Windows.Forms.Label lblAvailableSeats;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnBack;
    }
}
