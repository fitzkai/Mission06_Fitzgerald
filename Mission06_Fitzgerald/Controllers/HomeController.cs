using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Mission06_Fitzgerald.Models;

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

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult EnterMovie()
        //{
        //    return View("Confirmation", response);
        //}
    }
}
