using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            List<string> newlist = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    newlist.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join("",newlist));
        }
    }
}
