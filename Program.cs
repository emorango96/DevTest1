using System;

namespace DevTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing the shopping cart");

            ShoppingCart cart = new ShoppingCart();

            cart.AddItem(new Item("DVD", 5, 20f));
            cart.AddItem(new Item("Computer", 10, 50f));
            cart.AddItem(new Item("TV", 15, 35f));

            Console.WriteLine("These are the items in the shopping cart:");
            for (int i = 0; i < cart.Items.Count; i++)
                Console.WriteLine($"\tItem: {cart.Items[i].ItemName}, Price: {cart.Items[i].Price}, Quantity: {cart.Items[i].Quantity}");

            Console.WriteLine($"Total price: {cart.GetTotalPrice()}");

            Console.WriteLine();
            Console.WriteLine("Press any key to purchase the items in the shopping cart");
            Console.ReadKey();
            cart.Purchase();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
