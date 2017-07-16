using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel_Company
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string,Dictionary<string, int>>();

            string[] inputTokens = Console.ReadLine().Split(':');
            while (!"ready".Equals(inputTokens[0]))
            {
                string sity = inputTokens[0];
                List<string> temp = inputTokens[1].Split(new char[] { ',' }).ToList();
                if (!data.ContainsKey(sity))
                {
                    data.Add(sity, new Dictionary<string, int>());
                }
                foreach (string item in temp)
                {
                    string[] vehicle = item.Split('-');
                    if (!data[sity].ContainsKey(vehicle[0]))
                    {
                        data[sity].Add(vehicle[0], 0);

                    }
                    string Vehicle = vehicle[0];
                    data[sity][Vehicle] = int.Parse(vehicle[1]);
                }
                inputTokens = Console.ReadLine().Split(':');
            }                   
            inputTokens = Console.ReadLine().Split(' ');
            var groups = new Dictionary<string, int>();
            while (!"travel".Equals(inputTokens[0]))
            {
                string sity = inputTokens[0];
                int groupCapacity = int.Parse(inputTokens[1]);
                if (!groups.ContainsKey(sity))
                {
                    groups.Add(sity, 0);
                }                                                 
                groups[sity] = groupCapacity;                                        
                inputTokens = Console.ReadLine().Split(' ');
            }
            foreach (KeyValuePair<string, int> group in groups)
            {
                string groupSity = group.Key;
                int groupCapacity = group.Value;
                foreach (KeyValuePair<string, Dictionary<string, int>> item in data)
                {
                    string sity = item.Key;
                    Dictionary<string, int> sumOfTransport = item.Value;
                    int capacity = 0;
                    foreach (KeyValuePair<string, int> sumTrans in sumOfTransport)
                    {
                        capacity += sumTrans.Value;
                    }                
                    if (sity == groupSity && capacity >= groupCapacity)
                    {
                        Console.WriteLine($"{sity} -> all {groupCapacity} accommodated");
                    }
                    else if (sity == groupSity && capacity < groupCapacity)
                    {
                        Console.WriteLine($"{sity} -> all except {groupCapacity - capacity} accommodated");
                    }
                }              
            }
        }
    }
}
