using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ShoppingCart
{
    public class Product
    {
        internal string name { get; set; }
        internal float price { get; set; }

        public Product(string na, float pr)
        {
            this.name = na;
            this.price = pr;
        }
        
    }
}
