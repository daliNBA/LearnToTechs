using LearnToTech.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnToTech.Infrastructure.DataAccess
{
    public abstract class BaseDataAccess
    {
        protected readonly DatabaseContext context;
        public BaseDataAccess(DbContextOptions<DatabaseContext> options)
        {
            context = new DatabaseContext(options);
        }
    }
}
