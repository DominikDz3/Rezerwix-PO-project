using Rezerwix.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Rezerwix_project.Forms
{
    public partial class DashboardView : UserControl
    {
        private readonly MainForm _mainForm;
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly IServiceProvider _serviceProvider;
        private UserControl _currentContentPanelControl = null;

        public DashboardView(MainForm mainForm, IDbContextFactory<AppDbContext> dbContextFactory, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            ConfigureDashboardControls();

            if (!this.DesignMode)
            {
                if (_mainForm.CurrentUser?.Role == "admin")
                {
                    BtnAddEditEvent_Admin_Click(this, EventArgs.Empty);
                }
                else
                {
                    ShowUpcomingEventsView();
                }
            }
        }

        private void ConfigureDashboardControls()
        {
            bool isAdmin = _mainForm.CurrentUser?.Role == "admin";

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

            if (btnUpcomingEvents != null)
            {
                btnUpcomingEvents.Visible = !isAdmin;
                btnUpcomingEvents.Click -= BtnUpcomingEvents_Click;
                if (!isAdmin) btnUpcomingEvents.Click += BtnUpcomingEvents_Click;
            }
            if (btnMyTickets != null)
            {
                btnMyTickets.Visible = !isAdmin;
                btnMyTickets.Click -= BtnMyTickets_Click;
                if (!isAdmin) btnMyTickets.Click += BtnMyTickets_Click;
            }
            if (btnMyProfile != null)
            {
                btnMyProfile.Visible = !isAdmin;
                btnMyProfile.Click -= BtnMyProfile_Click;
                if (!isAdmin) btnMyProfile.Click += BtnMyProfile_Click;
            }

            if (btnManageUsers_Admin != null)
            {
                btnManageUsers_Admin.Visible = isAdmin;
                btnManageUsers_Admin.Click -= BtnManageUsers_Admin_Click;
                if (isAdmin) btnManageUsers_Admin.Click += BtnManageUsers_Admin_Click;
            }

            if (btnAddEditEvent_Admin != null)
            {
                btnAddEditEvent_Admin.Visible = isAdmin;
                btnAddEditEvent_Admin.Click -= BtnAddEditEvent_Admin_Click;
                if (isAdmin) btnAddEditEvent_Admin.Click += BtnAddEditEvent_Admin_Click;
            }

            if (btnLogout != null)
            {
                btnLogout.Click -= BtnLogout_Click;
                btnLogout.Click += BtnLogout_Click;
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

        private async void UpcomingEventsView_RequestEventDetailsView(object sender, int eventId)
        {
            try
            {
                var eventDetailsView = _serviceProvider.GetRequiredService<EventDetailsView>();
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
            if (_mainForm.CurrentUser?.Role == "admin")
            {
                BtnAddEditEvent_Admin_Click(sender, e);
            }
            else
            {
                ShowUpcomingEventsView();
            }
        }

        private void BtnUpcomingEvents_Click(object sender, EventArgs e) { ShowUpcomingEventsView(); }
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

        private void BtnManageUsers_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                var manageUsersView = _serviceProvider.GetRequiredService<ManageUsersView>();
                LoadViewIntoContentPanel(manageUsersView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania widoku zarządzania użytkownikami: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddEditEvent_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                var manageEventsView = _serviceProvider.GetRequiredService<ManageEventsView>();
                LoadViewIntoContentPanel(manageEventsView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania widoku zarządzania wydarzeniami: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            _mainForm.UserLoggedOut();
        }
    }
}
