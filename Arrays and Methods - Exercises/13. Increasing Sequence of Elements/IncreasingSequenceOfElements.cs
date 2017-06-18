using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence_of_Elements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            int[] nums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                nums[i] = int.Parse(arr[i]);
            }
            int lastNum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (lastNum < nums[i])
                {
                    lastNum = nums[i];
                }
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
