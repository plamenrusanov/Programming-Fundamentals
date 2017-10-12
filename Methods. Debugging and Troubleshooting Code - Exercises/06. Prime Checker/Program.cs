using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            if (n == 0 || n == 1)
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(long n)
        {
            for (long j = 2; j <= Math.Sqrt(n); j++)
            {
                if (n % j == 0)
                {                 
                    return false;
                }
            }
            return true;
        }
    }
}
