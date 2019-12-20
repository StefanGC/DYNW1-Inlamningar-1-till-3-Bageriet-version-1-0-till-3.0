using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface ICoffeeBreadRepository
    {
        IEnumerable<CoffeeBread> All { get; }
    }
}