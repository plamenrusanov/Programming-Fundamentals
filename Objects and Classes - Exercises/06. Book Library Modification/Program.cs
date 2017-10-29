using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
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
                if (!data.ContainsKey(input[0]))
                {
                    data.Add(input[0], new List<Book>());
                }
                data[input[0]].Add(new Book(input));
                Library library = new Library(input);
                library.Name = input[0];
                library.Books.Add(new Book(input));
            }
            DateTime cheker = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            SortedDictionary<string, DateTime> dict = new SortedDictionary<string, DateTime>();
            foreach (var item in data)
            {
                List<Book> newData = item.Value;
                foreach (Book kvp in newData)
                {
                    string title = kvp.Title;
                    DateTime date = kvp.Date;
                    if (cheker < date)
                    {
                        if (!dict.ContainsKey(title))
                        {
                            dict.Add(title, date);
                        }
                        
                    }
                }      
            }
            foreach (var item in dict.OrderBy(i => i.Value).ThenBy(k => k.Key))
            {
                
                Console.WriteLine($"{item.Key} -> {item.Value:dd.MM.yyyy}");
            }
        }
    }
    class Library
    {
        public Library(string[] input)
        {
            Name = input[0];
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
