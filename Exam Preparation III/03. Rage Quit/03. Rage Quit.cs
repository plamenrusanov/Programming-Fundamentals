using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine().ToUpper();
            
            string pattern = @"(\D+)(\d+)";
            StringBuilder sb = new StringBuilder();

            MatchCollection m = Regex.Matches(input, pattern);

            foreach (Match item in m)
            {
                string app = item.Groups[1].Value;
                int count = int.Parse(item.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    sb.Append(app);
                }
            }         
            List<char> unic = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    unic.Add(input[i]);
                }
            }          
            unic = unic.Distinct().ToList();

            Console.WriteLine($"Unique symbols used: {unic.Count}");
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine();
            //unic.Sort();
            //Console.WriteLine(string.Join(" ",unic));
        }
    }
}
