using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string result = "other";
            if (char.IsDigit(ch))
            {
                result = "digit";
            }
            else if (ch.Equals('a') || ch.Equals('e') || ch.Equals('u') || ch.Equals('i') || ch.Equals('o') || ch.Equals('y'))
            {
                result = "vowel";
            }
            Console.WriteLine(result);
        }
    }
}
