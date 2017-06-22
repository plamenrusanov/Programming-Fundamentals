using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_Numbers_To_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= -99 && number <= 99)
                {
                    continue;
                }
                else if (number >= 1000)
                {
                    Console.WriteLine("too large");
                    continue;
                }
                else if (number <= -1000)
                {
                    Console.WriteLine("too small");
                    continue;
                }
                int num = Math.Abs(number);
                int firstDigit = num / 100;
                int secondDigit = (num / 10) % 10;
                int thirdDigit = num % 10;

                string[] hundred = { "one-hundred", "two-hundred","three-hundred","four-hundred"
                ,"five-hundred","six-hundred","seven-hundred","eight-hundred","nine-hundred"};
                string[] tens = { "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] units = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string and = " and ";
                string space = " ";
                string printNumber = "";
                if (num % 100 == 0)
                {
                    printNumber = hundred[firstDigit - 1];
                }
                else if (num % 100 < 10)
                {
                    printNumber = hundred[firstDigit - 1] + and + units[thirdDigit - 1];
                }
                else if (num % 100 < 20)
                {
                    printNumber = hundred[firstDigit - 1] + and + teens[thirdDigit];
                }
                else if (thirdDigit == 0)
                {
                    printNumber = hundred[firstDigit - 1] + and + tens[secondDigit - 1];
                }
                else
                {
                    printNumber = hundred[firstDigit - 1] + and + tens[secondDigit - 1] + space + units[thirdDigit - 1];
                }
                if (number < 0)
                {
                    printNumber = "minus " + printNumber;
                }

                Console.WriteLine(printNumber);
            }
        }
    }
}
