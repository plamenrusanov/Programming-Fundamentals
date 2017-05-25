using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int gSugar = int.Parse(Console.ReadLine());

            double newKcal = (ml / 100.0) * kcal;
            double sugar = (ml / 100.0) * gSugar;

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", ml, name, newKcal, sugar);
        }
    }
}
