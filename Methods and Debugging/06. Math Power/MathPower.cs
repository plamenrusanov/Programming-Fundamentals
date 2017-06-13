using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class MathPower
    {
        static double RaiceToPower(double number,double power)
        {
            double result = Math.Pow(number, power);
                return result;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiceToPower(number,power));
        }
    }
}
