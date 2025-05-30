using Rezerwix.Data;
using Microsoft.EntityFrameworkCore;

namespace Rezerwix_project.Forms
{
    public partial class MyTicketsView : UserControl
    {
        private readonly AppDbContext _dbContext;
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

        public MyTicketsView(AppDbContext dbContext, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
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
            dgvMyTickets.ReadOnly = true;
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

            // Definicja kolumn
            dgvMyTickets.Columns.Clear();
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "EventTitleCol", HeaderText = "Wydarzenie", DataPropertyName = "EventTitle", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 30 });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "EventDateCol", HeaderText = "Data wydarzenia", DataPropertyName = "EventDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "TicketsCol", HeaderText = "Bilety", DataPropertyName = "NumberOfTickets", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ReservationDateCol", HeaderText = "Data rezerwacji", DataPropertyName = "ReservationDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "StatusCol", HeaderText = "Status", DataPropertyName = "Status", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });

            var cancelButtonColumn = new DataGridViewButtonColumn
            {
                Name = "CancelCol",
                HeaderText = "Akcja",
                Text = "Anuluj",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Tomato, ForeColor = Color.White, Padding = new Padding(2), Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dgvMyTickets.Columns.Add(cancelButtonColumn);

            dgvMyTickets.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReservationIdCol", DataPropertyName = "ReservationId", Visible = false });
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
                var userId = _mainForm.CurrentUser.UserId;
                var userTicketsData = await _dbContext.Reservations
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
                    if (row.DataBoundItem is MyTicketViewModel ticketVM)
                    {
                        DataGridViewCell buttonCell = row.Cells["CancelCol"];
                        if (buttonCell != null)
                        {
                            buttonCell.ReadOnly = !(ticketVM.Status == "Aktywna" && ticketVM.EventDate > DateTime.UtcNow);
                            if (buttonCell.ReadOnly)
                            {
                                buttonCell.Style.BackColor = Color.Gray;
                                buttonCell.Style.ForeColor = Color.DarkGray;
                                ((DataGridViewButtonCell)buttonCell).UseColumnTextForButtonValue = true;
                                buttonCell.Value = "Anuluj";
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
            if (e.RowIndex < 0 || e.ColumnIndex != dgvMyTickets.Columns["CancelCol"].Index)
                return;

            var ticketVM = dgvMyTickets.Rows[e.RowIndex].DataBoundItem as MyTicketViewModel;
            if (ticketVM == null || !(ticketVM.Status == "Aktywna" && ticketVM.EventDate > DateTime.UtcNow))
            {
                return;
            }

            var confirmResult = MessageBox.Show($"Czy na pewno chcesz anulować rezerwację na wydarzenie '{ticketVM.EventTitle}' ({ticketVM.NumberOfTickets} biletów)?",
                                               "Potwierdź anulowanie",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (var transaction = await _dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var reservationToCancel = await _dbContext.Reservations
                            .Include(r => r.EventDetail)
                            .FirstOrDefaultAsync(r => r.ReservationId == ticketVM.ReservationId);

                        if (reservationToCancel == null)
                        {
                            MessageBox.Show("Nie znaleziono rezerwacji do anulowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        _dbContext.Reservations.Remove(reservationToCancel);
                        await _dbContext.SaveChangesAsync();
                        await transaction.CommitAsync();

                        MessageBox.Show("Rezerwacja została pomyślnie anulowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadUserTicketsAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"Błąd podczas anulowania rezerwacji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
