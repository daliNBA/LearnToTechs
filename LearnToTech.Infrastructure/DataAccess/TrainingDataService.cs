using LearnToTech.Database;
using LearnToTech.Database.Enities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnToTech.Infrastructure.DataAccess
{
    public class TrainingDataService : BaseDataAccess
    {
        public TrainingDataService(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public async Task AddTraining(Training training)
        {
            context.Trainings.Add(training);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Training>> GetAllTraining()
        {
           return await context.Trainings.Where(x=>x.IsActive).ToListAsync();
        }
    }
}
