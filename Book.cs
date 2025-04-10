using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    internal abstract class Book
    {
        string title;
        string author;
        int year;
        decimal price;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Year { get => year; set => year = value; }
        public decimal Price { get => price; set => price = value; }

        public Book(string title, string author, int year, decimal price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }
    }
}
