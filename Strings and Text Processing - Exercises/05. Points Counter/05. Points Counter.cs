using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Points_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Result")
            {
                string[] inputToken = input.Split('|');
                int score = int.Parse(inputToken[2]);
                for (int i = 0; i < inputToken.Length; i++)
                {
                    inputToken[i] = inputToken[i].Replace("@", "");
                    inputToken[i] = inputToken[i].Replace("$", "");
                    inputToken[i] = inputToken[i].Replace("*", "");
                    inputToken[i] = inputToken[i].Replace("%", "");              
                }
                if (IsCapitalLetters(inputToken[0]))
                {
                    if (!data.ContainsKey(inputToken[0]))
                    {
                        data.Add(inputToken[0], new Dictionary<string, int>());
                    }
                    data[inputToken[0]][inputToken[1]] = int.Parse(inputToken[2]);
                }
                else
                {
                    if (!data.ContainsKey(inputToken[1]))
                    {
                        data.Add(inputToken[1], new Dictionary<string, int>());
                    }                 
                    data[inputToken[1]][inputToken[0]] = int.Parse(inputToken[2]);
                }              
                input = Console.ReadLine();
            }
            foreach (var item in data.OrderByDescending(d => d.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} => {item.Value.Values.Sum()}");                           
                Dictionary<string, int> players = item.Value.OrderByDescending(p => p.Value)
                                                  .Take(1)
                                                  .ToDictionary(p => p.Key,p=> p.Value);
                foreach (var player in players)
                {                                   
                    Console.WriteLine($"Most points scored by {player.Key}");
                }           
            }
        }
        private static bool IsCapitalLetters(string inputToken)
        {
            for (int i = 0; i < inputToken.Length; i++)
            {
                if (inputToken[i] < 65 || inputToken[i] > 90)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
