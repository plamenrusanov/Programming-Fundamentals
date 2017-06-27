using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> NewList = new List<int>();
            NewList.Add(List[0]);
            for (int i = List.Count-2; i >= 1; i--)
            {
                NewList.Add(List[i]);
            }
            NewList.Add(List[List.Count - 1]);

            Console.WriteLine(string.Join(" ",NewList));
        }
    }
}
