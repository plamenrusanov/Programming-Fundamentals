using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=[SHDC]))(10[SHDC]|[2-9JQKA]{1}[SHDC]{1})";

            string input = Console.ReadLine();

            MatchCollection m = Regex.Matches(input, pattern);

            string[] result = m.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
