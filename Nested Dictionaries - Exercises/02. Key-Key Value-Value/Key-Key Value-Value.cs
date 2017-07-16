using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchKey = Console.ReadLine();
            string searchValue = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            var result =new Dictionary<string, List< string >> ();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string inputKey = input[0];
                List<string> inputValue = input[1].Split(new char[] {' ', ';'},StringSplitOptions.RemoveEmptyEntries).ToList();
                if (inputKey.Contains(searchKey))
                {
                    result.Add(inputKey, new List<string>());
                    foreach (var item in inputValue)
                    {
                        if (item.Contains(searchValue))
                        {
                            result[inputKey].Add(item);
                        }
                    }
                }             
            }
            foreach (var item in result)
            {
                string key = item.Key;
                List<string> printList = item.Value;
                Console.WriteLine($"{key}:");
                foreach (var str in printList)
                {
                    Console.WriteLine($"-{str}");
                }
            }
        }
    }
}
