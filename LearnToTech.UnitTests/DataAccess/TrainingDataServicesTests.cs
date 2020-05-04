using LearnToTech.Database;
using LearnToTech.Infrastructure.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace LearnToTech.UnitTests.DataAccess
{
    [TestClass]
    public class TrainingDataServicesTests : DatabaseTestsBase
    {
        [TestMethod]
        public async Task GetAllTrainigAsync()
        {
            var training1 = RandomTraining(true);
            var training2 = RandomTraining(true);
            using (var context = new DatabaseContext(options))
            {
                context.Add(training1);
                context.Add(training2);
                context.SaveChanges();
            }
            using (var ds = new TrainingDataService(options))
            {
                var trainings = await ds.GetAllTraining();
                Assert.AreEqual(2, trainings.Count());
            }
        }
    }
}
