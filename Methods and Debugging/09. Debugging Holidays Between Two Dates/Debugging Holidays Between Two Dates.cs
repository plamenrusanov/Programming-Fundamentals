﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _09.Debugging_Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
