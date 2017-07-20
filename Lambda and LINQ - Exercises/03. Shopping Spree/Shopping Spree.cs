using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            var data = new Dictionary<string, decimal>();
            while (input[0] != "end")
            {
                string product = input[0];
                decimal price = decimal.Parse(input[1]);
                if (!data.ContainsKey(product))
                {
                    data.Add(product, price);
                }
                else if (price < data[product])
                {
                    data[product] = price;
                }
                input = Console.ReadLine().Split();
            }
            decimal sumOfProducts = data.Values.Sum();
            if (sumOfProducts <= budget)
            {
                foreach (var item in data.OrderByDescending(n => n.Value).ThenBy(n => n.Key.Length))
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:f2}");
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
        }
    }
}
