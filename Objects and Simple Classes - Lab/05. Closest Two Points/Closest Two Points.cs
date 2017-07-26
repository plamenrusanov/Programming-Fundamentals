using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParcePoint(Console.ReadLine());
                points.Add(currentPoint);
            }
            double minDistanse = double.MaxValue;
            Point[] bestPoints = new Point[2];

            for (int previusPoint = 0; previusPoint < points.Count; previusPoint++)
            {
                for (int currentPoint = previusPoint+1; currentPoint < points.Count; currentPoint++)
                {
                    double distance = CalcDistance(points[previusPoint], points[currentPoint]);
                    if (distance < minDistanse)
                    {
                        minDistanse = distance;
                        bestPoints[0] = points[previusPoint];
                        bestPoints[1] = points[currentPoint];
                    }
                }
            }
            Console.WriteLine($"{minDistanse:f3}");
            Console.WriteLine($"({bestPoints[0].X}, {bestPoints[0].Y})");
            Console.WriteLine($"({bestPoints[1].X}, {bestPoints[1].Y})");

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
        //public Point(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}
        public static Point ParcePoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();
            // return new Point(inputData[0], inputData[1]);
            return new Point
            {
                X = inputData[0],
                Y = inputData[1]
            };
        }
        //public override string ToString()
        //{
        //    return String.Format($"({X}, {Y})");
        //}
    }
}

