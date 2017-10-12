using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> data = new Dictionary<int, int>();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (!data.ContainsKey(inputNumbers[i]))
                {
                    data.Add(inputNumbers[i], 1);
                }
                else
                {
                    data[inputNumbers[i]]++;
                }
            }
            foreach (var item in data.OrderByDescending(i => i.Value).Take(1))
            {
                Console.WriteLine(item.Key);
            }         
        }
    }    
}
