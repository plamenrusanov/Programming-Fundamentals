using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiter = ".,:;()[]\"'\\/!? ".ToCharArray();
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(delimiter,StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length < 5)
                .Distinct()
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ",words));

        }
    }
}
