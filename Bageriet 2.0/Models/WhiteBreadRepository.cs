using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class WhiteBreadRepository : IWhiteBreadRepository
    {
        private readonly AppDbContext _appDbContext;

        public WhiteBreadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<WhiteBread> All
        {
            get
            {
                return _appDbContext.whiteBreads;
            }
        }

        public IEnumerable<WhiteBread> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.whiteBreads;
            }
        }

        public WhiteBread GetPieById(int id)
        {
            return _appDbContext.whiteBreads.FirstOrDefault(p => p.WhiteBreadid == id);
        }
    }
}
