using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[input.Length / 2];
            for (int i = 0; i < result.Length /2; i++)
            {
                result[result.Length / 2 -i -1] = input[i];
            }
            for (int i = 0; i < result.Length /2; i++)
            {
                result[result.Length / 2 + i] = input[input.Length - 1 - i];
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] += input[input.Length / 4 + i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
