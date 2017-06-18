using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                string first = arr[i];
                int secondPosition = arr.Length - (i + 1);
                string second = arr[secondPosition];
                if (first == second) ;
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
