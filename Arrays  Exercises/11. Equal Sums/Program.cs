using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumBefore = 0;
            int sumAfter = input.Sum();
            for (int i = 0; i < input.Length; i++)
            {
                if (sumBefore == sumAfter - input[i])
                {
                    Console.WriteLine(i);
                    return;
                }
                sumBefore += input[i];
                sumAfter -= input[i];
            }
            Console.WriteLine("no");
        }

       
    }
}
