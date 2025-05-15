using System;
using System.Drawing;
using System.Windows.Forms;
using Rezerwix_project.Forms;
using Rezerwix.Models;

namespace Rezerwix_project.Forms
{
    public partial class DashboardView : UserControl
    {
        private readonly MainForm _mainForm;

        public DashboardView(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            ConfigureDashboardControls();
        }

        private void ConfigureDashboardControls()
        {
            if (this.lblWelcome != null)
            {
                if (_mainForm.CurrentUser != null)
                {
                    this.lblWelcome.Text = $"Witaj, {_mainForm.CurrentUser.FirstName} {_mainForm.CurrentUser.LastName}!";
                }
                else
                {
                    this.lblWelcome.Text = "Witaj w Rezerwix!";
                }
            }

            if (this.btnLogoutDashboard != null)
            {
                this.btnLogoutDashboard.Click -= BtnLogoutDashboard_Click;
                this.btnLogoutDashboard.Click += BtnLogoutDashboard_Click;
            }

            if (this.lblPlaceholder != null)
            {
                this.lblPlaceholder.Text = "To jest Twój Dashboard. \nMożesz tu dodać listę wydarzeń, rezerwacji itp.";
            }

            this.BackColor = Color.FromArgb(240, 242, 245);
        }
        private void BtnLogoutDashboard_Click(object sender, EventArgs e)
        {
            _mainForm.UserLoggedOut();
        }
    }
}
