using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class MinMethod
    {
        static void GetMin()
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
        static void Main(string[] args)
        {
            GetMin();
        }
    }
}
