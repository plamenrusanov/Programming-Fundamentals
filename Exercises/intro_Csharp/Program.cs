﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {product}");
            Console.WriteLine($"Health: |{new string('|',currentHealth)}{new string('.',maxHealth - currentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}|");


        }
    }
}