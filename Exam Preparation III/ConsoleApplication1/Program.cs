using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\' },StringSplitOptions.RemoveEmptyEntries);
                string root = input[0];
                string[] tokens = input[input.Length - 1].Split(';');
                string file = tokens[0];
                long size = long.Parse(tokens[1]);
                if (!data.ContainsKey(root))
                {
                    data.Add(root, new Dictionary<string, long>());
                }
                if (!data[root].ContainsKey(file))
                {
                    data[root].Add(file, size);
                }
                data[root][file] = size;
            }
            string[] filter = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            string filterRoot = filter[2];
            string extension = filter[0];
            bool isFind = false;
            foreach (var item in data)
            {
                string root = item.Key;
                if (root == filterRoot)
                {
                    Dictionary<string, long> files = item.Value;
                    foreach (var file in files.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                    {
                        if (file.Key.EndsWith(extension))
                        {
                            Console.WriteLine($"{file.Key} - {file.Value} KB");
                            isFind = true;
                        }
                    }
                }
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            }
        }
    }
}
