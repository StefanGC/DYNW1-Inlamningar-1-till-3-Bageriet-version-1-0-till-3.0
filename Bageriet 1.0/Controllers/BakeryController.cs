using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Bageriet_1._0.Models;

namespace Bageriet_1._0.Controllers
{
    public class BakeryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Greeting"] = "Hello";
            ViewData["Address"] = new Address()
            {
                Name = "Campus Värnamo",
                Street = "Jönköpingsvägen 15",
                City = "Värnamo",
                PostalCode = "331 34"
            };

            return View();
        }

        // GET: /Bakery/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}