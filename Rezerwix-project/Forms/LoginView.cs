using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Rezerwix_project.Forms
{
    public partial class LoginView : UserControl
    {
        private readonly AppDbContext _db;
        private readonly MainForm _mainForm;
        private readonly IServiceProvider _serviceProvider;
        private Label _dynamicLblMessage;

        public LoginView(AppDbContext db, MainForm mainForm, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            ConfigureLoginControls();
        }

        private void ConfigureLoginControls()
        {
            if (this.txtPassword != null)
            {
                this.txtPassword.PasswordChar = '●';
            }

            if (this.btnLogin != null)
            {
                this.btnLogin.Click -= btnLogin_Click;
                this.btnLogin.Click += btnLogin_Click;
            }

            if (this.lblRegister != null)
            {
                this.lblRegister.Click -= lblRegister_Click;
                this.lblRegister.Click += lblRegister_Click;
            }

            if (this.lblMessage != null)
            {
                _dynamicLblMessage = this.lblMessage;
            }
            else
            {
                _dynamicLblMessage = this.Controls.Find("lblMessage", true).FirstOrDefault() as Label;
                if (_dynamicLblMessage == null)
                {
                    _dynamicLblMessage = new Label
                    {
                        Name = "lblMessageDynamic",
                        ForeColor = Color.Red,
                        Location = new Point(50, 200),
                        AutoSize = true,
                        Visible = false
                    };
                    this.Controls.Add(_dynamicLblMessage);
                }
            }
            _dynamicLblMessage.Visible = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (_dynamicLblMessage == null)
            {
                MessageBox.Show("Błąd wewnętrzny: Brak możliwości wyświetlenia komunikatu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _dynamicLblMessage.Visible = false;

            if (this.txtUsername == null || this.txtPassword == null)
            {
                _dynamicLblMessage.Text = "Błąd wewnętrzny: Pola formularza nie są dostępne.";
                _dynamicLblMessage.Visible = true;
                return;
            }

            var username = this.txtUsername.Text.Trim();
            var password = this.txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _dynamicLblMessage.Text = "Nazwa użytkownika i hasło są wymagane.";
                _dynamicLblMessage.Visible = true;
                return;
            }

            try
            {
                var user = await _db.Users.FirstOrDefaultAsync(u => u.Username == username);

                if (user != null && AppDbContext.PasswordHasher.VerifyPassword(password, user.PasswordHash, user.Salt))
                {
                    _mainForm.UserLoggedIn(user);
                }
                else
                {
                    _dynamicLblMessage.Text = "Nieprawidłowa nazwa użytkownika lub hasło.";
                    _dynamicLblMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                _dynamicLblMessage.Text = "Wystąpił błąd podczas logowania. Spróbuj ponownie.";
                _dynamicLblMessage.Visible = true;
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var registerView = _serviceProvider.GetRequiredService<RegisterView>();
                _mainForm.LoadView(registerView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie można załadować widoku rejestracji: {ex.Message}", "Błąd Nawigacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
