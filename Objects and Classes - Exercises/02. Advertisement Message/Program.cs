using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string[] phrases = new string[6];
            {
                phrases[0] = "Excellent product.";
                phrases[1] = "Such a great product.";
                phrases[2] = "I always use that product.";
                phrases[3] = "Best product of its category.";
                phrases[4] = "Exceptional product.";
                phrases[5] = "I can’t live without this product.";
            }
            string[] events = new string[6];
            {
                events[0] = "Now I feel good.";
                events[1] = "I have succeeded with this product.";
                events[2] = "Makes miracles. I am happy of the results!";
                events[3] = "I cannot believe but now I feel awesome.";
                events[4] = "Try it yourself, I am very satisfied.";
                events[5] = "I feel great!";
            }
            string[] authors = new string[8];
            {
                authors[0] = "Diana";
                authors[1] = "Petya";
                authors[2] = "Stella";
                authors[3] = "Elena";
                authors[4] = "Katya";
                authors[5] = "Iva";
                authors[6] = "Annie";
                authors[7] = "Eva";
            }
            string[] towns = new string[5];
            {
                towns[0] = "Burgas";
                towns[1] = "Sofia";
                towns[2] = "Plovdiv";
                towns[3] = "Varna";
                towns[4] = "Ruse";
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(phrases[rnd.Next(0, phrases.Length)] + " ");
                Console.Write(events[rnd.Next(0, events.Length)] + " ");
                Console.Write(authors[rnd.Next(0, authors.Length)] + " - ");
                Console.WriteLine(towns[rnd.Next(0, towns.Length)]);
            }
        }
    }
}
