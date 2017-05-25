using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", km * 1.60934);
        }
    }
}
