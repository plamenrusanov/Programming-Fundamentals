using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_Formations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
            {
                if (sideA * sideA + sideB * sideB == sideC * sideC)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (sideA * sideA == sideB * sideB + sideC * sideC)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (sideB * sideB == sideA * sideA + sideC * sideC)
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }

        }
    }
}
