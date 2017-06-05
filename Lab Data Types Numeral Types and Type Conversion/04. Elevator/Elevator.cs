using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = 24;

            Console.WriteLine("{0}", (int)Math.Ceiling((double)persons / capacity));
        }
    }
}
