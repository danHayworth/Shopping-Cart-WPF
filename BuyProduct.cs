using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ShoppingCart
{
    public class BuyProduct : Product
    {
        internal int quantity;
        public BuyProduct(string name, float price, int quantity) : base(name, price)
        {
            this.quantity = quantity;
        }
    }
}
