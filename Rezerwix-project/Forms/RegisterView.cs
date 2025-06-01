// RegisterView.cs
using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Rezerwix.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rezerwix_project.Forms
{
    public partial class RegisterView : UserControl
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly MainForm _mainForm;
        private readonly IServiceProvider _serviceProvider;
        // Usunięto _dynamicLblRegisterMessage, zakładamy, że lblRegisterMessage jest w Designer.cs

        public RegisterView(IDbContextFactory<AppDbContext> dbContextFactory, MainForm mainForm, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            ConfigureRegisterControls();
        }

        private void ConfigureRegisterControls()
        {
            if (this.txtPassword != null) this.txtPassword.PasswordChar = '●';
            if (this.txtConfirmPassword != null) this.txtConfirmPassword.PasswordChar = '●';
            if (this.btnRegister != null)
            {
                this.btnRegister.Click -= btnRegister_Click;
                this.btnRegister.Click += btnRegister_Click;
            }
            if (this.lblLoginLink != null)
            {
                this.lblLoginLink.Click -= lblLoginLink_Click;
                this.lblLoginLink.Click += lblLoginLink_Click;
            }
            if (this.lblRegisterMessage != null) this.lblRegisterMessage.Visible = false;

            // Upewnij się, że wszystkie etykiety błędów są początkowo niewidoczne
            ClearErrorMessages();
        }

        private void ClearErrorMessages()
        {
            // Ukryj indywidualne etykiety błędów
            if (lblUsernameError != null) { lblUsernameError.Text = ""; lblUsernameError.Visible = false; }
            if (lblPasswordError != null) { lblPasswordError.Text = ""; lblPasswordError.Visible = false; }
            if (lblConfirmPasswordError != null) { lblConfirmPasswordError.Text = ""; lblConfirmPasswordError.Visible = false; }
            if (lblEmailError != null) { lblEmailError.Text = ""; lblEmailError.Visible = false; }
            if (lblFirstNameError != null) { lblFirstNameError.Text = ""; lblFirstNameError.Visible = false; }
            if (lblLastNameError != null) { lblLastNameError.Text = ""; lblLastNameError.Visible = false; }
            if (lblBirthDateError != null) { lblBirthDateError.Text = ""; lblBirthDateError.Visible = false; }
            // Ukryj ogólną etykietę błędu
            if (lblRegisterMessage != null) { lblRegisterMessage.Text = ""; lblRegisterMessage.Visible = false; }
        }

        private void ShowFieldError(Label errorLabel, string message)
        {
            if (errorLabel != null)
            {
                errorLabel.Text = message;
                errorLabel.Visible = true;
            }
        }
        
        private void ShowGeneralMessage(string message, bool isSuccess)
        {
            if (lblRegisterMessage != null)
            {
                lblRegisterMessage.Text = message;
                lblRegisterMessage.ForeColor = isSuccess ? Color.Green : Color.Tomato;
                lblRegisterMessage.Visible = true;
            }
            else
            {
                // Fallback, jeśli lblRegisterMessage nie istnieje
                MessageBox.Show(message, isSuccess ? "Sukces" : "Błąd", MessageBoxButtons.OK, isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
        }


        private async void btnRegister_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();
            bool isValidForm = true;

            var username = this.txtUsername.Text.Trim();
            var email = this.txtEmail.Text.Trim();
            var password = this.txtPassword.Text;
            var confirmPassword = this.txtConfirmPassword.Text;
            var firstName = this.txtFirstName.Text.Trim();
            var lastName = this.txtLastName.Text.Trim();
            var dateOfBirth = this.datePickerBirthDate.Value;

            if (string.IsNullOrWhiteSpace(username)) { ShowFieldError(lblUsernameError, "Nazwa użytkownika jest wymagana."); isValidForm = false; }
            else if (username.Length < 3) { ShowFieldError(lblUsernameError, "Nazwa użytkownika musi mieć co najmniej 3 znaki."); isValidForm = false; }


            if (string.IsNullOrWhiteSpace(email)) { ShowFieldError(lblEmailError, "Email jest wymagany."); isValidForm = false; }
            else 
            {
                try { var addr = new System.Net.Mail.MailAddress(email); if (addr.Address != email.Trim()) throw new FormatException(); }
                catch (FormatException) { ShowFieldError(lblEmailError, "Niepoprawny format email."); isValidForm = false; }
            }

            if (string.IsNullOrWhiteSpace(password)) { ShowFieldError(lblPasswordError, "Hasło jest wymagane."); isValidForm = false; }
            else if (password.Length < 6) { ShowFieldError(lblPasswordError, "Hasło musi mieć co najmniej 6 znaków."); isValidForm = false; }
            
            if (string.IsNullOrWhiteSpace(confirmPassword)) { ShowFieldError(lblConfirmPasswordError, "Potwierdzenie hasła jest wymagane."); isValidForm = false; }
            else if (password != confirmPassword) { ShowFieldError(lblConfirmPasswordError, "Hasła nie są zgodne."); isValidForm = false; }
            
            if (string.IsNullOrWhiteSpace(firstName)) { ShowFieldError(lblFirstNameError, "Imię jest wymagane."); isValidForm = false; }
            if (string.IsNullOrWhiteSpace(lastName)) { ShowFieldError(lblLastNameError, "Nazwisko jest wymagane."); isValidForm = false; }
            
            if (dateOfBirth > DateTime.Now.AddYears(-18)) { ShowFieldError(lblBirthDateError, "Musisz mieć ukończone 18 lat."); isValidForm = false; }
            else if (dateOfBirth < new DateTime(1900,1,1)) { ShowFieldError(lblBirthDateError, "Niepoprawna data urodzenia."); isValidForm = false; }


            if (!isValidForm) return;

            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    if (await dbContext.Users.AnyAsync(u => u.Username == username))
                    {
                        ShowFieldError(lblUsernameError, "Ta nazwa użytkownika jest już zajęta.");
                        return;
                    }
                    if (await dbContext.Users.AnyAsync(u => u.Email == email))
                    {
                        ShowFieldError(lblEmailError, "Ten adres email jest już używany.");
                        return;
                    }

                    var (hashedPassword, salt) = AppDbContext.PasswordHasher.HashPassword(password);
                    var newUser = new User
                    {
                        Username = username, Email = email, PasswordHash = hashedPassword, Salt = salt,
                        FirstName = firstName, LastName = lastName,
                        DateOfBirth = DateTime.SpecifyKind(dateOfBirth.Date, DateTimeKind.Utc), Role = "user" // Użyj .Date aby zapisać tylko datę
                    };

                    var validationContext = new ValidationContext(newUser);
                    var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                    bool isModelValid = Validator.TryValidateObject(newUser, validationContext, validationResults, true);

                    if (!isModelValid)
                    {
                        // Spróbuj przypisać błędy modelu do konkretnych pól, jeśli to możliwe
                        // lub pokaż jako ogólny błąd
                        foreach(var validationResult in validationResults)
                        {
                            if (validationResult.MemberNames.Contains(nameof(User.Username))) ShowFieldError(lblUsernameError, validationResult.ErrorMessage);
                            else if (validationResult.MemberNames.Contains(nameof(User.Email))) ShowFieldError(lblEmailError, validationResult.ErrorMessage);
                            else if (validationResult.MemberNames.Contains(nameof(User.PasswordHash))) ShowFieldError(lblPasswordError, validationResult.ErrorMessage); // PasswordHash jest wewnętrzny, ale błąd może dotyczyć hasła
                            else if (validationResult.MemberNames.Contains(nameof(User.FirstName))) ShowFieldError(lblFirstNameError, validationResult.ErrorMessage);
                            else if (validationResult.MemberNames.Contains(nameof(User.LastName))) ShowFieldError(lblLastNameError, validationResult.ErrorMessage);
                            else if (validationResult.MemberNames.Contains(nameof(User.DateOfBirth))) ShowFieldError(lblBirthDateError, validationResult.ErrorMessage);
                            else ShowGeneralMessage(validationResult.ErrorMessage, false); // Ogólny błąd modelu
                        }
                        return;
                    }

                    dbContext.Users.Add(newUser);
                    await dbContext.SaveChangesAsync();
                }

                MessageBox.Show("Rejestracja zakończona pomyślnie! Możesz się teraz zalogować.", "Rejestracja udana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                var loginView = _serviceProvider.GetRequiredService<LoginView>();
                _mainForm.LoadView(loginView);
            }
            catch (DbUpdateException dbEx)
            {
                ShowGeneralMessage($"Błąd zapisu do bazy danych: {dbEx.InnerException?.Message ?? dbEx.Message}", false);
            }
            catch (Exception ex)
            {
                ShowGeneralMessage("Wystąpił nieoczekiwany błąd podczas rejestracji.", false);
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
