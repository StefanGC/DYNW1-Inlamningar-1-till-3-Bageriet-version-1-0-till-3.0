using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Grade
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public int Grad { get; set; }
        
        public Grade(string Id, int ProductId, int Grad)
        {
            this.Id = Id;
            this.ProductId = ProductId;
            this.Grad = Grad;
        }

        public Grade()
        {
        }
    }
}
