using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Ballistics_Training
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            string[] cordinates = Console.ReadLine().Split(' ');
            string[] instructions = Console.ReadLine().Split(' ');
            int[] newCordinates = new int[cordinates.Length];
            for (int i = 0; i < cordinates.Length; i++)
            {
                newCordinates[i] = int.Parse(cordinates[i]);
            }   
            int x = 0;
            int y = 0;
            int horVer = 0;

            for (int i = 0; i < instructions.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (instructions[i] == "up") horVer = 1;
                    else if (instructions[i] == "down") horVer = 2;
                    else if (instructions[i] == "right") horVer = 3;
                    else if (instructions[i] == "left") horVer = 4;
                }
                else if (i % 2 != 0)
                {
                    int currentMove = int.Parse(instructions[i]);
                    switch (horVer)
                    {
                        case 1: y += currentMove;break;
                        case 2: y -= currentMove;break;
                        case 3: x += currentMove;break;
                        case 4: x -= currentMove;break;                          
                    }
                } 
                                
            }
            int[] newInstruction = new int[2];
            newInstruction[0] = x;
            newInstruction[1] = y;
            if (newCordinates[0] == newInstruction[0] && newCordinates[1] == newInstruction[1])
            {
                Console.WriteLine("firing at [{0}, {1}]",x,y);
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("firing at [{0}, {1}]", x, y);
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
