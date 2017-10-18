using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Dictionary<string, long>();
            string resource = Console.ReadLine();
            long count;
            while (resource != "stop")
            {
                count = long.Parse(Console.ReadLine());
                if (miner.ContainsKey(resource))
                {
                    miner[resource] += count;
                }
                else
                {
                    miner.Add(resource, count);
                  
                }
                resource = Console.ReadLine();
            }
            foreach (var item in miner)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
            Dictionary<Dictionary<string, int>, Dictionary<string, int>> countryStats =
new Dictionary<Dictionary<string, int>, Dictionary<string, int>>();
        }
    }
}
