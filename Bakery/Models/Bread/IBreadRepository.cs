using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface IBreadRepository
    {
        IEnumerable<Bread> AllBreads { get; }
        IEnumerable<Bread> BreadsOfTheWeek { get; }
        Bread GetBreadById(int breadId);
    }
}
