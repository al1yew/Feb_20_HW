using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Book
    {
        public Book(string a, int b)
        {
            _name = a;
            _pagecount = b;
        }
        public string _name
        {
            get 
            {
                return _name;
            }
            set 
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Kitabin adi 3den uzun olmalidi");
                }
                else
                {
                    value = _name;
                }
            }
        }
        public int _pagecount
        {
            get 
            {
                return _pagecount;
            }
            set 
            {
                if (value < 10)
                {
                    Console.WriteLine("Kitabin sehifeleri 10dan cox olmalidi.");
                }
                else
                {
                    _pagecount = value;
                }
            }
        }
        public string GetFullInfo() 
        {
            return $"{_name} {_pagecount}";
        }
        
    }
}
