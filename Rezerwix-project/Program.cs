// Program.cs
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Rezerwix_project.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Rezerwix
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                var host = CreateHostBuilder().Build();

                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    try
                    {
                        var contextFactory = services.GetRequiredService<IDbContextFactory<AppDbContext>>();
                        using (var context = contextFactory.CreateDbContext())
                        {
                            context.Database.Migrate();
                            context.SeedData();
                        }
                    }
                    catch (Exception exDb)
                    {
                        MessageBox.Show($"Wyst�pi� b��d podczas inicjalizacji bazy danych: {exDb.Message}", "B��d Bazy Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var mainForm = host.Services.GetRequiredService<MainForm>();
                if (mainForm == null)
                {
                    MessageBox.Show("Krytyczny b��d: Nie uda�o si� utworzy� g��wnego okna aplikacji.", "B��d Krytyczny Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Application.Run(mainForm);
            }
            catch (Exception exGlobal)
            {
                MessageBox.Show($"Nieoczekiwany b��d krytyczny podczas uruchamiania aplikacji: {exGlobal.Message}", "B��d Krytyczny Aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContextFactory<AppDbContext>((serviceProvider, options) =>
                    {
                        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                        var connectionString = configuration.GetConnectionString("DefaultConnection");

                        options.UseNpgsql(connectionString);
                    });

                    services.AddSingleton<MainForm>();
                    services.AddTransient<LoginView>();
                    services.AddTransient<RegisterView>();
                    services.AddTransient<DashboardView>();
                    services.AddTransient<UpcomingEventsView>();
                    services.AddTransient<EventDetailsView>();
                    services.AddTransient<MyTicketsView>();
                    services.AddTransient<MyProfileView>();
                    services.AddTransient<ManageEventsView>();
                    services.AddTransient<AddEditEventForm>();
                    services.AddTransient<ManageUsersView>();
                });
    }
}
