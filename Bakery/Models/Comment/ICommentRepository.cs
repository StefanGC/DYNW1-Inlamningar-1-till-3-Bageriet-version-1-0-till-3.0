using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllComment();
        IEnumerable<Comment> GetCommentByProduct(int id);
        void AddComment(Comment inCommentary);
    }
}
