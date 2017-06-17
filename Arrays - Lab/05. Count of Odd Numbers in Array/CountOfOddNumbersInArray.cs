using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            string[] ArrayOfIntegers = Console.ReadLine().Split(' ');

            int[] Array = new int[ArrayOfIntegers.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = int.Parse(ArrayOfIntegers[i]);
            }
            int countOdd = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Math.Abs(Array[i]) % 2 != 0)
                {
                    countOdd += Array[i];
                }
            }
            Console.WriteLine(countOdd);
        }
    }
}
