using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = data.Average();
            data = data.Where(d => d >= average).ToList();
            string input = Console.ReadLine();
            if (input == "Min")
            {
                Console.WriteLine(data.Min());
            }
            if (input == "Max")
            {
                Console.WriteLine(data.Max());
            }
            else if (input == "All")
            {               
                Console.WriteLine(string.Join(" ",data.OrderBy(d => d)));
            }
        }
    }
}
