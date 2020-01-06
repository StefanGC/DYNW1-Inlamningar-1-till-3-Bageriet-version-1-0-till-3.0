using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class ProductCommentRepository : IProductCommentRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductCommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateProductComment(ProductComment productComment)
        {
            if (productComment.CommentText != "")
            {
                var newComment = new ProductComment();
                newComment.CommentDate = DateTime.Now;
                newComment.CommentText = productComment.CommentText;
                newComment.ProductId = productComment.ProductId;
                newComment.UserName = productComment.UserName;

                _appDbContext.ProductComments.Add(newComment);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<ProductComment> GetProductComments(int productId)
        {
            return _appDbContext.ProductComments.Where(c => c.ProductId == productId);
        }
    }
}
