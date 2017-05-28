using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine().ToLower();

            switch (profesion)
            {

                case "athlete":
                    Console.WriteLine("Water"); break;
                case "businessman":
                case "businesswoman":
                    Console.WriteLine("Coffee"); break;
                case "softuni student":
                    Console.WriteLine("Beer"); break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
