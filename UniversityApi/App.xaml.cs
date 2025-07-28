using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleInjector;
using UniversityApi.Configuration;
using UniversityApi.Data;

namespace UniversityApi;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static readonly Container Container = new();

    protected override void OnStartup(StartupEventArgs e)
    {
        Register();
    }

    private void Register()
    {
        Container.RegisterSingleton<AppDbContext>(() =>
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(ConfigurationLoader.LoadConfiguration()
                .GetConnectionString("Step"))
                .Options;

            return new AppDbContext(options);
        });
    }
}