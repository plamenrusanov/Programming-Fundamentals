using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
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
                if (!miner.ContainsKey(resource))
                {
                    miner.Add(resource, count);
                }
                else
                {
                    miner[resource] += count;
                }
                resource = Console.ReadLine();            
            }
            foreach (var item in miner)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
