using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();

            string pattern = @"(^|(?<=\s))(<\[[^\da-zA-Z]*\]\.{1})(\.\[[\da-zA-Z]*\]\.)*($|(?=\s))";
            string input = Console.ReadLine();
            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match r = Regex.Match(input, pattern);
                    data.Add(r.Value);
                }
                input = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
