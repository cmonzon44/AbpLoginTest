using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpLoginTest.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpLoginTestDbContextFactory : IDesignTimeDbContextFactory<AbpLoginTestDbContext>
{
    public AbpLoginTestDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpLoginTestEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpLoginTestDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpLoginTestDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpLoginTest.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
