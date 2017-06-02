using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount != 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");

                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

                }
                sum += itemCount * itemPrice;
            }
            Console.WriteLine($"Subtotal: ${sum:f2}");
            if (budget >= sum)
            {
                Console.WriteLine($"Money left: ${budget - sum:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${sum - budget:f2} more.");
            }
        }
    }
}

