using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            string[] inpTokens;
            string ip;
            string user;
            int duration;
            for (int i = 0; i < n; i++)
            {
                inpTokens = Console.ReadLine().Split(' ');
                ip = inpTokens[0];
                user = inpTokens[1];
                duration = int.Parse(inpTokens[2]);
                if (!data.ContainsKey(user))
                {
                    data.Add(user, new Dictionary<string, int>());
                }
                if (!data[user].ContainsKey(ip))
                {
                    data[user].Add(ip, duration);
                }
                else
                {
                    data[user][ip] += duration;
                }
            }
            foreach (var item in data.OrderBy(i => i.Key))
            {
                Console.Write($"{item.Key}: {item.Value.Values.Sum()} [");
                int count = 0;
                foreach (var kvp in item.Value.OrderBy(k => k.Key))
                {
                    Console.Write($"{kvp.Key}");
                    if (count != item.Value.Count -1)
                    {
                        Console.Write(", ");
                    }
                    count++;
                }
                Console.WriteLine("]");
            }
        }
    }
}
