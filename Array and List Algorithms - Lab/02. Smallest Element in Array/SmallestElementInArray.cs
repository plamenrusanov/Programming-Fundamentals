using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minNum = int.MaxValue;
            for (int cnt = 0; cnt < Array.Length; cnt++)
            {
                if (Array[cnt] < minNum)
                {
                    minNum = Array[cnt];
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
