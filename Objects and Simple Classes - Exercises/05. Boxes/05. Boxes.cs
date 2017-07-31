using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<Box> data = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                // data.Add(new Box(input));
                Box temp = new Box(input);
                Console.WriteLine($"Box: {Box.Width}, {Box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(Box.Width, Box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(Box.Width, Box.Height)}");
                input = Console.ReadLine();
            }          
        }     
    }
    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }
        static public int Width { get; set; }
        static public int Height { get; set; }
        public Box(string input)
        {
            string[] inputToken = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            UpperLeft = new Point(inputToken[0]);
            UpperRight = new Point(inputToken[1]);
            BottomLeft = new Point(inputToken[2]);
            BottomRight = new Point(inputToken[3]);
            Width = (int)Point.CalcDistance(UpperLeft, UpperRight);
            Height = (int)Point.CalcDistance(UpperLeft,BottomLeft);
        }
        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }
        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(string inputToken)
        {
            int[] coord = inputToken.Split(':').Select(int.Parse).ToArray();
            X = coord[0];
            Y = coord[1];
        }
      
        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);
            return Math.Sqrt(sideA + sideB);
        }
      
    }
}
