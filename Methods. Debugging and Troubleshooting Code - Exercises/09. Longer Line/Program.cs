using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double distance1 = Distance(x1, y1, x2, y2);
            double distance2 = Distance(x3, y3, x4, y4);

            if (distance1 >= distance2)
            {
                PrintResult(x1, y1, x2, y2);
            }
            else
            {
                PrintResult(x3, y3, x4, y4);
            }
        }

        private static void PrintResult(double x1, double y1, double x2, double y2)
        {
            double distanceToPoint1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distanceToPoint2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (distanceToPoint1 <= distanceToPoint2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }

        private static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
        }
    }
}
