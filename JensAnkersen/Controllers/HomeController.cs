using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JensAnkersen.Models;

namespace JensAnkersen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 360)]
        public IActionResult Index()
        {
            string controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            if (!String.IsNullOrWhiteSpace(controllerName))
            {
                return View(new ControllerName() { ControllerString = controllerName }); 
            }
            return View(new ControllerName());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
