using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface IProductCommentRepository
    {
        void CreateProductComment(ProductComment productComment);
        IEnumerable<ProductComment> GetProductComments(int productId);
    }
}
