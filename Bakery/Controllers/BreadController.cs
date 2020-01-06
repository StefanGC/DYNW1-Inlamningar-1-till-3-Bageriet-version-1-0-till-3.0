using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class BreadController : Controller
    {
        private readonly IBreadRepository _breadRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IGradeRepository _gradeRepository;

        public BreadController(IBreadRepository breadRepository, ICategoryRepository categoryRepository, ICommentRepository commentRepository, IGradeRepository gradeRepository)
        {
            _breadRepository = breadRepository;
            _categoryRepository = categoryRepository;
            _commentRepository = commentRepository;
            _gradeRepository = gradeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}