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
            Greeting();

            while (AddItem())
            {
            }

            PrintList();
        }

        static void Greeting()
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }

        static Boolean AddItem()
        {
            Console.WriteLine("Please enter the item name:");
            items.Add(Console.ReadLine());

            Console.WriteLine("Please enter the item price:");
            prices.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Would you like to add another item? (Y/N)");
            var temp = Console.ReadLine();
            if (temp.Equals("Y"))
                return true;
            else return false;
        }

        static void PrintList()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Item Name: " + items[i] + ", Price: " + prices[i]);
            }

            Console.WriteLine("Total price: " + prices.Sum());
        }

    }
}
