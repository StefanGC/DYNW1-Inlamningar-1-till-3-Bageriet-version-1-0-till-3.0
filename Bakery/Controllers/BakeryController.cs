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
using Microsoft.AspNetCore.Authorization;

namespace Bakery.Controllers
{
    public class BakeryController : Controller
    {
        private readonly IBreadRepository _breadRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IGradeRepository _gradeRepository;

        public BakeryController(IBreadRepository breadRepository, ICategoryRepository categoryRepository, ICommentRepository commentRepository, IGradeRepository gradeRepository)
        {
            _breadRepository = breadRepository;
            _categoryRepository = categoryRepository;
            _commentRepository = commentRepository;
            _gradeRepository = gradeRepository;
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

        public ViewResult Details(int id)
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
            
            BreadsListViewModel breadsListViewModel = new BreadsListViewModel();
            breadsListViewModel.comments = new List<Comment>();
            breadsListViewModel.Bread = _breadRepository.GetBreadById(id);
            breadsListViewModel.comments = _commentRepository.GetCommentByProduct(id).ToList();

            IEnumerable<Grade> myGrades = _gradeRepository.GetGradesByProduct(id);
            List<int> allGrades = new List<int>();
            foreach (Grade grad in myGrades)
            {
                allGrades.Add(grad.Grad);
            }

            if (allGrades.Count > 0)
            {
                double gradeNum = allGrades.Average();
                breadsListViewModel.GradeAverage = Math.Round(gradeNum);
            }
            else
            {
                breadsListViewModel.GradeAverage = 0.0;
            }
            return View(breadsListViewModel);
        }

        public RedirectToActionResult WriteComment(int id, string text)
        {
            Comment myComment = new Comment();
            myComment.Id = Guid.NewGuid().ToString();
            myComment.ProductId = id;
            myComment.Text = text;

            _commentRepository.AddComment(myComment);

            return RedirectToAction("Details", "Bakery", new { id = id });
        }

        [Authorize]
        public RedirectToActionResult WriteGrade(int id, string grade)
        {
            
            Grade myGrade = new Grade();
            myGrade.Id = Guid.NewGuid().ToString();
            //myGrade.Id = Convert.ToInt32(Guid.NewGuid().ToByteArray());
            myGrade.ProductId = id;
            myGrade.Grad = Convert.ToInt32(grade);

            _gradeRepository.AddGrades(myGrade);

            return RedirectToAction("Details", "Bakery", new { id = id });
        }
    }
}