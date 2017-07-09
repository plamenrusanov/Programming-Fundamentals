using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Japanese_Roulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            List<int> cylinder = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> players = Console.ReadLine().Split(' ').ToList();
            int position = 0;
            List<string> Temp = new List<string>();
            for (int i = 0; i < cylinder.Count; i++)
            {
                if (cylinder[i] == 1 )
                {
                    position = i;
                    break;
                }
            }
            for (int player = 0; player < players.Count; player++)
            {
                string temp = players[player];
                Temp = temp.Split(',').ToList();
                if (temp.Contains("Right"))
                {
                    int jump = int.Parse(Temp[0]);
                    position = (jump + position) % cylinder.Count;

                    if (position == 2)
                    {
                        Console.WriteLine($"Game over! Player {player} is dead.");
                        return;
                    }
                }
                else if (temp.Contains("Left"))
                {
                    int jump = int.Parse(Temp[0]);
                    if ((jump % cylinder.Count) <= position)
                    {
                        position -= jump % cylinder.Count; 
                    }
                    else
                    {
                        position =  (position + cylinder.Count) - (jump % cylinder.Count);
                    }
                    if (position == 2)
                    {
                        Console.WriteLine($"Game over! Player {player} is dead.");
                        return;
                    }
                }
                position++;
            }
            Console.WriteLine("Everybody got lucky!");
        }
        static void Left(List<string>cylinder)
        {
            cylinder = cylinder.Skip(1).Concat(cylinder.Take(1)).ToList();
                  
        }
    }
}
