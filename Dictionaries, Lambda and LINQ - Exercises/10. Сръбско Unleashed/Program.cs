using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex (@"([A-Za-z]+[A-Za-z ]*)([ ]{1}[@]{1})([A-Za-z]+[A-Za-z ]*)([ ]{1})([0-9]+)([ ]{1})([0-9]+)");
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                
                if (pattern.IsMatch(input))
                {
                    Match m = pattern.Match(input);
                    string venue = m.Groups[3].Value;
                    string singer = m.Groups[1].Value;
                    long money = long.Parse(m.Groups[5].Value) * long.Parse(m.Groups[7].Value);
                    if (!data.ContainsKey(venue))
                    {
                        data.Add(venue, new Dictionary<string, long>());
                    }
                    if (!data[venue].ContainsKey(singer))
                    {
                        data[venue].Add(singer, money);
                    }
                    else
                    {
                        data[venue][singer] += money;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value.OrderByDescending(k => k.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
