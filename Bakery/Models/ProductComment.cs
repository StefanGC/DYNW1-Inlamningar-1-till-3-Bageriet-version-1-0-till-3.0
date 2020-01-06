using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class ProductComment
    {
        public int ProductCommentId { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
        public Bread Product { get; set; }

    }
}
