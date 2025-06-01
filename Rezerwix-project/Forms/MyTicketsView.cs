// MyTicketsView.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using Rezerwix.Data;
using Rezerwix.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Rezerwix_project.Forms
{
    public partial class MyTicketsView : UserControl
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly MainForm _mainForm;

        private class MyTicketViewModel
        {
            public int ReservationId { get; set; }
            public string EventTitle { get; set; }
            public DateTime EventDate { get; set; }
            public int NumberOfTickets { get; set; }
            public DateTime ReservationDate { get; set; }
            public string Status { get; set; }
        }

        public MyTicketsView(IDbContextFactory<AppDbContext> dbContextFactory, MainForm mainForm)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            if (!this.DesignMode)
            {
                SetupDataGridView();
                LoadUserTicketsAsync();
            }
        }

        private void SetupDataGridView()
        {
            if (dgvMyTickets == null) return;

            dgvMyTickets.AutoGenerateColumns = false;
            dgvMyTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyTickets.AllowUserToAddRows = false;
            dgvMyTickets.AllowUserToDeleteRows = false;
            dgvMyTickets.RowHeadersVisible = false;
            dgvMyTickets.BackgroundColor = Color.WhiteSmoke;
            dgvMyTickets.BorderStyle = BorderStyle.None;
            dgvMyTickets.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvMyTickets.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvMyTickets.EnableHeadersVisualStyles = false;
            dgvMyTickets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMyTickets.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dgvMyTickets.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 48);
            dgvMyTickets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMyTickets.GridColor = Color.FromArgb(200, 200, 200);

            dgvMyTickets.Columns.Clear();
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "EventTitleCol", HeaderText = "Wydarzenie", DataPropertyName = "EventTitle", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 30, ReadOnly = true });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "EventDateCol", HeaderText = "Data wydarzenia", DataPropertyName = "EventDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "TicketsCol", HeaderText = "Bilety", DataPropertyName = "NumberOfTickets", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ReservationDateCol", HeaderText = "Data rezerwacji", DataPropertyName = "ReservationDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "StatusCol", HeaderText = "Status", DataPropertyName = "Status", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, ReadOnly = true });

            var cancelButtonColumn = new DataGridViewButtonColumn
            {
                Name = "CancelCol",
                HeaderText = "Akcja",
                UseColumnTextForButtonValue = false,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle { Padding = new Padding(2), Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dgvMyTickets.Columns.Add(cancelButtonColumn);
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReservationIdCol", DataPropertyName = "ReservationId", Visible = false, ReadOnly = true });
        }

        public async Task LoadUserTicketsAsync()
        {
            if (dgvMyTickets == null || _mainForm.CurrentUser == null)
            {
                if (dgvMyTickets != null) dgvMyTickets.DataSource = null;
                return;
            }

            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    var userId = _mainForm.CurrentUser.UserId;
                    var userTicketsData = await dbContext.Reservations
                        .AsNoTracking()
                        .Include(r => r.EventDetail)
                            .ThenInclude(ed => ed.Event)
                        .Where(r => r.UserId == userId)
                        .OrderByDescending(r => r.ReservationDate)
                        .Select(r => new MyTicketViewModel
                        {
                            ReservationId = r.ReservationId,
                            EventTitle = r.EventDetail.Event.Title,
                            EventDate = r.EventDetail.EventDate,
                            NumberOfTickets = r.NumberOfTickets,
                            ReservationDate = r.ReservationDate,
                            Status = r.EventDetail.EventDate < DateTime.UtcNow ? "Zakończona" : "Aktywna"
                        })
                        .ToListAsync();

                    dgvMyTickets.DataSource = userTicketsData;

                    foreach (DataGridViewRow row in dgvMyTickets.Rows)
                    {
                        if (row.DataBoundItem is MyTicketViewModel ticketVM && row.Cells["CancelCol"] is DataGridViewButtonCell buttonCell)
                        {
                            bool canCancel = ticketVM.Status == "Aktywna";
                            buttonCell.ReadOnly = !canCancel;

                            if (!canCancel)
                            {
                                buttonCell.Value = "---";
                                buttonCell.Style.BackColor = Color.LightGray;
                                buttonCell.Style.ForeColor = Color.DarkGray;
                                buttonCell.FlatStyle = FlatStyle.Standard;
                            }
                            else
                            {
                                buttonCell.Value = "Anuluj";
                                buttonCell.Style.BackColor = Color.Tomato;
                                buttonCell.Style.ForeColor = Color.White;
                                buttonCell.FlatStyle = FlatStyle.Flat;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania biletów: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvMyTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMyTickets.Columns[e.ColumnIndex].Name != "CancelCol")
                return;

            if (!(dgvMyTickets.Rows[e.RowIndex].DataBoundItem is MyTicketViewModel ticketVM)) return;

            DataGridViewButtonCell buttonCell = dgvMyTickets.Rows[e.RowIndex].Cells["CancelCol"] as DataGridViewButtonCell;
            if (buttonCell == null || buttonCell.ReadOnly)
            {
                return;
            }

            var confirmResult = MessageBox.Show($"Czy na pewno chcesz anulować rezerwację na wydarzenie '{ticketVM.EventTitle}' ({ticketVM.NumberOfTickets} biletów)?",
                                               "Potwierdź anulowanie",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                using (var transaction = await dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var reservationToCancel = await dbContext.Reservations
                            .Include(r => r.EventDetail)
                            .FirstOrDefaultAsync(r => r.ReservationId == ticketVM.ReservationId);

                        if (reservationToCancel == null)
                        {
                            MessageBox.Show("Nie znaleziono rezerwacji do anulowania w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            await transaction.RollbackAsync();
                            return;
                        }

                        if (reservationToCancel.EventDetail.EventDate < DateTime.UtcNow)
                        {
                            MessageBox.Show("Nie można anulować rezerwacji na wydarzenie, które już się odbyło lub właśnie się odbywa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            await transaction.RollbackAsync();
                            await LoadUserTicketsAsync();
                            return;
                        }

                        reservationToCancel.EventDetail.AvailableSeats += reservationToCancel.NumberOfTickets;

                        dbContext.Reservations.Remove(reservationToCancel);
                        await dbContext.SaveChangesAsync();
                        await transaction.CommitAsync();

                        MessageBox.Show("Rezerwacja została pomyślnie anulowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadUserTicketsAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"Błąd podczas anulowania rezerwacji: {ex.Message}", "Błąd Krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
