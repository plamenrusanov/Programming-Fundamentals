using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point point1 = new Point(5, 4);
            // Console.WriteLine(point1.X);
            Point firstPoint = Point.ParcePoint(Console.ReadLine());
            Point secondPoint = Point.ParcePoint(Console.ReadLine());
            double distance = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}",distance);
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);
            return Math.Sqrt(sideA + sideB);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Point ParcePoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();
            return new Point(inputData[0], inputData[1]);
        }
    }
}
