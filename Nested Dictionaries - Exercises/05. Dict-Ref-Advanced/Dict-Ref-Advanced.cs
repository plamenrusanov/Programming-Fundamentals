using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<int>>();
            string[] inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            while (inputTokens[0] != "end")
            {
                string name = inputTokens[0];
                List<int> inputNumbers = new List<int>();             
                if (IsName(inputTokens[1]) && data.ContainsKey(inputTokens[1]))
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<int>());
                    }
                    string otherName = inputTokens[1];
                    if (data.ContainsKey(otherName))
                    {
                        data[name].Clear();
                        data[name].AddRange(data[otherName]);
                    }                 
                }
                else if(!IsName(inputTokens[1]))
                {
                    inputNumbers = inputTokens[1].Split(new char[] { ' ', ',' },
                                   StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<int>());
                    }
                    data[name].AddRange(inputNumbers);
                }
               
                inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in data)
            {
                string name = item.Key;
                List<int> numbers = item.Value;
                Console.WriteLine($"{name} === {string.Join(", ",numbers)}");
            }
        }
        static bool IsName (string str)
        {
            foreach (var ch in str)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
