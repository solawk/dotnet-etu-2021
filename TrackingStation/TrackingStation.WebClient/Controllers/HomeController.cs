using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingStation.WebClient.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> Logger { get; }

        public HomeController(ILogger<HomeController> logger)
        {
            Logger = logger;
        }
        
        public IActionResult Bodies()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
