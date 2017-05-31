using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NewRestaurantDiscount
{
    class NewRestaurantDiscount
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower().Trim();

            double discount = 0.0;
            string hall = string.Empty;
            double price = 0.0;

            if (people <= 50)
            {
                hall = "Small Hall";
                price += 2500;
            }
            else if (people <= 100)
            {
                hall = "Terrace";
                price += 5000;
            }
            else if (people <= 120)
            {
                hall = "Great Hall";
                price += 7500;
            }
            if (package == "normal")
            {
                discount = 0.95;
                price += 500;
            }
            else if (package == "gold")
            {
                discount = 0.9;
                price += 750;
            }
            else if (package == "platinum")
            {
                discount = 0.85;
                price += 1000;
            }
            if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine("The price per person is {0:f2}$", (price * discount) / people);
            }

        }
    }
}
