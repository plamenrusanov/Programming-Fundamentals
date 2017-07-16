using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, HashSet<int>>();
            string[] inputTokens = Console.ReadLine().Split();
            while (inputTokens[0] != "Aggregate")
            {
                string regionShell = inputTokens[0];
                int shell = int.Parse(inputTokens[1]);
                if (!data.ContainsKey(regionShell))
                {
                    data.Add(regionShell, new HashSet<int>());
                }
                data[regionShell].Add(shell);
                inputTokens = Console.ReadLine().Split();
            }
            foreach (var item in data)
            {
                string regionShell = item.Key;
                HashSet<int> shells = item.Value;
                int average = shells.Sum() - (shells.Sum() / (shells.Count));
                Console.WriteLine($"{regionShell} -> {string.Join(", ",shells)} ({average})");
            }
        }
    }
}
