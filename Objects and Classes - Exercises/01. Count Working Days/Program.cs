using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holiday = new DateTime[11];
            {
                holiday[0] = new DateTime(2000, 01, 01);
                holiday[1] = new DateTime(2000, 03, 03);
                holiday[2] = new DateTime(2000, 05, 01);
                holiday[3] = new DateTime(2000, 05, 06);
                holiday[4] = new DateTime(2000, 05, 24);
                holiday[5] = new DateTime(2000, 09, 06);
                holiday[6] = new DateTime(2000, 09, 22);
                holiday[7] = new DateTime(2000, 11, 01);
                holiday[8] = new DateTime(2000, 12, 24);
                holiday[9] = new DateTime(2000, 12, 25);
                holiday[10] = new DateTime(2000, 12, 26);
            }
            int workingDays = 0;
            for (DateTime i = startDay; i <= endDay; i = i.AddDays(1))
            {
                var day = i.DayOfWeek;
                DateTime temp = new DateTime(2000, i.Month, i.Day);
                if (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday) && !holiday.Contains(temp))
                {
                    workingDays++;
                }
            }
            Console.WriteLine(workingDays);
        }
    }
}
