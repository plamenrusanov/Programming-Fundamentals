using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialNumbers = Console.ReadLine()
                                    .Split().Select(int.Parse).ToList();
            int k = initialNumbers.Count / 4;
            List<int> first = initialNumbers.Take(k).ToList();
            List<int> last = initialNumbers.Skip(3 * k).Take(k).ToList();          
            first.Reverse();
            last.Reverse();
            List<int> newList = first.Concat(last).ToList();           
            initialNumbers = initialNumbers.Skip(k).Take(2 * k).ToList();           
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write("{0} ",newList[i] + initialNumbers[i]);
            }
        }
    }
}
