using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (groupSize <= 50)
            {
                if (package == "Normal")
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 500) * 0.95) / groupSize);

                }
                else if (package == "Gold")
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 750) * 0.9) / groupSize);
                }
                else
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 1000) * 0.85) / groupSize);
                }
            }
            else if (groupSize <= 100)
            {
                if (package == "Normal")
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 500) * 0.95) / groupSize);

                }
                else if (package == "Gold")
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 750) * 0.9) / groupSize);
                }
                else
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 1000) * 0.85) / groupSize);
                }
            }
            else if (groupSize <= 120)
            {
                if (package == "Normal")
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 500) * 0.95) / groupSize);

                }
                else if (package == "Gold")
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 750) * 0.9) / groupSize);
                }
                else
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 1000) * 0.85) / groupSize);
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
