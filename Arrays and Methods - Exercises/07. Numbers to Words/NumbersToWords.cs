using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_Words
{
    class NumbersToWords
    {
        static string WordOfHundred(long number)
        {
            string hundred = string.Empty;
            long digitOfHundred = number / 100;
            switch (digitOfHundred)
            {
                case 1: hundred = "one-hundred"; break;
                case 2: hundred = "two-hundred"; break;
                case 3: hundred = "three-hundred"; break;
                case 4: hundred = "four-hundred"; break;
                case 5: hundred = "five-hundred"; break;
                case 6: hundred = "six-hungred"; break;
                case 7: hundred = "seven-hundred"; break;
                case 8: hundred = "eight-hundred"; break;
                case 9: hundred = "nine-hundred"; break;
                default: break;
            }
            return hundred;
        }
        static string WordOfTens(long number)
        {
            long digitTens = (number / 10) % 10;
            string wordTens = string.Empty;
            switch (digitTens)
            {
                case 2: wordTens = " and twenty"; break;
                case 3: wordTens = " and thirty"; break;
                case 4: wordTens = " and forty"; break;
                case 5: wordTens = " and fifty"; break;
                case 6: wordTens = " and sixty"; break;
                case 7: wordTens = " and seventy"; break;
                case 8: wordTens = " and eighty"; break;
                case 9: wordTens = " and ninety"; break;
                default:
                    break;
            }
            return wordTens;
        }
        static string WordOfTeens(long number)
        {
            long digitTeen = number % 100;
            string wordTeen = string.Empty;
            switch (digitTeen)
            {
                case 10: wordTeen = " and ten"; break;
                case 11: wordTeen = " and eleven"; break;
                case 12: wordTeen = " and twelve"; break;
                case 13: wordTeen = " and thirteen"; break;
                case 14: wordTeen = " and fourteen"; break;
                case 15: wordTeen = " and fifteen"; break;
                case 16: wordTeen = " and sixteen"; break;
                case 17: wordTeen = " and seventeen"; break;
                case 18: wordTeen = " and eighteen"; break;
                case 19: wordTeen = " and nineteen"; break;
                default:
                    break;
            }
            return wordTeen;
        }
        static string WordOfDigit(long number)
        {

            long digit = number % 10;
            string wordDigit = string.Empty;
            switch (digit)
            {
                case 1: wordDigit = " one"; break;
                case 2: wordDigit = " two"; break;
                case 3: wordDigit = " three"; break;
                case 4: wordDigit = " four"; break;
                case 5: wordDigit = " five"; break;
                case 6: wordDigit = " six"; break;
                case 7: wordDigit = " seven"; break;
                case 8: wordDigit = " eight"; break;
                case 9: wordDigit = " nine"; break;
                default:
                    break;
            }
            return wordDigit;
        }
        static string stringNum(long number)
        {
            long digit = number % 10;
            string wordDigit = string.Empty;
            switch (digit)
            {
                case 1: wordDigit = " and one"; break;
                case 2: wordDigit = " and two"; break;
                case 3: wordDigit = " and three"; break;
                case 4: wordDigit = " and four"; break;
                case 5: wordDigit = " and five"; break;
                case 6: wordDigit = " and six"; break;
                case 7: wordDigit = " and seven"; break;
                case 8: wordDigit = " and eight"; break;
                case 9: wordDigit = " and nine"; break;
                default:
                    break;
            }
            return wordDigit;
        }
        static string PrintNumbersToWord(long num)
        {
            string minus = string.Empty;
            string wordOfNumber = string.Empty;
            long number = Math.Abs(num);
            if (number >= 0 && number <= 99) 
            {
                return wordOfNumber;
            }
            else if (number >= 100 && number <= 999)
            {
                WordOfHundred(number);
                wordOfNumber = wordOfNumber + WordOfHundred(number);
                if (number % 100 >= 20 && number % 100 <= 99)
                {
                    WordOfTens(number);
                    wordOfNumber = wordOfNumber + WordOfTens(number);
                    if (number % 10 != 0)
                    {
                        WordOfDigit(number);
                        wordOfNumber = wordOfNumber + WordOfDigit(number);
                    }
                }
                if (number % 100 >= 10 && number % 100 <= 19)
                {
                    WordOfTeens(number);
                    wordOfNumber = wordOfNumber + WordOfTeens(number);
                }
                if (number % 100 >= 1 && number % 100 <= 9)
                {
                    stringNum(number);
                    wordOfNumber += stringNum(number);
                }
                if (num < 0)
                {
                    minus = "minus ";
                    wordOfNumber = minus + wordOfNumber;
                }
            }
            else if (num >= 1000)
            {
                wordOfNumber = "too large";
            }
            else if (num <= -1000)
            {
                wordOfNumber = "too small";
            }
            return wordOfNumber;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                long num = long.Parse(Console.ReadLine());
                if (num >= -99 && num <= 99)
                {
                    continue;
                }
                Console.WriteLine(PrintNumbersToWord(num));
            }
        }
    }
}
