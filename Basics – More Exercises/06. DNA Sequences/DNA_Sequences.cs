using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class DNA_Sequences
    {
        static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;
            var firstSimbol = 0;
            var secondSimbol = 0;
            var thirdSimbol = 0;

            for (char n1 = 'A'; n1 <= 'T'; n1++)
            {
                if (n1 == 'A' || n1 == 'C' || n1 == 'G' || n1 == 'T')
                {
                    for (char n2 = 'A'; n2 <= 'T'; n2++)
                    {
                        if (n2 == 'A' || n2 == 'C' || n2 == 'G' || n2 == 'T')
                        {
                            for (char n3 = 'A'; n3 <= 'T'; n3++)
                            {
                                if (n3 == 'A' || n3 == 'C' || n3 == 'G' || n3 == 'T')
                                {
                                    count++;
                                    switch (n1)
                                    {
                                        case 'A': firstSimbol = 1; break;
                                        case 'C': firstSimbol = 2; break;
                                        case 'G': firstSimbol = 3; break;
                                        case 'T': firstSimbol = 4; break;
                                        default:
                                            break;
                                    }
                                    switch (n2)
                                    {
                                        case 'A': secondSimbol = 1; break;
                                        case 'C': secondSimbol = 2; break;
                                        case 'G': secondSimbol = 3; break;
                                        case 'T': secondSimbol = 4; break;
                                        default:
                                            break;
                                    }
                                    switch (n3)
                                    {
                                        case 'A': thirdSimbol = 1; break;
                                        case 'C': thirdSimbol = 2; break;
                                        case 'G': thirdSimbol = 3; break;
                                        case 'T': thirdSimbol = 4; break;
                                        default:
                                            break;
                                    }
                                    if (firstSimbol + secondSimbol + thirdSimbol >= magicNum)
                                    {
                                        Console.Write($"O{n1}{n2}{n3}O ");
                                    }
                                    else
                                    {
                                        Console.Write($"X{n1}{n2}{n3}X ");
                                    }

                                }
                                if (count % 4 == 0)
                                {
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
