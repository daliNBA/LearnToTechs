using LearnToTech.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;


namespace LearnToTech.DatabaseMigrator
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddEnvironmentVariables().AddUserSecrets("LearnToTech.DatabaseMigrator").Build();
            var connectionString = configuration.GetConnectionString("MyEquipmentDatabase");
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseSqlServer(connectionString, x => x.CommandTimeout(3600 * 6)).Options;
            return new DatabaseContext(options);

        }
    }
}
