using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {           
            var data2 = new Dictionary<int, string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputToken = input.Split(':');
                string letter = inputToken[0];
                List<int> positions = inputToken[1].Split('/').Select(int.Parse).ToList();
                foreach (var item in positions)
                {
                    if (!data2.ContainsKey(item))
                    {
                        data2.Add(item, letter);
                    }
                }                   
                input = Console.ReadLine();
            }
            StringBuilder result = new StringBuilder();            
            foreach (var item in data2.OrderBy(d => d.Key))
            {
                result.Append(item.Value);
            }          
            Console.WriteLine(result);
        }
    }
}
