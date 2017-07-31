using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Dictionary<string, double>();
            var cast = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Shop is open")
            {
                string[] inputToken = input.Split();
                shop.Add(inputToken[0], double.Parse(inputToken[1]));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            List<string> products = new List<string>();
            while (input != "Print")
            {
                if (input == "Discount")
                {
                     var discountedProducts = shop
                        .OrderByDescending(pd => pd.Value)
                        .Take(3)
                        .Select(pd => 
                            new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9));
                    foreach (var discountedProduct in discountedProducts)
                    {
                        shop[discountedProduct.Key] = discountedProduct.Value;
                    }
                }
                else
                {
                    string[] inputToken = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    string name = inputToken[0];
                    products = inputToken[1].Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (!cast.ContainsKey(name))
                    {
                        cast.Add(name, new List<string>());
                    }
                    for (int i = 0; i < products.Count; i++)
                    {
                        cast[name].Add(products[i]);
                    }               
                }
                input = Console.ReadLine();
            }
            var castum = cast.OrderByDescending(c => c.Value.Sum(p => shop[p])).First();              
            Console.WriteLine($"Biggest spender: {castum.Key}");
            Console.WriteLine("^Products bought:");
            foreach (var item in castum.Value.Distinct().OrderByDescending(p => shop[p]))
            {
                Console.WriteLine($"^^^{item}: {shop[item]:f2}");
            }
            double total = castum.Value.Sum(p => shop[p]);
            Console.WriteLine($"Total: {total:f2}");                    
        }    
    }   
}
