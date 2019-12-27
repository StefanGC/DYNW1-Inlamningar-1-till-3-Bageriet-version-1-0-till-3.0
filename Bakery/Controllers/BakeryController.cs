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
        private readonly IBreadRepository _breadRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BakeryController(IBreadRepository breadRepository, ICategoryRepository categoryRepository)
        {
            _breadRepository = breadRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Index()
        {
            BreadsListViewModel breadsListViewModel = new BreadsListViewModel();
            breadsListViewModel.Breads = _breadRepository.AllBreads;

            breadsListViewModel.CurrentCategory = "White Bread";
            return View(breadsListViewModel);
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
    }
}