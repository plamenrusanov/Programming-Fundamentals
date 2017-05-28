using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            int night = 0;
            if (mount == "september" || mount == "october")
            {
                if (nights > 7)
                {
                    night = nights - 1;
                }
            }
            if (nights > 14)
            {
                if (mount == "may" || mount == "october")
                {

                    if (mount == "may")
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", (nights * 50) * 0.95);
                    }
                    else
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", (night * 50) * 0.95);
                    }
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
                else if (mount == "june" || mount == "september")
                {
                    if (mount == "june")
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    }
                    else
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", night * 60);
                    }
                    Console.WriteLine("Double: {0:f2} lv.", (nights * 72) * 0.9);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
                else if (mount == "july" || mount == "august" || mount == "december")
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", (nights * 89) * 0.85);
                }
            }
            else if (nights > 7)
            {
                if (mount == "may" || mount == "october")
                {
                    if (mount == "may")
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", (nights * 50) * 0.95);
                    }                  
                    else
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", (night * 50) * 0.95);
                    }
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
                else if (mount == "june" || mount == "september")
                {
                    if (mount == "june")
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    }
                    else
                    {
                        Console.WriteLine("Studio: {0:f2} lv.", night * 60);
                    }
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
                else if (mount == "july" || mount == "august" || mount == "december")
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 89);
                }
            }
            else
            {
                if (mount == "may" || mount == "october")
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
                else if (mount == "june" || mount == "september")
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
                else if (mount == "july" || mount == "august" || mount == "december")
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 89);
                }
            }
        }
    }
}
