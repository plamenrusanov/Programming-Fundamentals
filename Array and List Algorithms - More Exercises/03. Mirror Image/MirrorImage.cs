using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mirror_Image
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            List<string> List = Console.ReadLine().Split().ToList();
            var reverseNumber = Console.ReadLine();
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            do
            {
                if (reverseNumber == "Print")
                {
                    break;
                }
             
                int number = int.Parse(reverseNumber);
                //int index = 0;
                //for (int i = number-1; i >= 0; i--)
                //{
                //    PrintList.RemoveAt(index);
                //    PrintList.Insert(index,List[i]);
                //    index++;
                //}
                //PrintList.RemoveAt(index);
                //PrintList.Insert(index,List[number]);
                //index++;
                //for (int i = List.Count-1; i > number; i--)
                //{
                //    PrintList.RemoveAt(index);
                //    PrintList.Insert(index,List[i]);
                //    index++;
                //}
                for (int i = 0; i < List.Count; i++)
                {
                    if (i < number)
                    {
                        firstList.Add(List[i]);
                    }
                    else if (i > number)
                    {
                        secondList.Add(List[i]);
                    }                 
                }
                firstList.Reverse();
                firstList.Add(List[number]);
                secondList.Reverse();
                List.Clear();
                for (int i = 0; i < firstList.Count; i++)
                {
                    List.Add(firstList[i]);
                }
                for (int i = 0; i < secondList.Count; i++)
                {
                    List.Add(secondList[i]);
                }
                firstList.Clear();
                secondList.Clear();
                reverseNumber = Console.ReadLine();
            } while (true);
            Console.WriteLine(string.Join(" ",List));
        }
    }
}
