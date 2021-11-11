using System;
using System.Collections.Generic;
using System.Text;

namespace DevTest1
{
    public class Item
    {
        public string ItemName { get; private set; }
        public int Quantity { get; private set; }
        public float Price { get; private set; }

        public Item(string name, int quantity, float price)
        {
            ItemName = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
