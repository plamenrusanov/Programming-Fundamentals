using System;


namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double dis1 = Distance(x1, y1);
            double dis2 = Distance(x2, y2);
            if (dis1 <= dis2)
            {
                
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double Distance(double x1, double y1)
        {
            double distance = (Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return distance;
        }
    }
}
