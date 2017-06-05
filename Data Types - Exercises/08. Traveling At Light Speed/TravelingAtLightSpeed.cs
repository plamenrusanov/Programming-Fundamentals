using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal ly = decimal.Parse(Console.ReadLine());

            decimal seconds = Math.Floor((9450000000000m * ly) / 300000m);

            decimal minutes = Math.Floor(seconds / 60);
            decimal hours = Math.Floor(minutes / 60);
            decimal days = Math.Floor(hours / 24);
            decimal weeks = Math.Floor(hours / 168);

            Console.WriteLine("{0:0} weeks", weeks);
            Console.WriteLine("{0:0} days", days % 7);
            Console.WriteLine("{0:0} hours", hours % 24);
            Console.WriteLine("{0:0} minutes", minutes % 60);
            Console.WriteLine("{0:0} seconds", seconds % 60);
        }
    }
}
