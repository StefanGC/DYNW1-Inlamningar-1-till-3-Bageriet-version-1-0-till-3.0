using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Bakery.Models;
using Bakery.ViewModels;

namespace Bakery.Controllers
{
    public class BakeryController : Controller
    {
        private readonly IWhiteBreadRepository _whiteBreadRepository;
        private readonly IDarkBreadRepository _darkBreadRepository;
        private readonly ICoffeeBreadRepository _coffeeBreadRepository;

        public BakeryController(IWhiteBreadRepository whiteBreadRepository, IDarkBreadRepository darkBreadRepository, ICoffeeBreadRepository coffeeBreadRepository)
        {
            _whiteBreadRepository = whiteBreadRepository;
            _darkBreadRepository = darkBreadRepository;
            _coffeeBreadRepository = coffeeBreadRepository;
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Greeting"] = "Hello";
            ViewData["Address"] = new Address("Campus Värnamo", "Jönköpingsvägen 15", "Värnamo", "331 34");

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

        public IActionResult List()
        {
            BreadsListViewModel breadsListViewModel = new BreadsListViewModel();
            breadsListViewModel.Breads = _whiteBreadRepository.All;

            breadsListViewModel.CurrentCategory = "White Bread";
            return View(breadsListViewModel);
        }
    }
}