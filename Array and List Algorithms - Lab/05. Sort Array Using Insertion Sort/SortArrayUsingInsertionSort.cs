﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Array_Using_Insertion_Sort
{
    class SortArrayUsingInsertionSort
    {
        static List<int> firstNumList = new List<int>();
        static void Main(string[] args)
        {
            firstNumList = Console.ReadLine().Split().Select(int.Parse).ToList();
            InsetionSort();
            Console.WriteLine(string.Join(" ",firstNumList));
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
                    if (firstNumList[secondIndex] < firstNumList[secondIndex - 1])
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
