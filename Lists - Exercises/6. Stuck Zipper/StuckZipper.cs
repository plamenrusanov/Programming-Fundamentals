using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stuck_Zipper
{
    class StuckZipper
    {
        static int minDigit = int.MaxValue;
        static List<int> firstList = new List<int>();
        static List<int> secondList = new List<int>();
        static int MinDigit()
        {
            int number = 0;
            int digit = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                number = Math.Abs(firstList[i]);
                digit = number.ToString().Length;
                if (minDigit > digit)
                {
                    minDigit = digit;
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                number = Math.Abs(secondList[i]);
                digit = number.ToString().Length;
                if (minDigit > digit)
                {
                    minDigit = digit;
                }
            }
            return minDigit;
        }     
        static int CurrentDigit(List<int>List,int index)
        {
            int number = Math.Abs(List[index]);
            int digit = number.ToString().Length;
            return digit;
        }
        static void Main(string[] args)
        {
            firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            MinDigit();
            for (int cnt = 1; cnt <= firstList.Count; cnt++)
            {
                if (minDigit < CurrentDigit(firstList,cnt-1))
                {
                    firstList.RemoveAt(cnt-1);
                    cnt--;
                }            
            }
            for (int cnt = 1; cnt <= secondList.Count; cnt++)
            {
                if (minDigit < CurrentDigit(secondList,cnt-1))
                {
                    secondList.RemoveAt(cnt-1);
                    cnt--;
                }           
            }
            List<int> PrintList = new List<int>();
            for (int i = 0; i < (firstList.Count+secondList.Count); i++)
            {
                if (i <= secondList.Count-1 )
                {
                     PrintList.Add(secondList[i]);
                }
                if( i <= firstList.Count-1 )
                {
                    PrintList.Add(firstList[i]);
                }
            }
            Console.WriteLine(string.Join(" ",PrintList));
        }
    }
}
