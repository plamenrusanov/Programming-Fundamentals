using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] pilot = Console.ReadLine().Split(' ').ToArray();

            double altitude = double.Parse(pilot[0]);
            double currentNum = 0;
            int upDown = 0;
            for (int i = 1; i < pilot.Length; i++)
            {
                if (i % 2 == 0)
                {
                    currentNum = double.Parse(pilot[i]);
                    switch (upDown)
                    {
                        case 1: altitude += currentNum;break;
                        case 2: altitude -= currentNum;break;
                    }                
                }
                else if (i % 2 != 0)
                {
                    switch (pilot[i])
                    {
                        case "up": upDown = 1; break;
                        case "down": upDown = 2; break;
                    }
                }
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}
