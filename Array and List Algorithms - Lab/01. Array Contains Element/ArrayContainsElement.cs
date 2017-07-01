using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split(new char [] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            bool IsEqualNum = false;
            for (int cnt = 0; cnt < List.Count; cnt++)
            {
                if (List[cnt] == n)
                {
                    IsEqualNum = true;
                }
            }
            if (IsEqualNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
