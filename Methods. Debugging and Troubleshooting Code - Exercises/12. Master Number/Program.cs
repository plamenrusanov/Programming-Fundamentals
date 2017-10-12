using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                if (IsPalindrome(i))
                {
                    if (SumOfDigits(i))
                    {
                        if (ContainsEvenDigit(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }          
        }

        private static bool ContainsEvenDigit(int i)
        {
            while (i != 0)
            {
                if (i % 2 == 0 )
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool SumOfDigits(int i)
        {
            int sum = 0;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(int i)
        {
            string number = i.ToString();
            for (int j = 0; j < number.Length /2 ; j++)
            {
                if (number[j] != number[number.Length - 1 - j ])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
