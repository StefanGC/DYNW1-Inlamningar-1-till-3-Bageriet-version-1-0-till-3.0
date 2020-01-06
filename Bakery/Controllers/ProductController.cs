using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _productt;
        private readonly ICommentary accessCommentary;
        private readonly IGrades accessGrades;

        public IActionResult Index()
        {
            return View();
        }
    }
}