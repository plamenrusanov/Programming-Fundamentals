using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Real_Numbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberCount = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (!numberCount.ContainsKey(inputNumbers[i]))
                {

                    numberCount.Add(inputNumbers[i],0);
                }
                numberCount[inputNumbers[i]]++;
            }

            foreach (double number in numberCount.Keys)
            {
                Console.WriteLine($"{number} -> {numberCount[number]}");
            }
            foreach (KeyValuePair<double, int> number in numberCount.OrderByDescending(e => e.Value))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
