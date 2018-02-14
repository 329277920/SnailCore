using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnailCore.Tester.Web.Models;
using SnailCore.Log;

namespace SnailCore.Tester.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
