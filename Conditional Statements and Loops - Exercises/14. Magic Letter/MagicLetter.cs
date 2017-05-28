using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());

            for (char i1 = firstLetter; i1 <= secondLetter; i1++)
            {
                if (i1 != magicLetter)
                {
                    for (char i2 = firstLetter; i2 <= secondLetter; i2++)
                    {
                        if (i2 != magicLetter)
                        {
                            for (char i3 = firstLetter; i3 <= secondLetter; i3++)
                            {
                                if (i3 != magicLetter)
                                {
                                    Console.Write($"{i1}{i2}{i3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
