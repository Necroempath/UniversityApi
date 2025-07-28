using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UniversityApi.Configuration;

namespace UniversityApi.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>();
        options.UseSqlServer(ConfigurationLoader.LoadConfiguration().GetConnectionString("Step"));
        
        return new AppDbContext(options.Options);
    }
}