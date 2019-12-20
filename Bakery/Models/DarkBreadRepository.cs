using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class DarkBreadRepository : IDarkBreadRepository
    {
        private readonly AppDbContext _appDbContext;

        public DarkBreadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<DarkBread> All
        {
            get
            {
                return _appDbContext.darkBreads.Include(c => c.name);
            }
        }


        public DarkBread GetPieById(int DarkBreadId)
        {
            return _appDbContext.darkBreads.FirstOrDefault(p => p.WhiteBreadid == DarkBreadId);
        }
    }
}
