using Microsoft.Extensions.Configuration;

namespace UniversityApi.Configuration;

public static class ConfigurationLoader
{
    public static IConfiguration LoadConfiguration()
    {
        return new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json").Build();
    }
}