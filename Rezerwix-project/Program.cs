using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Rezerwix_project.Forms;
using Rezerwix_project;

namespace Rezerwix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.Migrate();
                context.SeedData();
            }

            ApplicationConfiguration.Initialize();

            using (var scope = host.Services.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(form);
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                    services.AddDbContext<AppDbContext>(options =>
                        options.UseNpgsql(connectionString));

                    // Rejestracja formularzy z DI
                    services.AddTransient<MainForm>();
                });
    }
}
