using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitabin adi");
            string bookname = Console.ReadLine();
            
            Console.WriteLine("Kitabin sehifelerinin sayi");
            string pages = Console.ReadLine();
            int pagesconverted = int.Parse(pages);

            Book book = new Book(bookname, pagesconverted);

            Book[] array = new Book[0];
            for (int i = 0; i <= 10; i++)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = book;
            }

            foreach (Book item in array)
            {
                Console.WriteLine(book);
            };


            //string[] array1 = { "book1", "book2", "book3", "book4", "book5", "book6", "book7", "book8", "book9", "book10" };

        }
    }
}
