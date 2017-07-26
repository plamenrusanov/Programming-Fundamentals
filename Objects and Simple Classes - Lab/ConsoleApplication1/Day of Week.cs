using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", provider: CultureInfo.InvariantCulture);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
