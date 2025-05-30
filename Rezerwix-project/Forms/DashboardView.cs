using Rezerwix.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Rezerwix_project.Forms
{
    public partial class DashboardView : UserControl
    {
        private readonly MainForm _mainForm;
        private readonly AppDbContext _dbContext;
        private readonly IServiceProvider _serviceProvider;
        private UserControl _currentContentPanelControl = null;

        public DashboardView(MainForm mainForm, AppDbContext dbContext, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            ConfigureDashboardControls();

            if (!this.DesignMode)
            {
                ShowWelcomeMessageInContentPanel();
            }
        }

        private void ConfigureDashboardControls()
        {
            if (this.lblContentWelcome != null)
            {
                if (_mainForm.CurrentUser != null)
                {
                    this.lblContentWelcome.Text = $"Witaj, {_mainForm.CurrentUser.FirstName} {_mainForm.CurrentUser.LastName}!";
                }
                else
                {
                    this.lblContentWelcome.Text = "Witaj w Rezerwix!";
                }
            }

            if (this.btnUpcomingEvents != null)
            {
                this.btnUpcomingEvents.Click -= BtnUpcomingEvents_Click;
                this.btnUpcomingEvents.Click += BtnUpcomingEvents_Click;
            }
            if (this.btnMyTickets != null)
            {
                this.btnMyTickets.Click -= BtnMyTickets_Click;
                this.btnMyTickets.Click += BtnMyTickets_Click;
            }
            if (this.btnMyProfile != null)
            {
                this.btnMyProfile.Click -= BtnMyProfile_Click;
                this.btnMyProfile.Click += BtnMyProfile_Click;
            }
            if (this.btnLogout != null)
            {
                this.btnLogout.Click -= BtnLogout_Click;
                this.btnLogout.Click += BtnLogout_Click;
            }
            if (this.btnAdminPanel != null)
            {
                this.btnAdminPanel.Visible = _mainForm.CurrentUser?.Role == "admin";
                if (this.btnAdminPanel.Visible)
                {
                    this.btnAdminPanel.Click -= BtnAdminPanel_Click;
                    this.btnAdminPanel.Click += BtnAdminPanel_Click;
                }
            }
        }

        public void LoadViewIntoContentPanel(UserControl viewToLoad)
        {
            if (this.panelContent == null) return;

            if (_currentContentPanelControl != null)
            {
                if (_currentContentPanelControl is UpcomingEventsView oldUpcomingView)
                {
                    oldUpcomingView.RequestEventDetailsView -= UpcomingEventsView_RequestEventDetailsView;
                }
                else if (_currentContentPanelControl is EventDetailsView oldDetailsView)
                {
                    oldDetailsView.RequestGoBack -= EventDetailsView_RequestGoBack;
                }

                this.panelContent.Controls.Remove(_currentContentPanelControl);
                _currentContentPanelControl.Dispose();
                _currentContentPanelControl = null;
            }

            this.lblContentWelcome.Visible = false;
            this.lblContentPlaceholder.Visible = false;

            if (viewToLoad != null)
            {
                _currentContentPanelControl = viewToLoad;

                if (_currentContentPanelControl is UpcomingEventsView newUpcomingView)
                {
                    newUpcomingView.RequestEventDetailsView += UpcomingEventsView_RequestEventDetailsView;
                }
                else if (_currentContentPanelControl is EventDetailsView newDetailsView)
                {
                    newDetailsView.RequestGoBack += EventDetailsView_RequestGoBack;
                }

                _currentContentPanelControl.Dock = DockStyle.Fill;
                this.panelContent.Controls.Add(_currentContentPanelControl);
            }
            else
            {
                this.lblContentWelcome.Visible = true;
                this.lblContentPlaceholder.Visible = true;
                this.lblContentPlaceholder.Text = "Wybierz opcję z menu po lewej stronie.";
            }
        }

        private void ShowWelcomeMessageInContentPanel()
        {
            LoadViewIntoContentPanel(null);
        }

        private void ShowUpcomingEventsView()
        {
            try
            {
                var upcomingEventsView = _serviceProvider.GetRequiredService<UpcomingEventsView>();
                LoadViewIntoContentPanel(upcomingEventsView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania widoku wydarzeń: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handler dla zdarzenia z UpcomingEventsView
        private async void UpcomingEventsView_RequestEventDetailsView(object sender, int eventId)
        {
            try
            {
                var eventDetailsView = new EventDetailsView(
                    _dbContext,
                    _mainForm
                );
                await eventDetailsView.LoadEventDetailsAsync(eventId);
                LoadViewIntoContentPanel(eventDetailsView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania szczegółów wydarzenia: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EventDetailsView_RequestGoBack(object sender, EventArgs e)
        {
            ShowUpcomingEventsView();
        }

        private void BtnUpcomingEvents_Click(object sender, EventArgs e)
        {
            ShowUpcomingEventsView();
        }

        private void BtnMyTickets_Click(object sender, EventArgs e)
        {
            try
            {
                var myTicketsView = _serviceProvider.GetRequiredService<MyTicketsView>();
                LoadViewIntoContentPanel(myTicketsView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania widoku 'Moje Bilety': {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMyProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var myProfileView = _serviceProvider.GetRequiredService<MyProfileView>();
                LoadViewIntoContentPanel(myProfileView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania widoku 'Mój Profil': {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdminPanel_Click(object sender, EventArgs e)
        {
            var placeholderView = new Label { Text = "Widok: Panel Administratora (do zaimplementowania)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 14F) };
            LoadViewIntoContentPanel(new UserControl { Controls = { placeholderView }, Dock = DockStyle.Fill });
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            _mainForm.UserLoggedOut();
        }
    }
}
