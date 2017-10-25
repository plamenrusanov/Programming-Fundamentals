using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Book>> data = new Dictionary<string, List<Book>>();
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (!data.ContainsKey(input[1]))
                {
                    data.Add(input[1], new List<Book>());
                }
                data[input[1]].Add(new Book(input));
                Library library = new Library(input);
                library.Name = input[1];
                           
                library.Books.Add(new Book(input));
            }
           
            foreach (var item in data.OrderByDescending(i => i.Value.Select(e => e.Price).Sum()).ThenBy(i => i.Key))
            {
                string name = item.Key;

                decimal totalPrice = item.Value.Select(i => i.Price).Sum();
                
                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
     class Library
     {
        public Library(string[] input)
        {
            Name = input[1];
            Books = new List<Book>();
        }
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
        public decimal Price { get; set; }
        public Book(string[] input)
        {
            Title = input[0];
            Author = input[1];
            Publisher = input[2];
            Date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            ISBN = input[4];
            Price = decimal.Parse(input[5]);
        }
    }
}
