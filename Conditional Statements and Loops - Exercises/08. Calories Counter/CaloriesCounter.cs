using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int numOfIngredents = int.Parse(Console.ReadLine());

            int totalCalories = 0;

            for (int i = 0; i < numOfIngredents; i++)
            {
                string ingredent = Console.ReadLine().ToLower();

                switch (ingredent)
                {
                    case "cheese": totalCalories += 500; break;
                    case "tomato sauce": totalCalories += 150; break;
                    case "salami": totalCalories += 600; break;
                    case "pepper": totalCalories += 50; break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
