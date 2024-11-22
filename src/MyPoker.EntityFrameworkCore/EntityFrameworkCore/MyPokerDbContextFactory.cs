using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyPoker.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MyPokerDbContextFactory : IDesignTimeDbContextFactory<MyPokerDbContext>
{
    public MyPokerDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        MyPokerEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MyPokerDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new MyPokerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MyPoker.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
