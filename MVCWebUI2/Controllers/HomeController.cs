using System.Diagnostics;
using Market.MVCWebUI2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Market.MVCWebUI2.Controllers
{
    public class HomeController : Controller
    {
        public ILogger<HomeController> Logger1 { get; }

        public HomeController(ILogger<HomeController> logger)
        {
            Logger1 = logger;
        }

        public IActionResult Index()
        {
            return View();
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
