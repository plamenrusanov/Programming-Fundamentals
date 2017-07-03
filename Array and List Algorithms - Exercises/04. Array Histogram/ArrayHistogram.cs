using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            int countOfList = list.Count;
            List<string> printList = new List<string>();
            List<int> index = new List<int>();
            for (int first = 0; first < list.Count; first++)
            {
                int count = 1;
                printList.Add(list[first]);
                for (int cnt = first +1; cnt < list.Count; cnt++)
                {
                    if (list[first] == list[cnt])
                    {
                        count++;
                        list.RemoveAt(cnt);
                        cnt--;
                    }
                }
                index.Add(count);
            }
            InsetionSort(printList, index);
            for (int i = 0; i < printList.Count; i++)
            {
                Console.WriteLine(printList[i]+" -> "+index[i]+" times ({0:f2}%)",((double)index[i] / countOfList)*100);
            }
        }
        static void Swap(List<string> printList,List<int> index , int first, int second)
        {
            int temp = index[first];
            index[first] = index[second];
            index[second] = temp;
            string Temp = printList[first];
            printList[first] = printList[second];
            printList[second] = Temp;
        }
        static void InsetionSort(List<string> printList,List<int> index)
        {
            for (int firstIndex = 0; firstIndex < index.Count; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (index[secondIndex] > index[secondIndex - 1])
                    {
                        Swap(printList,index,secondIndex, secondIndex - 1);
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
