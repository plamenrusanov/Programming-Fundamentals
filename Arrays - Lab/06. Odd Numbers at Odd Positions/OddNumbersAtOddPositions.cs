using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class OddNumbersAtOddPositions
    {
        static void Main(string[] args)
        {
            string[] ArrayOfIntegers = Console.ReadLine().Split(' ');

            int[] Array = new int[ArrayOfIntegers.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = int.Parse(ArrayOfIntegers[i]);
            }
            for (int i = 0; i < Array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (Math.Abs(Array[i]) % 2 != 0)
                    {                       
                        Console.WriteLine($"Index {i} -> {Array[i]}");
                    }
                }
            }
        }
    }
}
