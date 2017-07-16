using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01.Sino_The_Walker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            List<int> leavingTime = Console.ReadLine().Split(':').Select(int.Parse).ToList();
            int steps = int.Parse(Console.ReadLine());
            int timeForStep = int.Parse(Console.ReadLine());
            if (leavingTime.Count > 3)
            {
                leavingTime = leavingTime.Skip(leavingTime.Count - 3).Take(3).ToList();
            }
            int seconds = (leavingTime[2] + (steps * timeForStep) % 60) % 60; 
            int minutes = (leavingTime[1] + (steps * timeForStep) / 60 +
                ((leavingTime[2] + (steps * timeForStep) % 60) / 60)) % 60;
            int hours = leavingTime[0] + (leavingTime[1] + (steps * timeForStep) / 60 +
                ((leavingTime[2] + (steps * timeForStep) % 60) / 60)) / 60;
            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", hours % 24, minutes, seconds);
        }
    }
}
