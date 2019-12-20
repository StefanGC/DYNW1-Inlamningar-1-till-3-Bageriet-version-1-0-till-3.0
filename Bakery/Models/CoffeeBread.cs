using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class CoffeeBread : Bread
    {
        public CoffeeBread (int id, string name, string description, string image) : base(id, name, description, image)
        {
        }
    }
}
