using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;

namespace Bakery.ViewModels
{
    public class BreadsListViewModel
    {
        public IEnumerable<Bread> Breads { get; set; }
        public Bread Bread { get; set; }
        public string CurrentCategory { get; set; }
        public List<Comment> comments { get; set; }
        public double GradeAverage { get; set; }
    }
}
