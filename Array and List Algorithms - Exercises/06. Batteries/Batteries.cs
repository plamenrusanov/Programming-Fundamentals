using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            List<double> CapacityBatteries = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> UsageBatteries = Console.ReadLine().Split().Select(double.Parse).ToList();
            int testHours = int.Parse(Console.ReadLine());
            List<double> PrintList = new List<double>();
            for (int i = 0; i < CapacityBatteries.Count; i++)
            {
                double restOfPower = CapacityBatteries[i];

                for (int hours = 1; hours <= testHours; hours++)
                {
                    restOfPower -= UsageBatteries[i];                 
                }
                PrintList.Add(restOfPower);
            }
            for (int i = 0; i < CapacityBatteries.Count; i++)
            {
                Console.Write($"Battery {i + 1}: ");
                if (PrintList[i] >= 0)
                {
                    Console.WriteLine("{0:f2} mAh ({1:f2})%",PrintList[i],(PrintList[i] / CapacityBatteries[i])*100);
                }
                else
                {
                    Console.WriteLine("dead (lasted {0} hours)",Math.Ceiling(CapacityBatteries[i] / UsageBatteries[i]));
                }
            }
        }
    }
}
