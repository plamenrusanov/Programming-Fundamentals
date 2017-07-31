using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] simbols = Console.ReadLine().Split();
            char charSimbol = char.Parse(simbols[0]);
            int positionSimbol = int.Parse(simbols[1]);
            int index = text.IndexOf(charSimbol);       
            int occurrences = 0;
            while (index != -1)
            {
                index = text.IndexOf(charSimbol, index);
                occurrences++;
                if (occurrences == positionSimbol && index != -1)
                {
                    Console.WriteLine(index);
                    return;
                }
                else if (index == -1)
                {
                    Console.WriteLine("Find the letter yourself!");
                    return;
                }
                index++;
            }
        }
    }
}
