using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class Item
    {
        public String Name { get; set; }
        public float Price { get; set; }

        public Item(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
