using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BandGear.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new BandGear.Models.Guitar();
            model.Name = "Stratocaster";
            return View(model);
        }


        public IActionResult Create(string GuitarName)
        {
            var model = new BandGear.Models.Guitar();
            model.Name = GuitarName;
            return View("Index", model);
        }
    }
}
