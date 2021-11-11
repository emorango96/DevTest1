using System;
using System.Collections.Generic;
using System.Text;

namespace DevTest1
{
    public class ShoppingCart
    {
        public List<Item> Items { get; private set; }
        public DateTime? PurchaseDate { get; private set; } = null;
        public float TotalPrice { get; private set; } = 0;

        public ShoppingCart()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            TotalPrice += item.Price;
        }

        public void Purchase()
        {
            PurchaseDate = DateTime.Now;
            Console.WriteLine($"You just purchased the cart with a total of: {TotalPrice}, at: {PurchaseDate}");
        }

        public int GetAmountOfItems() => Items.Count;

        public float GetTotalPrice()
        {
            float total = 0;

            foreach (Item i in Items)
                total += i.Price;

            return total;
        }
    }
}
