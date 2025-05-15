using Rezerwix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rezerwix_project.Forms
{
    public partial class RegisterView : UserControl
    {
        private readonly AppDbContext _db;
        private readonly MainForm _mainForm;
        public RegisterView(AppDbContext db, MainForm mainForm)
        {
            InitializeComponent();
            _db = db;
            _mainForm = mainForm;
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            _mainForm.LoadView(new LoginView(_db, _mainForm));
        }
    }
}
