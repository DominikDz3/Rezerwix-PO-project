using Rezerwix.Data;
using Microsoft.EntityFrameworkCore;

namespace Rezerwix_project.Forms
{
    public partial class ManageUsersView : UserControl
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly IServiceProvider _serviceProvider;
        private readonly MainForm _mainForm;

        public ManageUsersView(IDbContextFactory<AppDbContext> dbContextFactory, IServiceProvider serviceProvider, MainForm mainForm) // Dodano MainForm do konstruktora
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            if (!this.DesignMode)
            {
                SetupDataGridView();
                LoadUsersAsync();
            }

            if (btnEditUserRole != null) btnEditUserRole.Click += BtnEditUserRole_Click;
            if (btnDeleteUser != null) btnDeleteUser.Click += BtnDeleteUser_Click;
        }

        private void SetupDataGridView()
        {
            if (dgvUsers == null) return;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.BackgroundColor = Color.WhiteSmoke;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 48);
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.GridColor = Color.FromArgb(200, 200, 200);

            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "UserIdCol", HeaderText = "ID", DataPropertyName = "UserId", Width = 50 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "UsernameCol", HeaderText = "Nazwa użytkownika", DataPropertyName = "Username", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "FirstNameCol", HeaderText = "Imię", DataPropertyName = "FirstName", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "LastNameCol", HeaderText = "Nazwisko", DataPropertyName = "LastName", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "EmailCol", HeaderText = "Email", DataPropertyName = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 30 });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "RoleCol", HeaderText = "Rola", DataPropertyName = "Role", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "DateOfBirthCol", HeaderText = "Data urodzenia", DataPropertyName = "DateOfBirth", DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
        }

        private async Task LoadUsersAsync()
        {
            if (dgvUsers == null) return;
            try
            {
                using (var dbContext = _dbContextFactory.CreateDbContext())
                {
                    var users = await dbContext.Users
                                        .AsNoTracking()
                                        .OrderBy(u => u.LastName).ThenBy(u => u.FirstName)
                                        .Select(u => new
                                        {
                                            u.UserId,
                                            u.Username,
                                            u.FirstName,
                                            u.LastName,
                                            u.Email,
                                            u.Role,
                                            u.DateOfBirth
                                        })
                                        .ToListAsync();
                    dgvUsers.DataSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania użytkowników: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnEditUserRole_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć użytkownika do edycji roli.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedUserId = (int)dgvUsers.SelectedRows[0].Cells["UserIdCol"].Value;
            var currentRole = dgvUsers.SelectedRows[0].Cells["RoleCol"].Value?.ToString();
            var username = dgvUsers.SelectedRows[0].Cells["UsernameCol"].Value?.ToString();

            if (_mainForm.CurrentUser != null && _mainForm.CurrentUser.UserId == selectedUserId && _mainForm.CurrentUser.Role == "admin")
            {
                MessageBox.Show("Nie możesz zmienić roli własnego konta administratora.", "Operacja niedozwolona", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var roleDialog = new Form())
            {
                roleDialog.Text = $"Zmień rolę dla {username}";
                roleDialog.StartPosition = FormStartPosition.CenterParent;
                roleDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                roleDialog.ClientSize = new Size(300, 120);
                roleDialog.MaximizeBox = false;
                roleDialog.MinimizeBox = false;


                Label lbl = new Label() { Left = 20, Top = 20, Text = "Nowa rola:", AutoSize = true };
                ComboBox cmbRoles = new ComboBox() { Left = 20, Top = 45, Width = 260, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbRoles.Items.AddRange(new string[] { "user", "admin" });
                cmbRoles.SelectedItem = currentRole ?? "user";

                Button confirmation = new Button() { Text = "Zapisz", Left = 120, Width = 80, Top = 80, DialogResult = DialogResult.OK };
                Button cancel = new Button() { Text = "Anuluj", Left = 210, Width = 70, Top = 80, DialogResult = DialogResult.Cancel };

                confirmation.Click += async (s, ev) =>
                {
                    if (cmbRoles.SelectedItem == null) return;
                    string newRole = cmbRoles.SelectedItem.ToString();
                    if (newRole == currentRole)
                    {
                        roleDialog.DialogResult = DialogResult.Cancel;
                        return;
                    }

                    try
                    {
                        using (var dbContext = _dbContextFactory.CreateDbContext())
                        {
                            var userToUpdate = await dbContext.Users.FindAsync(selectedUserId);
                            if (userToUpdate != null)
                            {
                                userToUpdate.Role = newRole;
                                await dbContext.SaveChangesAsync();
                                MessageBox.Show($"Rola użytkownika {username} została zmieniona na {newRole}.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                roleDialog.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                roleDialog.DialogResult = DialogResult.Abort;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas zmiany roli: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        roleDialog.DialogResult = DialogResult.Abort;
                    }
                };

                roleDialog.Controls.Add(lbl);
                roleDialog.Controls.Add(cmbRoles);
                roleDialog.Controls.Add(confirmation);
                roleDialog.Controls.Add(cancel);
                roleDialog.AcceptButton = confirmation;
                roleDialog.CancelButton = cancel;

                if (roleDialog.ShowDialog(this) == DialogResult.OK)
                {
                    await LoadUsersAsync();
                }
            }
        }

        private async void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć użytkownika do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedUserId = (int)dgvUsers.SelectedRows[0].Cells["UserIdCol"].Value;
            var selectedUsername = dgvUsers.SelectedRows[0].Cells["UsernameCol"].Value?.ToString() ?? "Nieznany użytkownik";

            if (_mainForm.CurrentUser != null && _mainForm.CurrentUser.UserId == selectedUserId)
            {
                MessageBox.Show("Nie możesz usunąć własnego konta.", "Operacja niedozwolona", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"Czy na pewno chcesz usunąć użytkownika: '{selectedUsername}' (ID: {selectedUserId})?\nSpowoduje to również usunięcie wszystkich jego rezerwacji.",
                                               "Potwierdź usunięcie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var dbContext = _dbContextFactory.CreateDbContext())
                    {
                        var userToDelete = await dbContext.Users.FindAsync(selectedUserId);
                        if (userToDelete != null)
                        {
                            dbContext.Users.Remove(userToDelete);
                            await dbContext.SaveChangesAsync();
                            await LoadUsersAsync();
                            MessageBox.Show("Użytkownik został usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono użytkownika do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas usuwania użytkownika: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
