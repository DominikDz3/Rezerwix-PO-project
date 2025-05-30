using Rezerwix.Data;
using Rezerwix.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Rezerwix_project.Forms
{
    public partial class MyProfileView : UserControl
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly MainForm _mainForm;
        private User _currentUserData;

        public MyProfileView(IDbContextFactory<AppDbContext> dbContextFactory, MainForm mainForm)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            if (!this.DesignMode)
            {
                _ = LoadUserProfileAsync();
            }

            if (btnSaveChanges != null) btnSaveChanges.Click += BtnSaveChanges_Click;
            if (btnChangePassword != null) btnChangePassword.Click += BtnChangePassword_Click;
        }
        private async Task LoadUserProfileAsync()
        {
            if (_mainForm.CurrentUser == null)
            {
                MessageBox.Show("Błąd: Brak zalogowanego użytkownika.", "Błąd profilu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    _currentUserData = await dbContext.Users.FindAsync(_mainForm.CurrentUser.UserId);
                }

                if (_currentUserData == null)
                {
                    MessageBox.Show("Błąd: Nie można załadować danych użytkownika.", "Błąd profilu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtUsername != null) txtUsername.Text = _currentUserData.Username;
                if (txtFirstName != null) txtFirstName.Text = _currentUserData.FirstName;
                if (txtLastName != null) txtLastName.Text = _currentUserData.LastName;
                if (txtEmail != null) txtEmail.Text = _currentUserData.Email;
                if (dtpDateOfBirth != null && _currentUserData.DateOfBirth.Year > dtpDateOfBirth.MinDate.Year && _currentUserData.DateOfBirth < dtpDateOfBirth.MaxDate)
                {
                    dtpDateOfBirth.Value = _currentUserData.DateOfBirth.ToLocalTime();
                }
                else if (dtpDateOfBirth != null)
                {
                    dtpDateOfBirth.Value = new DateTime(Math.Max(dtpDateOfBirth.MinDate.Year, Math.Min(DateTime.Now.Year - 18, dtpDateOfBirth.MaxDate.Year - 1)), DateTime.Now.Month, DateTime.Now.Day);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania profilu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    if (await dbContext.Users.AnyAsync(u => u.Email == _currentUserData.Email && u.UserId != _currentUserData.UserId))
                    {
                        ShowMessage("Ten adres email jest już używany przez innego użytkownika.", false);
                        return;
                    }

                    dbContext.Users.Update(_currentUserData);
                    await dbContext.SaveChangesAsync();
                }

                var userInMainForm = _mainForm.CurrentUser;
                if (userInMainForm != null && userInMainForm.UserId == _currentUserData.UserId)
                {
                    userInMainForm.FirstName = _currentUserData.FirstName;
                    userInMainForm.LastName = _currentUserData.LastName;
                    userInMainForm.Email = _currentUserData.Email;
                    userInMainForm.DateOfBirth = _currentUserData.DateOfBirth;
                }

                ShowMessage("Dane zostały pomyślnie zaktualizowane.", true);
            }
            catch (DbUpdateConcurrencyException)
            {
                ShowMessage("Wystąpił konflikt współbieżności. Spróbuj ponownie.", false);
                await LoadUserProfileAsync();
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
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    var (newHash, newSalt) = AppDbContext.PasswordHasher.HashPassword(newPassword);

                    var userToUpdate = await dbContext.Users.FindAsync(_currentUserData.UserId);
                    if (userToUpdate != null)
                    {
                        userToUpdate.PasswordHash = newHash;
                        userToUpdate.Salt = newSalt;
                        _currentUserData.PasswordHash = newHash;
                        _currentUserData.Salt = newSalt;

                        dbContext.Users.Update(userToUpdate);
                        await dbContext.SaveChangesAsync();

                        ShowMessage("Hasło zostało pomyślnie zmienione.", true);
                        txtCurrentPassword.Clear();
                        txtNewPassword.Clear();
                        txtConfirmNewPassword.Clear();
                    }
                    else
                    {
                        ShowMessage("Nie znaleziono użytkownika do aktualizacji hasła.", false);
                    }
                }
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
                if (lblProfileMessage != null && !lblProfileMessage.IsDisposed && lblProfileMessage.IsHandleCreated)
                {
                    lblProfileMessage.Visible = false;
                }
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}
