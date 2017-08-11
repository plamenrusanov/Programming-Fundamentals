using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection phoneMaches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMaches.Cast<Match>().Select(a => a.Value.Trim());

            Console.Write(string.Join(", ",matchedPhones));
            Console.WriteLine();
        }
    }
}
