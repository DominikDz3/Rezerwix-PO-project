using Rezerwix.Data;
using Microsoft.EntityFrameworkCore;
using Rezerwix.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Rezerwix_project.Forms
{
    public partial class ManageEventsView : UserControl
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly IServiceProvider _serviceProvider;

        public ManageEventsView(IDbContextFactory<AppDbContext> dbContextFactory, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            if (!this.DesignMode)
            {
                SetupDataGridView();
                LoadEventsAsync();
            }

            if (btnAddNewEvent != null) btnAddNewEvent.Click += BtnAddNewEvent_Click;
            if (btnEditSelectedEvent != null) btnEditSelectedEvent.Click += BtnEditSelectedEvent_Click;
            if (btnDeleteSelectedEvent != null) btnDeleteSelectedEvent.Click += BtnDeleteSelectedEvent_Click;
        }

        private void SetupDataGridView()
        {
            if (dgvEvents == null) return;
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.ReadOnly = true;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.BackgroundColor = Color.WhiteSmoke;
            dgvEvents.BorderStyle = BorderStyle.None;
            dgvEvents.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvEvents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvEvents.EnableHeadersVisualStyles = false;
            dgvEvents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dgvEvents.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 48);
            dgvEvents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEvents.GridColor = Color.FromArgb(200, 200, 200);

            dgvEvents.Columns.Clear();
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "EventIdCol", HeaderText = "ID", DataPropertyName = "EventId", Width = 50 });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "TitleCol", HeaderText = "Tytuł", DataPropertyName = "Title", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 30 });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "LocationCol", HeaderText = "Lokalizacja", DataPropertyName = "Location", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "StartDateCol", HeaderText = "Start", DataPropertyName = "StartDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "EndDateCol", HeaderText = "Koniec", DataPropertyName = "EndDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "PriceCol", HeaderText = "Cena (od)", DataPropertyName = "PricePerTicket", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "SeatsCol", HeaderText = "Miejsca (łącznie)", DataPropertyName = "TotalAvailableSeats", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
        }

        private async Task LoadEventsAsync()
        {
            if (dgvEvents == null) return;
            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    var eventsData = await dbContext.Events
                        .AsNoTracking()
                        .Include(e => e.EventDetails)
                        .OrderBy(e => e.StartDate)
                        .Select(e => new
                        {
                            e.EventId,
                            e.Title,
                            e.Location,
                            e.StartDate,
                            e.EndDate,
                            PricePerTicket = e.EventDetails
                                            .Where(ed => ed.EventDate >= DateTime.UtcNow)
                                            .OrderBy(ed => ed.EventDate)
                                            .Select(ed => (decimal?)ed.PricePerTicket)
                                            .FirstOrDefault(),
                            TotalAvailableSeats = e.EventDetails
                                            .Where(ed => ed.EventDate >= DateTime.UtcNow)
                                            .Sum(ed => ed.AvailableSeats)
                        })
                        .ToListAsync();

                    var displayData = eventsData.Select(e => new {
                        e.EventId,
                        e.Title,
                        e.Location,
                        e.StartDate,
                        e.EndDate,
                        PricePerTicket = e.PricePerTicket,
                        TotalAvailableSeats = e.TotalAvailableSeats
                    }).ToList();

                    dgvEvents.DataSource = displayData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania wydarzeń: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAddNewEvent_Click(object sender, EventArgs e)
        {
            using (var addEventForm = _serviceProvider.GetRequiredService<AddEditEventForm>())
            {
                if (addEventForm.ShowDialog(this) == DialogResult.OK)
                {
                    await LoadEventsAsync();
                }
            }
        }

        private async void BtnEditSelectedEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć wydarzenie do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedEventId = (int)dgvEvents.SelectedRows[0].Cells["EventIdCol"].Value;

            Event eventToEdit = null;
            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                eventToEdit = await dbContext.Events
                                    .Include(ev => ev.EventCategories)
                                    .Include(ev => ev.EventDetails)
                                    .FirstOrDefaultAsync(ev => ev.EventId == selectedEventId);
            }

            if (eventToEdit == null)
            {
                MessageBox.Show("Nie można załadować wybranego wydarzenia do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var editEventForm = new AddEditEventForm(_dbContextFactory, eventToEdit))
            {
                if (editEventForm.ShowDialog(this) == DialogResult.OK)
                {
                    await LoadEventsAsync();
                }
            }
        }

        private async void BtnDeleteSelectedEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć wydarzenie do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedEventId = (int)dgvEvents.SelectedRows[0].Cells["EventIdCol"].Value;
            var selectedEventTitle = dgvEvents.SelectedRows[0].Cells["TitleCol"].Value?.ToString() ?? "Nieznane wydarzenie";

            var confirmResult = MessageBox.Show($"Czy na pewno chcesz usunąć wydarzenie: '{selectedEventTitle}' (ID: {selectedEventId})?\nSpowoduje to również usunięcie powiązanych szczegółów terminów i rezerwacji.",
                                               "Potwierdź usunięcie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var dbContext = _dbContextFactory.CreateDbContext())
                    {
                        var eventToDelete = await dbContext.Events
                                                .Include(e => e.EventCategories)
                                                .FirstOrDefaultAsync(e => e.EventId == selectedEventId);

                        if (eventToDelete != null)
                        {
                            if (eventToDelete.EventCategories != null && eventToDelete.EventCategories.Any())
                            {
                                dbContext.EventCategories.RemoveRange(eventToDelete.EventCategories);
                            }

                            dbContext.Events.Remove(eventToDelete);
                            await dbContext.SaveChangesAsync();
                            await LoadEventsAsync();
                            MessageBox.Show("Wydarzenie zostało usunięte.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono wydarzenia do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas usuwania wydarzenia: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
