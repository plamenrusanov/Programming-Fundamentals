using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealt = 100;
            int goshoHealt = 100;
            int count = 0;

            do
            {
                count++;
                if (count % 2 == 1)
                {
                    goshoHealt -= peshoDamage;
                    if (goshoHealt <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealt} health.");
                }
                else
                {
                    peshoHealt -= goshoDamage;
                    if (peshoHealt <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealt} health.");
                }
                if (count % 3 == 0)
                {
                    peshoHealt += 10;
                    goshoHealt += 10;
                }

            } while (true);
            if (peshoHealt > 0)
            {
                Console.WriteLine($"Pesho won in {count}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {count}th round.");
            }
        }
    }
}
