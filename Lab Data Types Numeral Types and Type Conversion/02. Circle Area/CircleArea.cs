﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Circle_Area
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", Math.PI * r * 2);
        }
    }
}
