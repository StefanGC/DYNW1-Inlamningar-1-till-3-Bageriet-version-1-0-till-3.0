using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<WhiteBread> whiteBreads { get; set; }
        public DbSet<DarkBread> darkBreads { get; set; }
        public DbSet<CoffeeBread> coffeeBreads { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

    }
}
