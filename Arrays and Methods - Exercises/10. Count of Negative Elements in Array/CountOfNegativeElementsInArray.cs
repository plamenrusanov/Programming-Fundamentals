using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negative_Elements_in_Array
{
    class CountOfNegativeElementsInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countNegatives = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    countNegatives++;
                }
            }
            Console.WriteLine(countNegatives);
        }
    }
}
