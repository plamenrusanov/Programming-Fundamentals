using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isFoundDiamond = false;
            int first = 0;
            for (;;)
            {
                int startIndex = input.IndexOf('<', first);
                if (startIndex < 0)
                {
                    break;
                }
                int lastIndex = input.IndexOf('>', startIndex);
                if (lastIndex < 0)
                {
                    break;
                }
                if (startIndex >= 0 && lastIndex >= 0)
                {
                    string diamond = input.Substring(startIndex, lastIndex - startIndex);
                    int carats = CountCarats(diamond);
                    Console.WriteLine($"Found {carats} carat diamond");
                    first = lastIndex;
                    isFoundDiamond = true;
                }                
            }
            if (!isFoundDiamond)
            {
                Console.WriteLine("Better luck next time");
            }                   
        }
        private static int CountCarats(string diamond)
        {
            int count = 0;
            for (int i = 0; i < diamond.Length; i++)
            {
                int num = diamond[i];
                if (num >= 48 && num <= 57)
                {
                    count += (num - 48);
                }
            }            
            return count;
        }
    }
}
