using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] tokens = input.Split('|');
                string country = tokens[1];
                string sity = tokens[0];
                long population = long.Parse(tokens[2]);
                if (!data.ContainsKey(country))
                {
                    data.Add(country, new Dictionary<string, long>());
                }
                if (!data[country].ContainsKey(sity))
                {
                    data[country].Add(sity, population);
                }
                input = Console.ReadLine();
            }
            foreach (var item in data.OrderByDescending(i => i.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
                foreach (var kvp in item.Value.OrderByDescending(k => k.Value))
                {
                    Console.WriteLine($"=>{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
