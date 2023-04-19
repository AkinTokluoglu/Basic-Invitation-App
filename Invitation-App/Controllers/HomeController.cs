using Invitation_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Invitation_App.Models;

namespace Invitation_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Answer()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Answer(Answer answer)
        {
            if (ModelState.IsValid)
            {
                Repository.AddAnswer(answer);
                return View("thanks", answer);
            }

            else return View();
        }

        public ViewResult AnswerList()
        {

            return View(Repository.Answers.Where(x => x.YourAnswer == true));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}