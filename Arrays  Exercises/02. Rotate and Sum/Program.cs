using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            for (int i = 0; i < rotation ; i++)
            {

                int temp = array[array.Length - 1];
                for (int j = array.Length - 1; j >= 1; j--)
                {
                   
                    array[j] = array[j - 1];
                    sum[j] += array[j];
                }
                array[0] = temp;
                sum[0] += array[0];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
        
    }
}
