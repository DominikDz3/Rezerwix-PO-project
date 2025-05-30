using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Rezerwix.Models;

namespace Rezerwix_project.Forms
{
    public partial class AddEditEventForm : Form
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private Event _eventToEdit;
        private List<Category> _allCategories;

        public AddEditEventForm(IDbContextFactory<AppDbContext> dbContextFactory, Event eventToEdit = null)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _eventToEdit = eventToEdit;

            LoadCategoriesAsync();

            if (_eventToEdit != null)
            {
                this.Text = "Edytuj Wydarzenie";
                if (lblTitleForm != null) lblTitleForm.Text = "Edytuj Wydarzenie";
                PopulateFormForEdit();
            }
            else
            {
                this.Text = "Dodaj Nowe Wydarzenie";
                if (lblTitleForm != null) lblTitleForm.Text = "Dodaj Nowe Wydarzenie";
                if (dtpStartDate != null) dtpStartDate.Value = DateTime.Now.Date.AddDays(1).AddHours(18); // Jutro o 18:00
                if (dtpEndDate != null) dtpEndDate.Value = DateTime.Now.Date.AddDays(1).AddHours(22);   // Jutro o 22:00
                if (dtpEventDate != null) dtpEventDate.Value = dtpStartDate.Value;
            }

            if (btnSave != null) btnSave.Click += BtnSave_Click;
            if (btnCancel != null) btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            if (dtpEventDate != null && dtpStartDate != null && dtpEndDate != null)
            {
                dtpEventDate.ValueChanged += ValidateEventDetailDate;
                dtpStartDate.ValueChanged += ValidateEventDetailDate;
                dtpEndDate.ValueChanged += ValidateEventDetailDate;
            }
        }

        private async void LoadCategoriesAsync()
        {
            if (clbCategories == null) return;
            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                _allCategories = await dbContext.Categories.OrderBy(c => c.Name).ToListAsync();
                clbCategories.DataSource = _allCategories;
                clbCategories.DisplayMember = "Name";
                clbCategories.ValueMember = "CategoryId";
            }
        }

        private async void PopulateFormForEdit()
        {
            if (_eventToEdit == null || txtEventTitle == null) return;

            txtEventTitle.Text = _eventToEdit.Title;
            txtDescription.Text = _eventToEdit.Description;
            dtpStartDate.Value = _eventToEdit.StartDate.ToLocalTime();
            dtpEndDate.Value = _eventToEdit.EndDate.ToLocalTime();
            txtLocation.Text = _eventToEdit.Location;

            if (clbCategories != null && _eventToEdit.EventCategories != null)
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    var eventWithCategories = await dbContext.Events
                                                    .Include(e => e.EventCategories)
                                                    .FirstOrDefaultAsync(e => e.EventId == _eventToEdit.EventId);
                    if (eventWithCategories?.EventCategories != null)
                    {
                        for (int i = 0; i < clbCategories.Items.Count; i++)
                        {
                            if (clbCategories.Items[i] is Category cat)
                            {
                                if (eventWithCategories.EventCategories.Any(ec => ec.CategoryId == cat.CategoryId))
                                {
                                    clbCategories.SetItemChecked(i, true);
                                }
                            }
                        }
                    }
                }
            }

            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                var eventDetail = await dbContext.EventDetails
                                        .FirstOrDefaultAsync(ed => ed.EventId == _eventToEdit.EventId);
                if (eventDetail != null)
                {
                    dtpEventDate.Value = eventDetail.EventDate.ToLocalTime();
                    numAvailableSeats.Value = eventDetail.AvailableSeats;
                    numPricePerTicket.Value = eventDetail.PricePerTicket;
                }
            }
        }

        private void ValidateEventDetailDate(object sender, EventArgs e)
        {
            if (dtpEventDate.Value < dtpStartDate.Value || dtpEventDate.Value > dtpEndDate.Value)
            {
                ShowFormMessage("Data szczegółu wydarzenia (terminu) musi zawierać się w datach ramowych wydarzenia.", false);
            }
            else
            {
                if (lblFormMessage.Visible && lblFormMessage.Text.Contains("Data szczegółu"))
                {
                    lblFormMessage.Visible = false;
                }
            }
        }


        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventTitle.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                clbCategories.CheckedItems.Count == 0)
            {
                ShowFormMessage("Wszystkie pola oznaczone * oraz co najmniej jedna kategoria są wymagane.", false);
                return;
            }

            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                ShowFormMessage("Data zakończenia musi być późniejsza niż data rozpoczęcia.", false);
                return;
            }

            if (dtpEventDate.Value < dtpStartDate.Value || dtpEventDate.Value > dtpEndDate.Value)
            {
                ShowFormMessage("Data szczegółu wydarzenia (terminu) musi zawierać się w datach ramowych wydarzenia.", false);
                return;
            }

            bool isNewEvent = _eventToEdit == null;
            Event eventToSave = isNewEvent ? new Event() : await _dbContextFactory.CreateDbContext().Events.Include(ev => ev.EventCategories).Include(ev => ev.EventDetails).FirstOrDefaultAsync(ev => ev.EventId == _eventToEdit.EventId);

            if (eventToSave == null && !isNewEvent)
            {
                ShowFormMessage("Nie można znaleźć wydarzenia do edycji.", false);
                return;
            }

            eventToSave.Title = txtEventTitle.Text.Trim();
            eventToSave.Description = txtDescription.Text.Trim();
            eventToSave.StartDate = DateTime.SpecifyKind(dtpStartDate.Value, DateTimeKind.Utc);
            eventToSave.EndDate = DateTime.SpecifyKind(dtpEndDate.Value, DateTimeKind.Utc);
            eventToSave.Location = txtLocation.Text.Trim();

            var validationContextEvent = new ValidationContext(eventToSave);
            var validationResultsEvent = new List<ValidationResult>();
            if (!Validator.TryValidateObject(eventToSave, validationContextEvent, validationResultsEvent, true))
            {
                ShowFormMessage(string.Join(Environment.NewLine, validationResultsEvent.Select(r => r.ErrorMessage)), false);
                return;
            }

            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                if (isNewEvent)
                {
                    dbContext.Events.Add(eventToSave);
                }
                else
                {
                    dbContext.Events.Update(eventToSave);
                    var existingCategories = await dbContext.EventCategories.Where(ec => ec.EventId == eventToSave.EventId).ToListAsync();
                    if (existingCategories.Any()) dbContext.EventCategories.RemoveRange(existingCategories);
                }

                eventToSave.EventCategories = new List<EventCategory>();
                foreach (Category selectedCategory in clbCategories.CheckedItems)
                {
                    eventToSave.EventCategories.Add(new EventCategory { CategoryId = selectedCategory.CategoryId });
                }

                EventDetail eventDetailToSave;
                if (isNewEvent)
                {
                    eventDetailToSave = new EventDetail();
                    eventToSave.EventDetails = new List<EventDetail> { eventDetailToSave };
                }
                else
                {
                    eventDetailToSave = await dbContext.EventDetails.FirstOrDefaultAsync(ed => ed.EventId == eventToSave.EventId);
                    if (eventDetailToSave == null)
                    {
                        eventDetailToSave = new EventDetail();
                        eventToSave.EventDetails.Add(eventDetailToSave);
                    }
                }

                eventDetailToSave.EventDate = DateTime.SpecifyKind(dtpEventDate.Value, DateTimeKind.Utc);
                eventDetailToSave.AvailableSeats = (int)numAvailableSeats.Value;
                eventDetailToSave.PricePerTicket = numPricePerTicket.Value;

                var validationContextDetail = new ValidationContext(eventDetailToSave);
                var validationResultsDetail = new List<ValidationResult>();
                if (!Validator.TryValidateObject(eventDetailToSave, validationContextDetail, validationResultsDetail, true))
                {
                    ShowFormMessage(string.Join(Environment.NewLine, validationResultsDetail.Select(r => r.ErrorMessage)), false);
                    return;
                }

                try
                {
                    await dbContext.SaveChangesAsync();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    ShowFormMessage($"Błąd zapisu: {ex.Message}", false);
                }
            }
        }

        private void ShowFormMessage(string message, bool isSuccess)
        {
            if (lblFormMessage == null) return;
            lblFormMessage.Text = message;
            lblFormMessage.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblFormMessage.Visible = true;
        }
    }
}
