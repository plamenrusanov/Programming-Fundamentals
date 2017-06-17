using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Debugging_Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetMultiplyByEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvensDigits(n);
            int sumOdds = GetSumOfOddsDigits(n);
            return sumEvens * sumOdds;
        }
        static int GetSumOfEvensDigits(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int digit= n % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                n /= 10;
            } 
            return sum;
        }
        static int GetSumOfOddsDigits(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                n /= 10;
            } 
            return sum;
        }
        static void Main(string[] args)
        {
            int n = Math.Abs (int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultiplyByEvensAndOdds(n));
        }
    }
}
