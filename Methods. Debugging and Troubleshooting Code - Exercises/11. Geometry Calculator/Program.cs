using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double result = 0;
            switch (figureType)
            {
                case "triangle":
                    result = Triangle();
                    break;
                case "square":
                    result = Square();
                    break;
                case "rectangle":
                    result = Rectangle();
                    break;
                case "circle":
                    result = Circle();
                    break;
            }
            Console.WriteLine($"{Math.Round(result, 2):f2}");
        }

        private static double Circle()
        {
            double radius = double.Parse(Console.ReadLine());
             return Math.PI * Math.Pow(radius, 2);
        }

        private static double Rectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return width * height;
        }

        private static double Square()
        {
            double side = double.Parse(Console.ReadLine());
            return Math.Pow(side, 2);
        }

        private static double Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return (side * height) / 2; 
        }
    }
}
