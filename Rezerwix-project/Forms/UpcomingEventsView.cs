using Rezerwix.Data;
using Microsoft.EntityFrameworkCore;

namespace Rezerwix_project.Forms
{
    public partial class UpcomingEventsView : UserControl
    {
        private readonly AppDbContext _dbContext;
        private readonly IServiceProvider _serviceProvider;
        private readonly MainForm _mainForm;

        public event EventHandler<int> RequestEventDetailsView;

        public UpcomingEventsView(AppDbContext dbContext, IServiceProvider serviceProvider, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            if (!this.DesignMode)
            {
                ConfigureFilterControls();
                LoadUpcomingEventsAsync();
            }
        }

        private async void ConfigureFilterControls()
        {
            if (cmbCategoryFilter != null)
            {
                var categories = await _dbContext.Categories.OrderBy(c => c.Name).ToListAsync();
                var displayCategories = new List<object> { new { Name = "Wszystkie Kategorie", Id = 0 } };
                displayCategories.AddRange(categories.Select(c => new { Name = c.Name, Id = c.CategoryId }).ToList<object>());

                cmbCategoryFilter.DataSource = displayCategories;
                cmbCategoryFilter.DisplayMember = "Name";
                cmbCategoryFilter.ValueMember = "Id";
                cmbCategoryFilter.SelectedIndex = 0;
            }

            if (btnApplyFilters != null)
            {
                btnApplyFilters.Click -= BtnApplyFilters_Click;
                btnApplyFilters.Click += BtnApplyFilters_Click;
            }
            if (btnClearFilters != null)
            {
                btnClearFilters.Click -= BtnClearFilters_Click;
                btnClearFilters.Click += BtnClearFilters_Click;
            }
            if (txtSearchEvents != null)
            {
                txtSearchEvents.KeyDown += TxtSearchEvents_KeyDown;
            }
        }

        private void TxtSearchEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnApplyFilters_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private async void BtnApplyFilters_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchEvents?.Text.Trim();
            int? categoryId = null;
            if (cmbCategoryFilter?.SelectedValue != null && (int)cmbCategoryFilter.SelectedValue != 0)
            {
                categoryId = (int)cmbCategoryFilter.SelectedValue;
            }
            await LoadUpcomingEventsAsync(searchTerm, categoryId);
        }

        private async void BtnClearFilters_Click(object sender, EventArgs e)
        {
            if (txtSearchEvents != null) txtSearchEvents.Clear();
            if (cmbCategoryFilter != null) cmbCategoryFilter.SelectedIndex = 0;
            await LoadUpcomingEventsAsync();
        }

        private async Task LoadUpcomingEventsAsync(string searchTerm = null, int? categoryId = null)
        {
            if (this.flowLayoutPanelEvents == null)
            {
                MessageBox.Show("Błąd: flowLayoutPanelEvents nie został zainicjalizowany.", "Błąd UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.flowLayoutPanelEvents.Controls.Clear();

            try
            {
                var query = _dbContext.Events
                    .AsNoTracking()
                    .Include(e => e.EventCategories)
                        .ThenInclude(ec => ec.Category)
                    .Where(e => e.EndDate >= DateTime.UtcNow);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    query = query.Where(e => e.Title.ToLower().Contains(searchTerm.ToLower()) ||
                                             e.Location.ToLower().Contains(searchTerm.ToLower()));
                }

                if (categoryId.HasValue && categoryId.Value != 0)
                {
                    query = query.Where(e => e.EventCategories.Any(ec => ec.CategoryId == categoryId.Value));
                }

                var upcomingEventsData = await query
                    .OrderBy(e => e.StartDate)
                    .Select(e => new EventCardViewModel
                    {
                        EventId = e.EventId,
                        Title = e.Title,
                        Location = e.Location,
                        StartDate = e.StartDate,
                        Categories = string.Join(", ", e.EventCategories.Select(ec => ec.Category.Name))
                    })
                    .Take(50)
                    .ToListAsync();

                if (!upcomingEventsData.Any())
                {
                    Label noEventsLabel = new Label
                    {
                        Text = "Brak wydarzeń spełniających kryteria.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12F),
                        ForeColor = Color.Gray,
                        Margin = new Padding(10)
                    };
                    this.flowLayoutPanelEvents.Controls.Add(noEventsLabel);
                    return;
                }

                foreach (var eventData in upcomingEventsData)
                {
                    var card = new EventCardControl();
                    card.SetEventData(eventData);
                    card.DetailsClicked += EventCard_DetailsClicked;
                    this.flowLayoutPanelEvents.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania wydarzeń: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EventCard_DetailsClicked(object sender, int eventId)
        {
            RequestEventDetailsView?.Invoke(this, eventId);
        }
    }
}
