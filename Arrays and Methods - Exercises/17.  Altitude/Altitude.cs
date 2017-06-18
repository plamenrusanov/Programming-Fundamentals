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
            string[] pilot = Console.ReadLine().Split(' ');

            int altitude = int.Parse(pilot[0]);
            int currentNum = 0;
            bool upDown = true;
            for (int i = 1; i < pilot.Length; i++)
            {
                if (i % 2 == 0)
                {
                    currentNum = int.Parse(pilot[i]);
                    if (upDown)
                    {
                        altitude += currentNum;
                    }
                    else
                    {
                        altitude -= currentNum;
                    }
                }
                if (pilot[i] == "up")
                {
                    upDown = true;
                }
                else if (pilot[i] == "down")
                {
                    upDown = false;
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
