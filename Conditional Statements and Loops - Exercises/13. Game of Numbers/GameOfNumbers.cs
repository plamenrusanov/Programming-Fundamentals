using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            int secodNumber = 0;
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;
                    if (i + j == magicNumber)
                    {
                        firstNumber = i;
                        secodNumber = j;
                    }
                }
            }
            if (firstNumber != 0 && secodNumber != 0)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secodNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
