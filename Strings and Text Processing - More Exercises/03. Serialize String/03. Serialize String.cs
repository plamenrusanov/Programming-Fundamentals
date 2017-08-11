using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new  Dictionary<char, List<int>>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!data.ContainsKey(input[i]))
                {
                    data.Add(input[i], new List<int>());
                }
                data[input[i]].Add(i);
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}:"+string.Join("/",item.Value));
            }
        }
    }
}
