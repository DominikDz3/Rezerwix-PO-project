using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Rezerwix.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace Rezerwix_project.Forms
{
    public partial class RegisterView : UserControl
    {
        private readonly AppDbContext _db;
        private readonly MainForm _mainForm;
        private readonly IServiceProvider _serviceProvider;
        private Label _dynamicLblRegisterMessage;

        public RegisterView(AppDbContext db, MainForm mainForm, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            ConfigureRegisterControls();
        }

        private void ConfigureRegisterControls()
        {
            if (this.txtPassword != null)
            {
                this.txtPassword.PasswordChar = '●';
            }

            if (this.txtConfirmPassword != null)
            {
                this.txtConfirmPassword.PasswordChar = '●';
            }

            if (this.btnRegister != null)
            {
                this.btnRegister.Click -= btnRegister_Click;
                this.btnRegister.Click += btnRegister_Click;
            }


            _dynamicLblRegisterMessage = this.Controls.Find("lblRegisterMessage", true).FirstOrDefault() as Label;
            if (_dynamicLblRegisterMessage == null)
            {
                _dynamicLblRegisterMessage = new Label
                {
                    Name = "lblRegisterMessageDynamic",
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Visible = false,
                    Location = new Point(50, 440) // Dostosuj pozycję, jeśli potrzebne
                };
                this.Controls.Add(_dynamicLblRegisterMessage);
            }
            _dynamicLblRegisterMessage.Visible = false;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (this._dynamicLblRegisterMessage == null)
            {
                MessageBox.Show("Błąd wewnętrzny: Brak kontrolki do wyświetlania komunikatów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this._dynamicLblRegisterMessage.Visible = false;
            this._dynamicLblRegisterMessage.Text = "";

            if (this.txtUsername == null || this.txtEmail == null || this.txtPassword == null ||
                this.txtConfirmPassword == null || this.txtFirstName == null || this.txtLastName == null ||
                this.datePickerBirthDate == null)
            {
                this._dynamicLblRegisterMessage.Text = "Błąd inicjalizacji kontrolek formularza.";
                this._dynamicLblRegisterMessage.Visible = true;
                return;
            }

            var username = this.txtUsername.Text.Trim();
            var email = this.txtEmail.Text.Trim();
            var password = this.txtPassword.Text;
            var confirmPassword = this.txtConfirmPassword.Text;
            var firstName = this.txtFirstName.Text.Trim();
            var lastName = this.txtLastName.Text.Trim();
            var dateOfBirth = this.datePickerBirthDate.Value;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                this._dynamicLblRegisterMessage.Text = "Wszystkie pola są wymagane.";
                this._dynamicLblRegisterMessage.Visible = true;
                return;
            }

            if (password != confirmPassword)
            {
                this._dynamicLblRegisterMessage.Text = "Hasła nie są zgodne.";
                this._dynamicLblRegisterMessage.Visible = true;
                return;
            }
            if (password.Length < 6)
            {
                this._dynamicLblRegisterMessage.Text = "Hasło musi mieć co najmniej 6 znaków.";
                this._dynamicLblRegisterMessage.Visible = true;
                return;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email.Trim())
                {
                    throw new FormatException("Adres email nie jest identyczny po normalizacji.");
                }
            }
            catch (FormatException)
            {
                this._dynamicLblRegisterMessage.Text = "Niepoprawny format adresu email.";
                this._dynamicLblRegisterMessage.Visible = true;
                return;
            }

            try
            {
                bool userExists = await _db.Users.AnyAsync(u => u.Username == username);
                if (userExists)
                {
                    this._dynamicLblRegisterMessage.Text = "Użytkownik o tej nazwie już istnieje.";
                    this._dynamicLblRegisterMessage.Visible = true;
                    return;
                }
                bool emailExists = await _db.Users.AnyAsync(u => u.Email == email);
                if (emailExists)
                {
                    this._dynamicLblRegisterMessage.Text = "Adres email jest już używany.";
                    this._dynamicLblRegisterMessage.Visible = true;
                    return;
                }

                var (hashedPassword, salt) = AppDbContext.PasswordHasher.HashPassword(password);
                var newUser = new User
                {
                    Username = username,
                    Email = email,
                    PasswordHash = hashedPassword,
                    Salt = salt,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = DateTime.SpecifyKind(dateOfBirth, DateTimeKind.Utc),
                    Role = "user"
                };

                var validationContext = new ValidationContext(newUser);
                var validationResults = new System.Collections.Generic.List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(newUser, validationContext, validationResults, true);

                if (!isValid)
                {
                    this._dynamicLblRegisterMessage.Text = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                    this._dynamicLblRegisterMessage.Visible = true;
                    return;
                }

                _db.Users.Add(newUser);
                await _db.SaveChangesAsync();

                MessageBox.Show("Rejestracja zakończona pomyślnie! Możesz się teraz zalogować.", "Rejestracja udana", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var loginView = _serviceProvider.GetRequiredService<LoginView>();
                _mainForm.LoadView(loginView);
            }
            catch (DbUpdateException dbEx)
            {
                this._dynamicLblRegisterMessage.Text = $"Błąd zapisu do bazy danych: {dbEx.InnerException?.Message ?? dbEx.Message}";
                this._dynamicLblRegisterMessage.Visible = true;
            }
            catch (Exception ex)
            {
                this._dynamicLblRegisterMessage.Text = "Wystąpił nieoczekiwany błąd podczas rejestracji.";
                this._dynamicLblRegisterMessage.Visible = true;
            }
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            try
            {
                var loginView = _serviceProvider.GetRequiredService<LoginView>();
                _mainForm.LoadView(loginView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie można załadować widoku logowania: {ex.Message}", "Błąd Nawigacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
