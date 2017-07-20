using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new Dictionary<string, string>();
            var nullData = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(new string[] { " -> " },
                             StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "end")
            {
                string key = input[0];
                string value = input[1];
                if (value != "null")
                {
                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, "");
                    }
                    data[key] = input[1];
                }
                else
                {
                    if (!nullData.ContainsKey(key))
                    {
                        nullData.Add(key, "");
                    }
                    nullData[key] = input[1];
                }
                input = Console.ReadLine().Split(new string[] { " -> " },
                           StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            string defValue = Console.ReadLine();
            foreach (var item in data.OrderByDescending(s => s.Value.Length))
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");

            }
            var newNull = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in nullData)
            {
                newNull.Add(item.Key, defValue);
            }
            foreach (var item in newNull)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
