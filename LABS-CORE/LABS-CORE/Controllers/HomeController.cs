using LABS_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LABS_CORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) //dependecy injection
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //throw new ArgumentNullException(); //test exception
            _logger.LogInformation("Index page says hello");
            return View("page1");
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