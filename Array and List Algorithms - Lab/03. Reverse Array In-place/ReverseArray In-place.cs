using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int cnt = 0; cnt < Array.Length / 2; cnt++)
            {
                int temp = Array[cnt];
                Array[cnt] = Array[Array.Length - (cnt + 1)];
                Array[Array.Length - (cnt + 1)] = temp;
            }
            Console.WriteLine(string.Join(" ", Array));
        }
    }
}
