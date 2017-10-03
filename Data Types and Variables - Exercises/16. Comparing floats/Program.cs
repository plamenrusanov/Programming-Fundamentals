using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());
            decimal diff = Math.Abs(number1 - number2);
            if (diff < 0.000001m)
            {
              //  Console.WriteLine(diff);
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
