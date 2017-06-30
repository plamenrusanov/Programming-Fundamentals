using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class UnunionLists
    {     
        static void Main(string[] args)
        {
            List<int>PrimalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int>CurrentList = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int cnt = 0; cnt < CurrentList.Count; cnt++)
                {

                    if (PrimalList.Contains(CurrentList[cnt]))
                    {
                        PrimalList.RemoveAll(x => x == CurrentList[cnt]);
                    }
                    else
                    {
                        PrimalList.Add(CurrentList[cnt]);
                    }
                }
            }
            PrimalList.Sort();
            Console.WriteLine(string.Join(" ",PrimalList));
        }
    }
}
