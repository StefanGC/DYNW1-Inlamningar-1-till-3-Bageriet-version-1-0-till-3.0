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
        public string CurrentCategory { get; set; }
        public IEnumerable<ProductComment> ProductComments { get; set; }
        public ProductComment ProductComment { get; set; }
        public Bread Bread { get; set; }
        public int ProductRank { get; set; }
        public int ProductUserRank { get; set; }
        public int ProductRankCount { get; set; }
    }
}
