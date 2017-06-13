using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static double TriangleArea(double wigth, double height)
        {
            return wigth * height / 2;
        }
        static void Main(string[] args)
        {
            double wigth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(wigth, height));
        }
    }
}
