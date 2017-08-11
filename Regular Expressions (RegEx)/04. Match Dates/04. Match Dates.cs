using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})\2(\d{4})\b";

            string inputDate = Console.ReadLine();

            var MatchedDate = Regex.Matches(inputDate, pattern);

            foreach (Match item in MatchedDate)
            {
                string day = item.Groups[1].Value;
                string month = item.Groups[3].Value;
                string year = item.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
