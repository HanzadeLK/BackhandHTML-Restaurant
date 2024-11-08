using BHPractiseEmlak.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BHPractiseEmlak.Controllers
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

        public IActionResult About()
        {

            List<Team> teams = Data.TeamDataAccess.GetTeams();
            return View(teams);
        }

        public IActionResult Projects()
        {
            List<Project> projects = Data.DataAccess.GetProjects();

            return View(projects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
