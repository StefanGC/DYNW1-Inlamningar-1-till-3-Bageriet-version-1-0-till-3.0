using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class DarkBread : Bread
    {
        public DarkBread (int id, string name, string description, string image) : base(id, name, description, image)
        {
        }
    }
}
