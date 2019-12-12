using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet_1._0.Models
{
    public abstract class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        public Product (int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class Bread : Product
    {

        public Bread (int id, string name) : base (id, name)
        {
        }
    }

    public class Cookies : Product
    {

        public Cookies (int id, string name) : base(id, name)
        {
        }
    }
}
