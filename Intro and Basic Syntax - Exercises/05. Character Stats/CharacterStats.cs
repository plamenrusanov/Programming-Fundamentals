using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealt = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', maxHealt - currentHealth));
            Console.WriteLine("|");

            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maxEnergy - currentEnergy));
            Console.WriteLine("|");
        }
    }
}
