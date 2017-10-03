using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            for (long j = 2; j <= n; j++)
            {
                bool isPrime = true;
                for (long i = 2; i <= Math.Sqrt(j); i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{j} -> {isPrime}");
            }


        }
    }
}
