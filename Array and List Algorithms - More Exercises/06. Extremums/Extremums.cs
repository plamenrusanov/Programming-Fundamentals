using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extremums
{
    class Extremums
    {
        static List<string> List = new List<string>();
        static void Main(string[] args)
        {
            List = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine().ToLower();
            int minSum = 0;
            int maxSum = 0;
            List<int> PrintList = new List<int>();

            for (int i = 0; i < List.Count; i++)
            {
                
                if (command == "min")
                {
                    minSum += Min(i);
                    PrintList.Add(Min(i));
                }
                else if (command == "max")
                {
                    maxSum += Max(i);
                    PrintList.Add(Max(i));
                }
            }
            Console.WriteLine(string.Join(", ",PrintList));
            if (minSum != 0)
            {
                Console.WriteLine(minSum);
            }
            else
            {
                Console.WriteLine(maxSum);
            }
        }
        static int Min(int index)
        {
            int min = int.MaxValue;
            List<char> Temp = new List<char>(List[index]);
            for (int i = 0; i < Temp.Count; i++)
            {
                char temp = Temp[0];
                Temp.RemoveAt(0);
                Temp.Add(temp);
                string abv = string.Join("", Temp);
                int num = int.Parse(abv);
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
        static int Max(int index)
        {
            int max = int.MinValue;
            List<char> Temp = new List<char>(List[index]);
            for (int i = 0; i < Temp.Count; i++)
            {
                char temp = Temp[0];
                Temp.RemoveAt(0);
                Temp.Add(temp);
                string abv = string.Join("", Temp);
                int num = int.Parse(abv);
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
