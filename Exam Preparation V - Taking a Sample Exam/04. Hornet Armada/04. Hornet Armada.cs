using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, long>>();
            var activity = new SortedDictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] inputToken = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(inputToken[0]);
                string legionName = inputToken[1];
                string soldierType = inputToken[2];
                long soldierCount = long.Parse(inputToken[3]);
                if (!data.ContainsKey(legionName))
                {
                    data.Add(legionName, new Dictionary<string, long>());
                }
                if (!data[legionName].ContainsKey(soldierType))
                {
                    data[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    data[legionName][soldierType] += soldierCount;
                }
                if (!activity.ContainsKey(legionName))
                {
                    activity.Add(legionName, lastActivity);
                }
                else
                {
                    if (activity[legionName] < lastActivity)
                    {
                        activity[legionName] = lastActivity;
                    }
                }
            }
            string[] filter = Console.ReadLine().Split('\\');                    
            if (filter.Length == 1)
            {
                string soldType = filter[0];
                foreach (KeyValuePair<string, int> act in activity.OrderByDescending(a => a.Value))
                {
                    if (data[act.Key].ContainsKey(soldType))
                    {
                        Console.WriteLine($"{act.Value} : {act.Key}");
                    }
                }
            }
            else
            {
                int maxActivity = int.Parse(filter[0]);
                string soldType = filter[1];              
                foreach (var legion in data.Where(l => l.Value.ContainsKey(soldType)).OrderByDescending(s => s.Value[soldType]))
                {
                    if (activity[legion.Key] < maxActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[soldType]}");
                    }                                           
                }
            }
        }     
    }
}
