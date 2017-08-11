using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(<a) ([^>]+)(>\w+)(<\/a>)";
         
            string input = Console.ReadLine();
            while (input != "end")
            {

                MatchCollection matBeg = Regex.Matches(input, pattern);

                    string str = "[/URL]";
                foreach (Match item in matBeg)
                {

                    string tree ="]" + item.Groups[3].Value.Substring(1, item.Groups[3].Value.Length - 1);
                    input = input.Replace(item.Groups[1].Value, "[URL");
                    input = input.Replace(item.Groups[3].Value, tree);
                    input = input.Replace(item.Groups[4].Value, str);

                }
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
           

        }
    }
}
