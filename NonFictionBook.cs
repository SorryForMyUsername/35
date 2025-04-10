using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    /// <summary>
    /// Нехудожественная книга
    /// </summary>
    internal class NonFictionBook : Book
    {
        string subject;

        public string Subject { get => subject; set => subject = value; }

        public NonFictionBook(string title, string author, int year,
            decimal price, string subject) : base(title, author, year, price)
        {
            Subject = subject;
        }
    }
}
