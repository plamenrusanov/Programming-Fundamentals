using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class DrawAFilledSquare
    {
        static void PrintHeadarRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMidlleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeadarRow(n);
            PrintMidlleRow(n);
            PrintHeadarRow(n);
        }
    }
}
