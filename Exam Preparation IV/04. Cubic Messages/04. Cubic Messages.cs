using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            string p = @"[@]{1}";
            string pattern = @"(?<first>^[\d]+)(?<mes>[a-zA-Z]{@})(?<last>[^a-zA-Z]*$)";
            string input = Console.ReadLine();
           
            while (input != "Over!")
            {
                string key = Console.ReadLine();
                string escapedKey = Regex.Escape(key);
                string crypt = Regex.Replace(pattern, p, escapedKey);

                if (Regex.IsMatch(input, crypt))
                {
                    Match m = Regex.Match(input, crypt);
                    string mess = m.Groups["mes"].Value;
                    string code = m.Groups["first"].Value + m.Groups["last"].Value;
                    string verificationCode = Verification(mess, code);
                    Console.WriteLine($"{mess} == {verificationCode}");
                }
                input = Console.ReadLine();              
            }
        }

        private static string Verification(string mess, string code)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < code.Length; i++)
            {
                if (char.IsDigit(code[i]))
                {
                    int @char = (int)code[i] - 48;
                    if (@char >= 0 && @char < mess.Length)
                    {
                        sb.Append(mess[@char]);
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
            }
            return sb.ToString();
        }
    }
}
