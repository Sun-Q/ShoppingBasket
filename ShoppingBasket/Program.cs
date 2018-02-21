using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");

            Basket myBasket = new Basket(Console.ReadLine());

            while (myBasket.AskForNewItem())
            { }

            myBasket.PrintBasket();
        }

    }
}
