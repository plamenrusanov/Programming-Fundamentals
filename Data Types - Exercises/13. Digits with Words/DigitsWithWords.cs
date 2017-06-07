using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Digits_with_Words
{
    class DigitsWithWords
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().ToLower().Trim();

            int number = int.MinValue;

            switch (num)
            {
                case "zero": number = 0; break;
                case "one": number = 1; break;
                case "two": number = 2; break;
                case "three": number = 3; break;
                case "four": number = 4; break;
                case "five": number = 5; break;
                case "six": number = 6; break;
                case "seven": number = 7; break;
                case "eight": number = 8; break;
                case "nine": number = 9; break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;
            }
            if (number != int.MinValue)
            {
                Console.WriteLine(number);
            }
        }
    }
}
