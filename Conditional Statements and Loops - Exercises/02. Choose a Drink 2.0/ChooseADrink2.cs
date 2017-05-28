using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            int quantities = int.Parse(Console.ReadLine());

            switch (profesion)
            {

                case "Athlete":
                    Console.WriteLine("The Athlete has to pay {0:f2}.", quantities * 0.7); break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profesion} has to pay {quantities * 1:f2}."); break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profesion} has to pay {quantities * 1.7:f2}."); break;
                default:
                    Console.WriteLine($"The {profesion} has to pay {quantities * 1.2:f2}.");
                    break;
            }
        }
    }
}
