using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> data = new SortedDictionary<string, string>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    if (!data.ContainsKey(input[1]))
                    {
                        data.Add(input[1], input[2]);
                    }
                    else
                    {
                        data[input[1]] = input[2];
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in data)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                else
                {
                    if (data.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {data[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
