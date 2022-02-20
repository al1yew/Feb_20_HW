using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Ag Pendir", 10.5, 100, 1050);
            Milk milk = new Milk("Moloko", 1.5, 30, 45, 100, 3);

            Console.WriteLine($"Name: {product.Name}\nPrice: {product.Price} manat\nCount: {product.Count} eded\nTotal Income:" +
                $" {product.TotalIncome} manat\n");
            Console.WriteLine($"Name: {milk.Name}\nPrice: {milk.Price} manat\nCount: {milk.Count} dene qab\nTotal Income:" +
                $" {milk.TotalIncome} manat\nVolume: {milk.Volume} Litr\nFatrate: {milk.FatRate}%");

            Console.WriteLine("Nece eded alacagsiniz?");
            string countinput = Console.ReadLine();
            int a = int.Parse(countinput);

            if (product.Sell(a) < product.Count)
            {
                Console.WriteLine($"Bizim o qeder mehsulumuz yoxdu. Max {product.Count} qeder sifarish vere bilersiz ");
            }
            else
            {
                Console.WriteLine(product.Sell(a));
            }
        }
    }
}