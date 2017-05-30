using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            hours += minutes / 60;
            minutes = minutes % 60;
            hours = hours >= 24 ? 0 : hours;
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
