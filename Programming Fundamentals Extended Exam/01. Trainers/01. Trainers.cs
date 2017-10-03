using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                decimal distanceM = decimal.Parse(Console.ReadLine());
                decimal ton = decimal.Parse(Console.ReadLine());
                decimal distance = distanceM * 1600m;
                decimal kilograms = ton * 1000;
                string team = Console.ReadLine().ToLower().Trim();
                decimal fuelEx = 0.7m * distance * 2.5m;
                decimal cargoKilogram = 1.5m * kilograms;
                decimal result = cargoKilogram - fuelEx;                     
                if (!data.ContainsKey(team))
                {
                    data.Add(team,0);
                }
                data[team] += result;
            }
            data = data.OrderByDescending(d => d.Value).Take(1).ToDictionary(d => d.Key, d => d.Value);
            if (data.ContainsKey("technical"))
            {              
                Console.WriteLine($"The Technical Trainers win with ${data["technical"]:f3}.");
            }
            else if (data.ContainsKey("practical"))
            {
                Console.WriteLine($"The Practical Trainers win with ${data["practical"]:f3}.");
            }
            else if (data.ContainsKey("theoretical"))
            {
                Console.WriteLine($"The Theoretical Trainers win with ${data["theoretical"]:f3}.");
            }
        }
    }
}

