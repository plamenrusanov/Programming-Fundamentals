using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01.Register_Users
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, DateTime>();
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);        
            while (input[0] != "end")
            {
                string name = input[0];
                DateTime timeRegistry = DateTime.ParseExact(input[1], "dd/MM/yyyy",provider: CultureInfo.InvariantCulture);
                if (data.Count < 5)
                {
                    data.Add(name, timeRegistry);
                }
                else
                {
                    foreach (KeyValuePair<string, DateTime> item in data)
                    {
                        DateTime minValue = item.Value;
                        if (timeRegistry < minValue && !data.ContainsKey(name))
                        {
                            data = data.Select(n => n = new KeyValuePair<string, DateTime> (name, timeRegistry)).ToDictionary(key => name, value => timeRegistry);
                        }
                    }
                }
               
                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);              
            }
            data = data.OrderBy(c => c.Value)
            .ThenBy(d => d.Key.Length)
           // .Take(5)
           // .Reverse()
            .ToDictionary(key => key.Key, value => value.Value);
            foreach (var item in data.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }     
    }
}
