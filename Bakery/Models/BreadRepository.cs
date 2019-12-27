using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class BreadRepository : IBreadRepository
    {
        private readonly AppDbContext _appDbContext;

        public BreadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Bread> AllBreads
        {
            get
            {
                return _appDbContext.Breads.Include(c => c.Category);
            }
        }

        public IEnumerable<Bread> BreadsOfTheWeek
        {
            get
            {
                return _appDbContext.Breads.Include(c => c.Category).Where(p => p.IsBreadOfTheWeek);
            }
        }

        public Bread GetBreadById(int breadId)
        {
            return _appDbContext.Breads.FirstOrDefault(p => p.BreadId == breadId);
        }
    }
}
