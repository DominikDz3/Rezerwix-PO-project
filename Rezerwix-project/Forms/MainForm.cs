using Microsoft.Extensions.DependencyInjection;
using Rezerwix.Data;
using Rezerwix.Models;

namespace Rezerwix_project.Forms
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _db;

        public MainForm(AppDbContext db)
        {
            InitializeComponent();
            _db = db;

            LoadView(new LoginView(_db, this));
        }

        public void LoadView(UserControl view)
        {
            panelView.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelView.Controls.Add(view);
        }
    }

}
