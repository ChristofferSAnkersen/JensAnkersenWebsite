using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JensAnkersen.Models;
using Microsoft.AspNetCore.Mvc;

namespace JensAnkersen.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            // Use this to set the name of the controller to use to-top functions
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