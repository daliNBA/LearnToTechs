using LearnToTech.Database.Enities;
using LearnToTech.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearnToTech.WebUI.Controllers
{
    public class TrainingController : Controller
    {
        protected readonly TrainingDataService dataService;
        public TrainingController(TrainingDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var training1 = new Training
            {
                Label = "Test",
                Price = 50,
                IsSubtitled = true,
                IsActive = true
            };
            await dataService.AddTraining(training1);
            var training = await dataService.GetAllTraining();
            return View(training);
        }
    }
}