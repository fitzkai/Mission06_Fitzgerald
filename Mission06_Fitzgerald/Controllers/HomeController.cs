using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
//using Mission06_Fitzgerald.Models;

namespace Mission06_Fitzgerald.Controllers
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

        public IActionResult AboutJoel() 
        {
            return View();
        }
    }
}
