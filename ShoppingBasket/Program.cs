using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Program
    {
        static List<string> items = new List<string>();
        static List<int> prices = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");

            Basket myBasket = new Basket(Console.ReadLine());

            bool hasMoreItem = true;

            while (hasMoreItem)
            {
                hasMoreItem = myBasket.AskForNewItem();
            }

            myBasket.PrintBasket();
        }

    }
}
