using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;

namespace Bakery.ViewModels
{
    public class BreadsListViewModel
    {
        public IEnumerable<WhiteBread> Breads { get; set; }
        public string CurrentCategory { get; set; }
    }
}
