using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class NthDigit
    {
        static int FindNthDigit(long number, int index)
        {
            for (int i = 0; i < index - 1; i++)
            {
                number /= 10;
            }
            return (int)number % 10;
        }
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(num, index));
        }
    }
}
