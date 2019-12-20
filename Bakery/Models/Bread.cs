using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Bread
    {
        public int WhiteBreadid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }

        public Bread (int id, string name, string description, string image)
        {
            this.WhiteBreadid = id;
            this.name = name;
            this.description = description;
            this.image = image;
    }
    }
}
