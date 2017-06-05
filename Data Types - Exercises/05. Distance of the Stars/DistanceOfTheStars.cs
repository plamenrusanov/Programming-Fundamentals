using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            decimal ly = 9.45E12m;
            decimal nearestStar = (4.22m * ly);
            decimal centerOfGalaxy = 26000m * ly;
            decimal diameterGalaxy = 100000m * ly;
            decimal universe = 46500000000m * ly;

            Console.WriteLine(nearestStar.ToString("e2"));
            Console.WriteLine(centerOfGalaxy.ToString("e2"));
            Console.WriteLine(diameterGalaxy.ToString("e2"));
            Console.WriteLine(universe.ToString("e2"));
        }
    }
}
