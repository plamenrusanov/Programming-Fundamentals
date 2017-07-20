using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "stop the game")
            {
                string[] inputTokens = input.Split('|').ToArray();
                string name = inputTokens[0];
                string team = inputTokens[1];
                int point = int.Parse(inputTokens[2]);
                if (!data.ContainsKey(team))
                {
                    data.Add(team, new Dictionary<string, int>());
                }
                if (data[team].Count < 3)
                {
                    data[team].Add(name, point);
                }               
                input = Console.ReadLine();
            }
            data = data.Where(n => n.Value.Count == 3).ToDictionary(key => key.Key, value => value.Value);
            int count = 1;
            foreach (var item in data.OrderByDescending(n => n.Value.Values.Sum()))
            {             
                string team = item.Key;
                Dictionary<string, int> persons = item.Value;             
                 Console.WriteLine($"{count}. {team}; Players:");
                count++;
                foreach (var person in persons.OrderByDescending(n => n.Value))
                {
                    string name = person.Key;
                    int point = person.Value;
                    Console.WriteLine($"###{name}: {point}");
                }
            }
        }
    }
}
