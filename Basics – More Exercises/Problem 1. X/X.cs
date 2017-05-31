using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("x");
                Console.Write(new string(' ', n - (i * 2) - 2));
                Console.Write("x");
                Console.WriteLine(new string(' ', i));
            }
            Console.Write(new string(' ', n / 2));
            Console.Write("x");
            Console.WriteLine(new string(' ', n / 2));
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.Write(new string(' ', i));
                Console.Write("x");
                Console.Write(new string(' ', (n - 1) - (i * 2) - 1));
                Console.Write("x");
                Console.WriteLine(new string(' ', i));
            }
        }
    }
}
