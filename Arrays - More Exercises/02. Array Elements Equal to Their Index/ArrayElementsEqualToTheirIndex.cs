using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    class ArrayElementsEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int[] num = new int[numbers.Length];
            string printNumbers = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                num[i] = int.Parse(numbers[i]);
                if (i == num[i])
                {
                    printNumbers += $"{i} ";
                }
            }
            Console.WriteLine(printNumbers);
        }
    }
}
