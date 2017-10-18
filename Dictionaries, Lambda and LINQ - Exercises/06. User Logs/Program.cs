using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens = input.Split(new char[] { ' ', '=' },StringSplitOptions.RemoveEmptyEntries);
                string ip = inputTokens[1];
                string user = inputTokens[inputTokens.Length -1];
                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }
                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 1);
                }
                else
                {
                    userLogs[user][ip]++;
                }
                input = Console.ReadLine();
            }
            foreach (var item in userLogs)
            {
                Console.WriteLine($"{item.Key}:");
                var ip = item.Value;
                int countIp = 0;
                foreach (var kvp in ip)
                {
                    Console.Write($"{kvp.Key} => {kvp.Value}");                 
                    if (countIp == ip.Count -1)
                    {
                        Console.WriteLine(".");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    countIp++;
                }
            }
        }
    }
}
