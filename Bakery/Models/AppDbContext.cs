using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Bread> Breads { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "White breads" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Dark breads" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Coffee breads" });

            //seed Breads

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 1,
                Name = "Limpan",
                Price = 20,
                ShortDescription = "Älskade limpmacka!",
                LongDescription =
                    "Älskade limpmacka! Nu Sverige mest sålda limpa. PågenLimpan var en av de första skivade limporna när den lanserades i början av 90-talet. Den klassiska svenska limpan är bakad på vete och siktat rågmjöl som tillsammans med surdeg och sirap ger en härlig mjuk och saftigt limpa. Njut av en Svensk klassiker!",
                CategoryId = 1,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/04/01/12/36/bread-2193537_960_720.jpg",
                InStock = true,
                IsBreadOfTheWeek = true,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2017/04/01/12/36/bread-2193537_960_720.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 2,
                Name = "Levain",
                Price = 20,
                ShortDescription = "Fantastiskt gott osötat surdegsbröd",
                LongDescription =
                    "Fantastiskt gott osötat surdegsbröd bakat på de allra finaste råvarorna. Bakat med solmoget vete och få ingredienser – inga konstigheter. Njut av en skiva Levain eller två, när du blir sugen på något gott och härligt!",
                CategoryId = 1,
                ImageUrl = "https://cdn.pixabay.com/photo/2018/10/09/20/27/bread-3735903_960_720.jpg",
                InStock = true,
                IsBreadOfTheWeek = false,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2018/10/09/20/27/bread-3735903_960_720.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 3,
                Name = "Jättefranska",
                Price = 20,
                ShortDescription = "Härligt rostbröd.",
                LongDescription =
                    "Härligt rostbröd med tydlig och balanserad smak - Jättegott! Lanserades 1960 och är Sveriges första skivade formfranska. Idén kom från USA där just skivad formfranska var oerhört populärt. I Sverige tog vi snabbt till oss den amerikanska trenden med att rosta brödet och JätteFranska blev folkets favorit.",
                CategoryId = 1,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/12/05/11/04/toast-1077984_960_720.jpg",
                InStock = true,
                IsBreadOfTheWeek = false,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2015/12/05/11/04/toast-1077984_960_720.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 4,
                Name = "LingonGrova Special",
                Price = 20,
                ShortDescription = "Bästa starten på dagen!",
                LongDescription =
                    "Bästa starten på dagen! Mer lingon och mindre socker gör LingonGrova Special till ett lite nyttigare alternativ. Sveriges mest älskade bröd ger en riktigt god start på vilken morgon som helst.",
                CategoryId = 2,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/10/22/17/10/bread-1761197_960_720.jpg",
                InStock = true,
                IsBreadOfTheWeek = false,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2016/10/22/17/10/bread-1761197_960_720.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 5,
                Name = "LingonGrova",
                Price = 20,
                ShortDescription = "Bästa starten på dagen!",
                LongDescription =
                    "Bästa starten på dagen! Sveriges mest älskade bröd är en oumbärlig del av frukosten. Fullkorn, surdeg och svenska lingon gör LingonGrova till en riktigt god start på vilken morgon som helst.",
                CategoryId = 2,
                ImageUrl = "https://cdn.pixabay.com/photo/2019/11/21/14/46/white-bread-4642686_960_720.jpg",
                InStock = true,
                IsBreadOfTheWeek = false,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2019/11/21/14/46/white-bread-4642686_960_720.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 6,
                Name = "Råg Levain",
                Price = 20,
                ShortDescription = "Smakrikt rustikt surdegsbröd",
                LongDescription =
                    "Smakrikt rustikt surdegsbröd med malt och groddade rågkärnor. Bakat med mjöl från vår egen kvarn och få ingredienser – inga konstigheter. Njut av den gyllengräddade skorpan och den milt syrliga smaken!",
                CategoryId = 2,
                ImageUrl = "https://cdn.pixabay.com/photo/2018/06/19/09/34/bread-3484107_960_720.jpg",
                InStock = true,
                IsBreadOfTheWeek = false,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2018/06/19/09/34/bread-3484107_960_720.jpg",
                AllergyInformation = ""
            });
           
        }
    }
}
