using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_Search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split().Select(int.Parse).ToList();
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            int countSteps = 0;

            for (int i = 0; i < List.Count; i++)
            {
                count++;
                if (List[i] == magicNum)
                {
                    countSteps++;
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Linear search made {count} iterations");
                    break;
                }
            }
            if (countSteps == 0)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {count} iterations");
            }
            List.Sort();
            countSteps = 0;
            int min = 0;
            int max = List.Count -1;
            while (true)
            {
                int number =( min + max) / 2;
                countSteps++;
                if (List[number] == magicNum)
                {
                    Console.WriteLine("Binary search made {0} iterations", countSteps);
                    break; 
                }
                else if (List[number] < magicNum)
                {
                    min = number+1;
                }
                else if (List[number] > magicNum)
                {
                    max = number-1;
                }
                if (max < min)
                {
                    Console.WriteLine("Binary search made {0} iterations", countSteps);
                    break;
                }
            }
        }
    }
}
