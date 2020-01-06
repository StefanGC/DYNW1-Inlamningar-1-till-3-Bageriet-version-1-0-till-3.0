using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public string Text { get; set; }
    }
}
