using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            string[] ArrayOfIntegers = Console.ReadLine().Split(' ');
            int[] Arr = new int[ArrayOfIntegers.Length];
            for (int i = 0; i < ArrayOfIntegers.Length; i++)
            {
                Arr[i] = int.Parse(ArrayOfIntegers[i]);
            }
            int minElement = int.MaxValue;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < minElement)
                {
                    minElement = Arr[i];
                }
            }
            Console.WriteLine(minElement);
        }
    }
}
