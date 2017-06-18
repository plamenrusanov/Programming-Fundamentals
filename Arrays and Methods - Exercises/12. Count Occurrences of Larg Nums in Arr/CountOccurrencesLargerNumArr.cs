using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurrences_of_Larg_Nums_in_Arr
{
    class CountOccurrencesLargerNumArr
    {
        static void Main(string[] args)
        {
            string[] stringDoubles = Console.ReadLine().Split(' ');
            double magicNumber = double.Parse(Console.ReadLine());

            double[] doubleNums = new double[stringDoubles.Length];
            for (int i = 0; i < stringDoubles.Length; i++)
            {
                doubleNums[i] = double.Parse(stringDoubles[i]);
            }
            int count = 0;
            for (int i = 0; i < doubleNums.Length; i++)
            {
                if (doubleNums[i] > magicNumber)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
