using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

            }
        }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Date { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public Book(string[] input)
        {
            Title = input[0];
            Author = input[1];
            Publisher = input[2];
            Date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            ISBN = input[4];
            Price = double.Parse(input[5]);
        }
    }
}
