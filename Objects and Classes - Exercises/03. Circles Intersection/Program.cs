using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] circle1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] circle2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double x1 = circle1[0];
            double y1 = circle1[1];
            double r1 = circle1[2];
            double x2 = circle2[0];
            double y2 = circle2[1];
            double r2 = circle2[2];

            double distance = Distance(x1, y1, x2, y2);
            if (distance <= r1 + r2)
            {
                Console.WriteLine("Yes");
              
            }
            else
            {
                Console.WriteLine("No");
              
            }
            //Console.WriteLine(distance);
        }

        private static double Distance(double x1, double y1, double x2, double y2)
        {

            return Math.Sqrt( Math.Pow(x1, 2) + Math.Pow(y2, 2));
            //throw new NotImplementedException();
        }
    }
}
