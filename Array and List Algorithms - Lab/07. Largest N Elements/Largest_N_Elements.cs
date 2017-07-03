using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Largest_N_Elements
    {
        static List<int> firstNumList = new List<int>();
        static List<int> NewNumList = new List<int>();
        static void Main(string[] args)
        {
            firstNumList = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            InsetionSort();         
            for (int i = 0; i < n; i++)
            {
                Console.Write(firstNumList[i]+" ");
            }
        }
        static void Swap(int first, int second)
        {
            int temp = firstNumList[first];
            firstNumList[first] = firstNumList[second];
            firstNumList[second] = temp;
        }
        static void InsetionSort()
        {
            for (int firstIndex = 0; firstIndex < firstNumList.Count; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (firstNumList[secondIndex] > firstNumList[secondIndex - 1])
                    {
                        Swap(secondIndex, secondIndex - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
      
    }
}
