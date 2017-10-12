using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fib(n);
            Console.WriteLine(result);
        }

        private static int Fib(int n)
        {
            int count = 0;
            int prevNum = 1;
            int num = 0;
            int nextNum = 0;
            while (n >= count)
            {
                nextNum = prevNum + num;
                prevNum = num;
                num = nextNum;
                count++;
            }

            return nextNum;

        }
    }
}
