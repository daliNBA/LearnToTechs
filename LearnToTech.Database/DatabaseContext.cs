using LearnToTech.Database.Enities;
using Microsoft.EntityFrameworkCore;

namespace LearnToTech.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
