using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element_in_Array
{
    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            string[] stringOfNumber = Console.ReadLine().Split(' ');
            int magicNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[stringOfNumber.Length];
            for (int i = 0; i < stringOfNumber.Length; i++)
            {
                numbers[i] = int.Parse(stringOfNumber[i]);
            }
            int countMagicNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == magicNumber)
                {
                    countMagicNumbers++;
                }
            }
            Console.WriteLine(countMagicNumbers);
        }
    }
}

