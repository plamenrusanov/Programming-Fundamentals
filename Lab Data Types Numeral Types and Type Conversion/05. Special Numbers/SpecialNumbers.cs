using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num1 = i % 10;
                int num2 = i / 10;
                if (num1 + num2 == 5)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else if (num1 + num2 == 7)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else if (num1 + num2 ==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False"); 
                }
            }
        }
    }
}
