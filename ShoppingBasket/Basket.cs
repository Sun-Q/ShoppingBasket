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
                Console.WriteLine("Item Name: " + item.Name + ", Price " + item.Price);

                total += item.Price;
            }
            Console.WriteLine("Total price: " + total);
        }

        private Item GetNewItem()
        {
            Console.WriteLine("Please enter the item name:");
            var name = GetItemName();

            Console.WriteLine("Please enter the item price:");
            var price = GetItemPrice();

            return new Item(name, price);
        }

        private string GetItemName()
        {
            return "Testing";
        }

        private float GetItemPrice()
        {
            float parsedPrice = 0;

            return parsedPrice;
        }

        private bool IsThereANewItem()
        {
            Console.WriteLine("Would you like to add another item? (Y/N)");

            bool parsedInput;
            while (!ParseUserConfirmation(Console.ReadLine(), out parsedInput))
            {
                Console.WriteLine("Something went wrong. Please re-enter the item price:");
            }

            return parsedInput;
        }

        private bool ParseUserConfirmation(string input, out bool result)
        {
            input = input.ToLower();

            if (input.Equals("y") || input.Equals("yes"))
            {
                result = true;
                return true;
            }
            else if (input.Equals("n") || input.Equals("n"))
            {
                result = false;
                return true;
            }
            else
            {
                result = false;
                return false;
            }
        }

    }
}
