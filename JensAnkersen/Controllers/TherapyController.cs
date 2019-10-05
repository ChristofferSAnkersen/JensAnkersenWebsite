using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JensAnkersen.Controllers
{
    public class TherapyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}