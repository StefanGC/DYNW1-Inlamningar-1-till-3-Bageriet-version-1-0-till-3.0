using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Address
    {
        public string name { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }

        public Address (string name, string street, string city, string postalCode)
        {
            this.name = name;
            this.street = street;
            this.city = city;
            this.postalCode = postalCode;
        }
    }
}
