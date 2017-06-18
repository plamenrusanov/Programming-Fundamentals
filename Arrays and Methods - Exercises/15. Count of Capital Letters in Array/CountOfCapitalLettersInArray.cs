using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters_in_Array
{
    class CountOfCapitalLettersInArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1)
                {
                    int numOfLetter = arr[i][0];
                    if (numOfLetter >= 65 && numOfLetter <= 90)
                    {
                        count++;
                    }
                }              
            }
            Console.WriteLine(count);
        }
    }
}
