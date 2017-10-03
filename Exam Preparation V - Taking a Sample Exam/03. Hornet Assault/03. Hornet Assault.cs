using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> resultBee = new List<long>();
          
            for (int i = 0; i < beehives.Count; i++)
            {              
                long bee = beehives[i];
                long hornetPower = hornets.Sum();
                if (bee > hornetPower)
                {
                    beehives[i] = (bee - hornetPower);
                    //resultBee.Add(bee - hornetPower);
                    if (hornets.Count != 0)
                    {
                        hornets.RemoveAt(0);
                    }          
                }
                else if (bee == hornetPower)
                {
                    beehives[i] = 0;
                    if (hornets.Count != 0)
                    {
                        hornets.RemoveAt(0);
                    }              
                }
                else if (bee < hornetPower)
                {
                    beehives[i] = 0;
                }         
            }
            var beehi = beehives.Where(b => b != 0).ToList();
            if (beehi.Count != 0)
            {
                Console.WriteLine(string.Join(" ", beehi));
            }
            else           
            {
                Console.WriteLine(string.Join(" ", hornets));
            }         
        }
    }
}
