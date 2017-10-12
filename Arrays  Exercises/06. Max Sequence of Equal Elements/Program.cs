using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> temp = new List<int>();
            List<int> result = new List<int>();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (i > 0 && inputNumbers[i] == inputNumbers[i - 1])
                {
                    temp.Add(inputNumbers[i]);
                }
                else
                {
                    if (temp.Count > result.Count)
                    {
                        CopyList(result, temp);
                    }
                    temp.Clear();
                    temp.Add(inputNumbers[i]);
                }
            }
            if (temp.Count > result.Count)
            {
                CopyList(result, temp);
            }
            Console.WriteLine(string.Join(" ",result));
        }

        private static void CopyList(List<int> result, List<int> temp)
        {
            result.Clear();
            for (int i = 0; i < temp.Count; i++)
            {
                result.Add(temp[i]);
            }
        }
    }
}
