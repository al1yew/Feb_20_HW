using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Milk : Product
    {
        public double Volume;
        public byte FatRate;
        public Milk(string name, double price, int count, double totalincome, double volume, byte fatrate) : base(name, price, count, totalincome)
        {
            Volume = volume;
            FatRate = fatrate;
        }
    }
}