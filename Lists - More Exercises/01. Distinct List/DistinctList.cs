using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class DistinctList
    {
        static List<int> List = new List<int>();
        static bool IsEqualNumbers(int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (List[i] == List[index])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            List = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> NewList = new List<int>();
            for (int cnt = 0; cnt < List.Count; cnt++)
            {
                if (IsEqualNumbers(cnt))
                {
                    NewList.Add(List[cnt]);
                }
            }
            Console.WriteLine(string.Join(" ",NewList));
        }
    }
}
