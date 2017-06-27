using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            int list1Sum = 0;
            int list2Sum = 0;
            
            for (int cnt = 0; cnt < firstList.Count; cnt++)
            { 
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (firstList[cnt] == secondList[i])
                    {
                        secondList.RemoveAt(i);
                        i--;
                    }               
                }
                list1Sum += firstList[cnt];
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                list2Sum += secondList[i];
            }
            if (list1Sum == list2Sum)
            {
                Console.WriteLine($"Yes. Sum: {list1Sum}");
            }
            else
            {
                int diff = Math.Abs(list1Sum - list2Sum);
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
