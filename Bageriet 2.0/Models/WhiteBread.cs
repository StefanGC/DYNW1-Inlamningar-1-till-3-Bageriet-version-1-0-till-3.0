using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class WhiteBread : Bread
    {
        public List<WhiteBread> whiteBreads { get; set; }
        public WhiteBread (int WhiteBreadid, string name, string description, string image) : base(WhiteBreadid, name, description, image)
        {
        }
    }
}