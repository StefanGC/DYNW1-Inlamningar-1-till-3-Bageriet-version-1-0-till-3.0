using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class GradeRepository : IGradeRepository
    { 
        private readonly AppDbContext _appDbContext;

        public GradeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Grade> GetGradesAll()
        {
            return _appDbContext.AllGrades;
        }

        // hämta alla betyg för angiven produkt
        public IEnumerable<Grade> GetGradesByProduct(int inProjektId)
        {
            return _appDbContext.AllGrades.
                            Where(c => c.ProductId == inProjektId);
            //Where(c => c.ProductId == inProjektId).ToList();
        }

        // lägg till nytt betyg
        public void AddGrades(Grade grade)
        {
            _appDbContext.AllGrades.Add(grade);
            _appDbContext.SaveChanges();
        }

        IEnumerable<Grade> IGradeRepository.GetGradesAll()
        {
            throw new NotImplementedException();
        }
    }
}

