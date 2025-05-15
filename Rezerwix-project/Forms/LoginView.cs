using Microsoft.Win32;
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
    public partial class LoginView : UserControl
    {
        private readonly AppDbContext _db;
        private readonly MainForm _mainForm;

        public LoginView(AppDbContext db, MainForm mainForm)
        {
            InitializeComponent();
            _db = db;
            _mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Autoryzacja z AuthService i _db
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            var user = _db.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && AppDbContext.PasswordHasher.VerifyPassword(password, user.PasswordHash, user.Salt))
            {
            }
            else
            {
                lblMessage.Text = "Nieprawidłowy login lub hasło.";
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            _mainForm.LoadView(new RegisterView(_db, _mainForm));
        }
    }

}
