using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            }
            Console.WriteLine(CountingZeros(factorial));
        }

        private static int CountingZeros(BigInteger factorial)
        {
            string fact = factorial.ToString();
            int zeros = 0;
            for (int i = fact.Length -1; i >= 0; i--)
            {
                if (fact[i].Equals('0'))
                {
                    zeros++;
                }
                else
                {
                    break;
                }
            }
            return zeros;
        }
    }
}
