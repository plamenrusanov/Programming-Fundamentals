using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> result = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ",result));
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            bool isPrime;
            List<int> result = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                isPrime = true;
                for (long j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }

    }
}
