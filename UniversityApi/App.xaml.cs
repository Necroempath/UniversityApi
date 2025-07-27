using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleInjector;
using UniversityApi.Data;

namespace UniversityApi;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static readonly Container Container = new();
    public IConfiguration Configuration { get; set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        var builder = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json");
        Configuration = builder.Build();

        Register();
    }

    private void Register()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        Container.RegisterSingleton<AppDbContext>(() =>
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(Configuration.GetConnectionString("Default"))
                .Options;

            return new AppDbContext(options);
        });
    }
}