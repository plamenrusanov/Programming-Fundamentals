using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double prBanana = double.Parse(Console.ReadLine());
            double prEgg = double.Parse(Console.ReadLine());
            double prBerries = double.Parse(Console.ReadLine());

            double portions = Math.Ceiling(guests / 6.0);
            double pricePerPortions = (2 * prBanana) + (4 * prEgg) + (0.2 * prBerries);
            double totalPrice = portions * pricePerPortions;
            if (totalPrice > budget)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - budget):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
