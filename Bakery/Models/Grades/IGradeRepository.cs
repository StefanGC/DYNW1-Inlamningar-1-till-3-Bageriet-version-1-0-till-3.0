using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface IGradeRepository
    {
        IEnumerable<Grade> GetGradesAll();
        IEnumerable<Grade> GetGradesByProduct(int id);
        void AddGrades(Grade grade);
    }
}
