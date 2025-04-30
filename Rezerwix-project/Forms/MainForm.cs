using Microsoft.Extensions.DependencyInjection;
using Rezerwix.Data;
using Rezerwix.Models;

namespace Rezerwix_project
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _dbContext;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var user = new User { Username = "Nowy U¿ytkownik" };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            MessageBox.Show("Dodano u¿ytkownika!");
        }
    }
}
