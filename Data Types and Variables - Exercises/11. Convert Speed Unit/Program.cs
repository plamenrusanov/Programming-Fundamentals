using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float sec = (hours * 3600) + (minutes * 60) + seconds;
            float metersPerSecond = distanceMeters / sec;
            float kilometersPerHour = (distanceMeters / 1000) / (sec / 3600);
            float milesPerHour = (distanceMeters / 1609) / (sec / 3600);


            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
