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
            AddItem(GetNewItem());

            return IsThereANewItem();
        }

        public void AddItem(Item item)
        {
            items.Add(item);

            Console.WriteLine("{0}: £{1} is added.", item.Name, item.Price);
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

        private Item GetNewItem()
        {
            Item item = new Item();

            Console.WriteLine("Please enter the item name:");
            item.Name = GetItemName();

            Console.WriteLine("Please enter the item price:");
            item.Price = GetItemPrice();

            return item;
        }

        private string GetItemName()
        {
            return Console.ReadLine();
        }

        private float GetItemPrice()
        {
            float parsedPrice = 0;

            while (!float.TryParse(Console.ReadLine(), out parsedPrice))
            {
                Console.WriteLine("Something went wrong. Please re-enter the item price:");
            }
            return parsedPrice;
        }

        private bool IsThereANewItem()
        {
            Console.WriteLine("Would you like to add another item? (Y/N)");
            var temp = Console.ReadLine();
            if (temp.Equals("Y"))
                return true;
            else return false;
        }
    }
}
