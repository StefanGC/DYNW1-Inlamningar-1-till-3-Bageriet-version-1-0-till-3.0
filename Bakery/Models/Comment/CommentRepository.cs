using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Comment> GetAllComment()
        {
            return _appDbContext.Comments;
        }

        // hämta alla kommentarer för angiven produkt
        public IEnumerable<Comment> GetCommentByProduct(int inProjektId)
        {
            return _appDbContext.Comments.
                            Where(c => c.ProductId == inProjektId);
            
        }

        public void AddComment(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
        }
    }
}
