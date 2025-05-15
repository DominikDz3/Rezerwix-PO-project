using Rezerwix.Models;
using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace Rezerwix_project.Forms
{
    public partial class MainForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public User CurrentUser { get; private set; }

        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLoginView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst�pi� krytyczny b��d podczas �adowania widoku logowania: {ex.Message}", "B��d Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel GetPanelView()
        {
            var panel = this.Controls.Find("panelView", true).FirstOrDefault() as Panel;
            if (panel == null)
            {
                throw new InvalidOperationException("Panel 'panelView' not found in MainForm's controls. Ensure it is correctly defined in MainForm.Designer.cs and added to Controls.");
            }
            return panel;
        }

        private void LoadLoginView()
        {
            var panel = GetPanelView();
            if (panel.Controls.Count > 0 && panel.Controls[0] is UserControl currentView)
            {
                panel.Controls.Remove(currentView);
                currentView.Dispose();
            }
            var loginView = _serviceProvider.GetRequiredService<LoginView>();
            loginView.Dock = DockStyle.Fill;
            panel.Controls.Add(loginView);
        }

        public void UserLoggedIn(User user)
        {
            CurrentUser = user;
            if (CurrentUser != null)
            {
                try
                {
                    var panel = GetPanelView();
                    var loginViewControl = panel.Controls.OfType<LoginView>().FirstOrDefault();
                    if (loginViewControl != null)
                    {
                        panel.Controls.Remove(loginViewControl);
                        loginViewControl.Dispose();
                    }
                    ShowMainApplicationView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wyst�pi� b��d po zalogowaniu: {ex.Message}", "B��d Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try { LoadLoginView(); } catch { }
                }
            }
        }

        public void UserLoggedOut()
        {
            CurrentUser = null;
            MessageBox.Show("Wylogowano pomy�lnie.", "Wylogowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                var panel = GetPanelView();
                if (panel.Controls.Count > 0)
                {
                    var currentControl = panel.Controls[0];
                    panel.Controls.Remove(currentControl);
                    currentControl.Dispose();
                }
                LoadLoginView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst�pi� b��d podczas wylogowywania: {ex.Message}", "B��d Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadView(UserControl view)
        {
            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }
            try
            {
                var panel = GetPanelView();
                panel.Controls.Clear();
                view.Dock = DockStyle.Fill;
                panel.Controls.Add(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst�pi� b��d podczas �adowania widoku '{view.Name}': {ex.Message}", "B��d Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowMainApplicationView()
        {
            try
            {
                var dashboardView = _serviceProvider.GetRequiredService<DashboardView>();
                if (dashboardView != null)
                {
                    LoadView(dashboardView);
                }
                else
                {
                    MessageBox.Show("Nie uda�o si� utworzy� g��wnego widoku aplikacji (DashboardView is null).", "B��d Krytyczny Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadLoginView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie uda�o si� za�adowa� g��wnego widoku aplikacji (Dashboard): {ex.Message}\n\nSzczeg�y: {ex.ToString()}", "B��d Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    LoadLoginView();
                }
                catch (Exception fallbackEx)
                {
                    MessageBox.Show($"Krytyczny b��d podczas pr�by powrotu do ekranu logowania: {fallbackEx.Message}", "Podw�jny B��d Aplikacji", MessageBoxButtons.OK);
                }
            }
        }
    }
}
