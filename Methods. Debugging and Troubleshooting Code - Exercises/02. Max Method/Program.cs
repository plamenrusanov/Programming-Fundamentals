using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = GetMax(a, b);
            Console.WriteLine(GetMax(c, max));

        }
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
