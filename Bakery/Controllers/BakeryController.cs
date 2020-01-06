using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Bakery.Models;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Bakery.Controllers
{
    public class BakeryController : Controller
    {
        private readonly IBreadRepository _breadRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductCommentRepository _productCommentRepository;

        public BakeryController(IBreadRepository breadRepository, ICategoryRepository categoryRepository, IProductCommentRepository productCommentRepository)
        {
            _breadRepository = breadRepository;
            _categoryRepository = categoryRepository;
            _productCommentRepository = productCommentRepository;
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
        /*
        public IActionResult Details(int id)
        {
            Bread bread = _breadRepository.GetBreadById(id);
            if (bread == null)
                return NotFound();

            return View(bread);
        }*/

        public IActionResult Details(int id)
        {
            var userName = "";
            try
            {
                userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            
            BreadsListViewModel breadsListViewModel = new BreadsListViewModel
            {
                Bread = _breadRepository.GetBreadById(id),
                //ProductRank = _productRankRepository.GetAverageProductRank(id),
                //ProductRankCount = _productRankRepository.GetProductRankCount(id),
                //ProductUserRank = _productRankRepository.GetUserProductRank(id, userName),
                ProductComments = _productCommentRepository.GetProductComments(id)
            };

            if (breadsListViewModel.Bread == null)
            {
                return NotFound();
            }

            return View(breadsListViewModel);
        }

        public IActionResult WriteComment()
        {
            return View();
        }
    }
}