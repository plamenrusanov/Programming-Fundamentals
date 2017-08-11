using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string inputNumbers = Console.ReadLine();

            string[] data = Regex.Matches(inputNumbers, pattern).Cast<Match>().Select(m => m.Value).ToArray();

            Console.WriteLine(string.Join(" ", data));
        }
    }
}
