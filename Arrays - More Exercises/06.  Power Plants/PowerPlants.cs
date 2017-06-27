using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
    class PowerPlants
    {
        static bool IsPlantAreAlives(int[] inputNum)
        {
            for (int i = 0; i < inputNum.Length; i++)
            {
                if (inputNum[i] > 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {          
            int[] inputNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int days = 0;
            int seasons = 0;

            while (IsPlantAreAlives(inputNum))
            {
                for (int day = 0; day < inputNum.Length; day++)
                {
                    for (int plant = 0; plant < inputNum.Length; plant++)
                    {
                        if (inputNum[plant] > 0)
                        {
                            inputNum[plant]--;
                            if (day == plant)
                            {
                                inputNum[plant]++;
                            }
                        }                      
                    }
                    days++;
                    if (!IsPlantAreAlives(inputNum))
                    {
                        Console.WriteLine($"survived {days} days ({seasons} seasons)");
                        return;
                    }
                }
                seasons++;
                for (int i = 0; i < inputNum.Length; i++)
                {
                    if (inputNum[i] > 0)
                    {
                        inputNum[i]++;
                    }
                }
            }
        }
    }
}
