using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;
            switch (parameter)
            {
                case "face":
                    result = Face(side);break;
                case "space":
                    result = Space(side);break;
                case "volume":
                    result = Volume(side);break;
                case "area":
                    result = Area(side);break;
               
            }
            Console.WriteLine("{0:f2}", result);
        }

        private static double Area(double side)
        {
            return Math.Round(6 * Math.Pow(side, 2), 2);
        }

        private static double Volume(double side)
        {
            return Math.Round(Math.Pow(side, 3), 2);
        }

        private static double Space(double side)
        {
            return Math.Round(Math.Sqrt(3 * Math.Pow(side, 2)), 2);
        }

        private static double Face(double side)
        {
            return Math.Round(Math.Sqrt(2 * Math.Pow(side, 2)), 2);
           
        }
    }
}
