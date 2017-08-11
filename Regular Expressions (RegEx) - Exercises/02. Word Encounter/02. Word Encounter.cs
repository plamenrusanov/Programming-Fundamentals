using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(\w{1})(\d)";
            string filter = Console.ReadLine();
            MatchCollection data = Regex.Matches(filter, patern);
            string @char = null;
            int num = 0;
            foreach (Match item in data)
            {
                @char = item.Groups[1].Value;
                num = int.Parse(item.Groups[2].Value);
            }
            List<string> fil = new List<string>();

            for (int i = 0; i < num; i++)
            {
                fil.Add(@char);
            }
            List<string> result = new List<string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (IsValid(input))
                {                   
                    string pattern = @"\b(\w)*" + string.Join(@"(\w)*", fil) + @"(\w)*\b";
                    MatchCollection n = Regex.Matches(input, pattern);                   
                    foreach (Match word in n)
                    {
                        result.Add(word.Value);
                    }                 
                }
               
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", result));
        }
        private static bool IsValid(string input)
        {
            if (input[0] >= 65 && input[0] <= 90)
            {
                if (input[input.Length - 1] == 33 || input[input.Length -1] == 46 || input[input.Length -1] == 63)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
