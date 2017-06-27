using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> FirstList = new List<int>();
            List<int> ListForSplit = new List<int>();

            for (int i = 0; i < List.Count; i++)
            {
                if (i <= (List.Count - 1) / 2)
                {
                    FirstList.Add(List[i]);
                }
                else
                {
                    ListForSplit.Add(List[i]);
                }
            }
            List<int> PrintList = new List<int>();
            for (int i = 0; i < ListForSplit.Count; i++)
            {
                int left = ListForSplit[i] / 10;
                int rigth = ListForSplit[i] % 10;
                PrintList.Add(left);
                PrintList.Add(FirstList[i]);
                PrintList.Add(rigth);
            }
            Console.WriteLine(string.Join(" ", PrintList));
        }
    }
}
