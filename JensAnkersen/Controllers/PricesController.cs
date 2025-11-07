using JensAnkersen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace JensAnkersen.Controllers
{
    public class PricesController : Controller
    {
        [ResponseCache(Duration = 3600)]
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