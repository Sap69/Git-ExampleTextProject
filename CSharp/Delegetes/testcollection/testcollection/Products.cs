using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcollection
{
    public class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Products(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
