using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string tern = Console.ReadLine().ToLower();

            int index = text.IndexOf(tern);
            int occurrences = 0;
            while (index != -1)
            {
                occurrences++;
                index = text.IndexOf(tern, index + 1);
            }
            Console.WriteLine(occurrences);
        }
    }
}
