using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    internal class Library
    {
        List<TextBook> textBooks = new List<TextBook>();
        List<FictionBook> fictionBooks = new List<FictionBook>();
        List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();

        public void AddTextBook()
        {
            Console.WriteLine("\nДобавление нового учебника.");
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Уровень обучения: ");
            string grade_level = Console.ReadLine();
            textBooks.Add(new TextBook(title, author, year, price, grade_level));
        }
        public void AddFictionBook()
        {
            Console.WriteLine("\nДобавление новой художественной книги.");
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Жанр: ");
            string genre = Console.ReadLine();
            fictionBooks.Add(new FictionBook(title, author, year, price, genre));
        }
        public void AddNonFictionBook()
        {
            Console.WriteLine("\nДобавление новой нехудожественной книги.");
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Предмет: ");
            string subject = Console.ReadLine();
            nonFictionBooks.Add(new NonFictionBook(title, author, year, price, subject));
        }
        public void GetAllTextBooks()
        {
            foreach(TextBook tBook in textBooks)
            {
                Console.WriteLine($"\nНазвание: {tBook.Title}\n" +
                    $"Автор: {tBook.Author}\n" +
                    $"Год издания: {tBook.Year}\n" +
                    $"Цена: {tBook.Price}\n" +
                    $"Уровень обучения: {tBook.Grade_level}");
            }
        }
        public void GetAllFictionBooks()
        {
            foreach (FictionBook fBook in fictionBooks)
            {
                Console.WriteLine($"\nНазвание: {fBook.Title}\n" +
                    $"Автор: {fBook.Author}\n" +
                    $"Год издания: {fBook.Year}\n" +
                    $"Цена: {fBook.Price}\n" +
                    $"Жанр: {fBook.Genre}");
            }
        }
        public void GetAllNonFictionBooks()
        {
            foreach (NonFictionBook fBook in nonFictionBooks)
            {
                Console.WriteLine($"\nНазвание: {fBook.Title}\n" +
                    $"Автор: {fBook.Author}\n" +
                    $"Год издания: {fBook.Year}\n" +
                    $"Цена: {fBook.Price}\n" +
                    $"Предмет: {fBook.Subject}");
            }
        }
    }
}
