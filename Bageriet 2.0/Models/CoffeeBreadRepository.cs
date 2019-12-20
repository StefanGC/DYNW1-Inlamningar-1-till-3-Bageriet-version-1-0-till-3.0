using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class CoffeeBreadRepository : ICoffeeBreadRepository
    {
        private readonly AppDbContext _appDbContext;

        public CoffeeBreadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CoffeeBread> All
        {
            get
            {
                return _appDbContext.coffeeBreads;
            }
        }

        public CoffeeBread GetPieById(int CoffeeBreadId)
        {
            return _appDbContext.coffeeBreads.FirstOrDefault(p => p.WhiteBreadid == CoffeeBreadId);
        }
    }
}

