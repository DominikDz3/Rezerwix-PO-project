using Rezerwix.Data;
using Rezerwix.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Rezerwix_project.Forms
{
    public partial class MyProfileView : UserControl
    {
        private readonly AppDbContext _dbContext;
        private readonly MainForm _mainForm;
        private User _currentUserData;

        public MyProfileView(AppDbContext dbContext, MainForm mainForm)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            if (!this.DesignMode)
            {
                LoadUserProfile();
            }

            if (btnSaveChanges != null) btnSaveChanges.Click += BtnSaveChanges_Click;
            if (btnChangePassword != null) btnChangePassword.Click += BtnChangePassword_Click;
        }

        private void LoadUserProfile()
        {
            if (_mainForm.CurrentUser == null)
            {
                MessageBox.Show("Błąd: Brak zalogowanego użytkownika.", "Błąd profilu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentUserData = _dbContext.Users.Find(_mainForm.CurrentUser.UserId);

            if (_currentUserData == null)
            {
                MessageBox.Show("Błąd: Nie można załadować danych użytkownika.", "Błąd profilu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername != null) txtUsername.Text = _currentUserData.Username;
            if (txtFirstName != null) txtFirstName.Text = _currentUserData.FirstName;
            if (txtLastName != null) txtLastName.Text = _currentUserData.LastName;
            if (txtEmail != null) txtEmail.Text = _currentUserData.Email;
            if (dtpDateOfBirth != null) dtpDateOfBirth.Value = _currentUserData.DateOfBirth.ToLocalTime(); // Pamiętaj o konwersji z UTC jeśli tak przechowujesz
        }

        private async void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_currentUserData == null) return;

            _currentUserData.FirstName = txtFirstName.Text.Trim();
            _currentUserData.LastName = txtLastName.Text.Trim();
            _currentUserData.Email = txtEmail.Text.Trim();
            _currentUserData.DateOfBirth = DateTime.SpecifyKind(dtpDateOfBirth.Value, DateTimeKind.Utc);

            var validationContext = new ValidationContext(_currentUserData);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_currentUserData, validationContext, validationResults, true);

            if (!isValid)
            {
                string errors = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                ShowMessage(errors, false);
                return;
            }

            if (_dbContext.Users.Any(u => u.Email == _currentUserData.Email && u.UserId != _currentUserData.UserId))
            {
                ShowMessage("Ten adres email jest już używany przez innego użytkownika.", false);
                return;
            }

            try
            {
                _dbContext.Users.Update(_currentUserData);
                await _dbContext.SaveChangesAsync();
                _mainForm.CurrentUser.FirstName = _currentUserData.FirstName;
                _mainForm.CurrentUser.LastName = _currentUserData.LastName;
                _mainForm.CurrentUser.Email = _currentUserData.Email;
                _mainForm.CurrentUser.DateOfBirth = _currentUserData.DateOfBirth;

                ShowMessage("Dane zostały pomyślnie zaktualizowane.", true);
            }
            catch (DbUpdateConcurrencyException)
            {
                ShowMessage("Wystąpił konflikt współbieżności. Spróbuj ponownie.", false);
                LoadUserProfile();
            }
            catch (Exception ex)
            {
                ShowMessage($"Wystąpił błąd podczas zapisywania zmian: {ex.Message}", false);
            }
        }

        private async void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (_currentUserData == null) return;

            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                ShowMessage("Wszystkie pola hasła są wymagane.", false);
                return;
            }

            if (!AppDbContext.PasswordHasher.VerifyPassword(currentPassword, _currentUserData.PasswordHash, _currentUserData.Salt))
            {
                ShowMessage("Aktualne hasło jest nieprawidłowe.", false);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                ShowMessage("Nowe hasła nie są zgodne.", false);
                return;
            }

            if (newPassword.Length < 6)
            {
                ShowMessage("Nowe hasło musi mieć co najmniej 6 znaków.", false);
                return;
            }

            try
            {
                var (newHash, newSalt) = AppDbContext.PasswordHasher.HashPassword(newPassword);
                _currentUserData.PasswordHash = newHash;
                _currentUserData.Salt = newSalt;

                _dbContext.Users.Update(_currentUserData);
                await _dbContext.SaveChangesAsync();

                ShowMessage("Hasło zostało pomyślnie zmienione.", true);
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmNewPassword.Clear();
            }
            catch (Exception ex)
            {
                ShowMessage($"Wystąpił błąd podczas zmiany hasła: {ex.Message}", false);
            }
        }

        private void ShowMessage(string message, bool isSuccess)
        {
            if (lblProfileMessage == null) return;
            lblProfileMessage.Text = message;
            lblProfileMessage.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblProfileMessage.Visible = true;

            var timer = new System.Windows.Forms.Timer { Interval = 5000 };
            timer.Tick += (s, e) =>
            {
                lblProfileMessage.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}
