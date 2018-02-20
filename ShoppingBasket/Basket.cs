using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class Basket
    {
        public string Username { get; private set; }

        private List<Item> items = new List<Item>();

        public Basket(string username)
        {
            Username = username;

            Greeting();
        }

        public void Greeting()
        {
            Console.WriteLine("Hello, " + Username);
        }

        public bool AskForNewItem()
        {
            Item item = new Item();

            Console.WriteLine("Please enter the item name:");
            item.Name = Console.ReadLine();

            Console.WriteLine("Please enter the item price:");
            while (!float.TryParse(Console.ReadLine(), out item.Price))
            {
                Console.WriteLine("Something went wrong. Please re-enter the item price:");
            }

            items.Add(item);

            Console.WriteLine("Would you like to add another item? (Y/N)");
            var temp = Console.ReadLine();
            if (temp.Equals("Y"))
                return true;
            else return false;
        }

        public void PrintBasket()
        {
            float total = 0;

            foreach (Item item in items)
            {
                Console.WriteLine("Item Name: " + item.Name + ", Price: " + item.Price);

                total += item.Price;
            }

            Console.WriteLine("Total price: " + total);
        }
    }
}
