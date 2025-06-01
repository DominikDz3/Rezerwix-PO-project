using Rezerwix.Data;
using Rezerwix.Models;
using Microsoft.EntityFrameworkCore;

namespace Rezerwix_project.Forms
{
    public partial class EventDetailsView : UserControl
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly MainForm _mainForm;

        private Event _currentEvent;
        private EventDetail _currentEventDetail;

        public event EventHandler RequestGoBack;

        public EventDetailsView(IDbContextFactory<AppDbContext> dbContextFactory, MainForm mainForm)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            if (this.numTickets != null)
            {
                this.numTickets.ValueChanged += NumTickets_ValueChanged;
            }
            if (this.btnReserve != null)
            {
                this.btnReserve.Click += BtnReserve_Click;
            }
            if (this.btnBack != null)
            {
                this.btnBack.Click += BtnBack_Click;
            }
        }

        public async Task LoadEventDetailsAsync(int eventId)
        {
            _currentEvent = null;
            _currentEventDetail = null;

            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    _currentEvent = await dbContext.Events
                        .AsNoTracking()
                        .Include(e => e.EventCategories)
                            .ThenInclude(ec => ec.Category)
                        .Include(e => e.EventDetails)
                        .FirstOrDefaultAsync(e => e.EventId == eventId);
                }

                if (_currentEvent == null)
                {
                    MessageBox.Show("Nie znaleziono wydarzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RequestGoBack?.Invoke(this, EventArgs.Empty);
                    return;
                }

                _currentEventDetail = _currentEvent.EventDetails
                                        .Where(ed => ed.EventDate >= DateTime.Now) 
                                        .OrderBy(ed => ed.EventDate)
                                        .FirstOrDefault() ??
                                      _currentEvent.EventDetails 
                                        .OrderByDescending(ed => ed.EventDate)
                                        .FirstOrDefault();

                PopulateControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania szczegółów wydarzenia: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RequestGoBack?.Invoke(this, EventArgs.Empty);
            }
        }

        private void PopulateControls()
        {
            if (_currentEvent == null) return;

            if (lblEventTitle != null) lblEventTitle.Text = _currentEvent.Title;
            if (lblEventDates != null) lblEventDates.Text = $"Od: {_currentEvent.StartDate:yyyy-MM-dd HH:mm} Do: {_currentEvent.EndDate:yyyy-MM-dd HH:mm}";
            if (lblLocation != null) lblLocation.Text = $"Lokalizacja: {_currentEvent.Location}";
            if (lblCategories != null) lblCategories.Text = $"Kategorie: {string.Join(", ", _currentEvent.EventCategories.Select(ec => ec.Category.Name))}";
            if (richTextBoxDescription != null) richTextBoxDescription.Text = _currentEvent.Description;

            bool canReserveAnyTickets = false;

            if (_currentEventDetail != null)
            {
                if (lblPricePerTicket != null) lblPricePerTicket.Text = $"Cena za bilet: {_currentEventDetail.PricePerTicket:C}";

                bool eventStarted = _currentEventDetail.EventDate < DateTime.Now;
                canReserveAnyTickets = _currentEventDetail.AvailableSeats > 0 && !eventStarted;

                if (lblAvailableSeats != null)
                {
                    if (eventStarted)
                    {
                        lblAvailableSeats.Text = "Dostępne miejsca: (Wydarzenie rozpoczęte/zakończone)";
                    }
                    else if (_currentEventDetail.AvailableSeats <= 0)
                    {
                        lblAvailableSeats.Text = "Dostępne miejsca: BRAK";
                    }
                    else
                    {
                        lblAvailableSeats.Text = $"Dostępne miejsca: {_currentEventDetail.AvailableSeats}";
                    }
                }

                if (numTickets != null)
                {
                    if (canReserveAnyTickets)
                    {
                        numTickets.Minimum = 1;
                        numTickets.Maximum = _currentEventDetail.AvailableSeats;
                        numTickets.Value = 1;
                        numTickets.Enabled = true;
                    }
                    else
                    {
                        numTickets.Minimum = 0;
                        numTickets.Maximum = 0;
                        numTickets.Value = 0;
                        numTickets.Enabled = false;
                    }
                }
                if (btnReserve != null) btnReserve.Enabled = canReserveAnyTickets;
                UpdateTotalPrice();
            }
            else 
            {
                if (lblPricePerTicket != null) lblPricePerTicket.Text = "Cena za bilet: N/A";
                if (lblAvailableSeats != null) lblAvailableSeats.Text = "Dostępne miejsca: N/A";
                if (numTickets != null) { numTickets.Enabled = false; numTickets.Minimum = 0; numTickets.Value = 0; }
                if (btnReserve != null) btnReserve.Enabled = false;
                if (lblTotalPrice != null) lblTotalPrice.Text = "Łącznie: -";
            }
        }

        private void NumTickets_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (_currentEventDetail != null && numTickets != null && lblTotalPrice != null && numTickets.Enabled && numTickets.Value > 0)
            {
                decimal totalPrice = numTickets.Value * _currentEventDetail.PricePerTicket;
                lblTotalPrice.Text = $"Łącznie: {totalPrice:C}";
            }
            else if (lblTotalPrice != null)
            {
                lblTotalPrice.Text = "Łącznie: -";
            }
        }

        private async void BtnReserve_Click(object sender, EventArgs e)
        {
            if (_mainForm.CurrentUser == null)
            {
                MessageBox.Show("Musisz być zalogowany, aby dokonać rezerwacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentEvent == null || _currentEventDetail == null)
            {
                MessageBox.Show("Nie można dokonać rezerwacji. Brak szczegółów wydarzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentEventDetail.EventDate < DateTime.Now)
            {
                MessageBox.Show("Nie można zarezerwować biletów. Wydarzenie już się rozpoczęło lub zakończyło.", "Rezerwacja niemożliwa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                await LoadEventDetailsAsync(_currentEvent.EventId);
                return;
            }

            int ticketsToReserve = (int)numTickets.Value;
            if (ticketsToReserve <= 0)
            {
                MessageBox.Show("Liczba biletów musi być większa od zera.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dbContext = _dbContextFactory.CreateDbContext())
            using (var transaction = await dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var eventDetailToUpdate = await dbContext.EventDetails.FindAsync(_currentEventDetail.EventDetailId);
                    if (eventDetailToUpdate == null)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show("Wystąpił błąd. Szczegóły wydarzenia nie zostały znalezione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        await LoadEventDetailsAsync(_currentEvent.EventId);
                        return;
                    }
                    if (eventDetailToUpdate.EventDate < DateTime.Now)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show("Nie można zarezerwować biletów. Wydarzenie właśnie się rozpoczęło lub zakończyło.", "Rezerwacja niemożliwa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        await LoadEventDetailsAsync(_currentEvent.EventId);
                        return;
                    }
                    if (eventDetailToUpdate.AvailableSeats < ticketsToReserve)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"Miejsca zostały w międzyczasie zarezerwowane lub ich liczba jest niewystarczająca. Dostępne: {eventDetailToUpdate.AvailableSeats}", "Konflikt rezerwacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        await LoadEventDetailsAsync(_currentEvent.EventId);
                        return;
                    }

                    eventDetailToUpdate.AvailableSeats -= ticketsToReserve;
                    var reservation = new Reservation
                    {
                        ReservationDate = DateTime.UtcNow,
                        NumberOfTickets = ticketsToReserve,
                        UserId = _mainForm.CurrentUser.UserId,
                        EventDetailId = _currentEventDetail.EventDetailId
                    };
                    dbContext.Reservations.Add(reservation);
                    await dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    MessageBox.Show($"Pomyślnie zarezerwowano {ticketsToReserve} bilet(ów) na wydarzenie: {_currentEvent.Title}!", "Rezerwacja udana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadEventDetailsAsync(_currentEvent.EventId);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    MessageBox.Show($"Wystąpił błąd podczas rezerwacji: {ex.Message}", "Błąd rezerwacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            RequestGoBack?.Invoke(this, EventArgs.Empty);
        }
    }
}
