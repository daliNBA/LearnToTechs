using Microsoft.EntityFrameworkCore;
using System;

namespace LearnToTech.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
