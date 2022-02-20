using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;
        public int Sell(int SelledCount)
        {
            return this.Count -= SelledCount;
        }
        public Product(string name, double price, int count, double totalincome)
        {
            Name = name;
            Price = price;
            Count = count;
            TotalIncome = totalincome;
        }
    }
}
