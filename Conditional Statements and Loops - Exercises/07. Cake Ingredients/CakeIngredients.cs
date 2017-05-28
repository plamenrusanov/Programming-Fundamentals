using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            int count = 0;
            string ingredient = null;
            do
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                    count++;
                }
            } while (ingredient != "Bake!");

            Console.WriteLine("Preparing cake with {0} ingredients.", count);
        }
    }
}
