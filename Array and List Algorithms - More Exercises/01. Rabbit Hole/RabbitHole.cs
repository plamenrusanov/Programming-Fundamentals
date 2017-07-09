using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            List<string> Temp = new List<string>();
            for (int i = 0; i < input.Count;)
            {
                string temp = input[i];
                Temp = temp.Split('|').ToList();
                if (input[i] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else if (input[i].Contains("Right"))
                {
                    int jump = int.Parse(Temp[1]);
                    energy -= jump;
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        return;
                    }
                    i = (jump + i) % input.Count;
                }
                else if (input[i].Contains("Left"))
                {
                    int jump = int.Parse(Temp[1]);
                    energy -= jump;
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        return;
                    }
                    //i = (jump + (input.Count - i)) % input.Count;   
                    i = Math.Abs(i - jump) % input.Count;
                }
                else if (input[i].Contains("Bomb"))
                {
                    int jump = int.Parse(Temp[1]);
                    input.RemoveAt(i);
                    i = 0;
                    energy -= jump;
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                }
                if (input[input.Count - 1] == "RabbitHole")
                {
                    input.Add($"Bomb|{energy}");
                }
                else
                {
                    input.RemoveAt(input.Count - 1);
                    input.Add($"Bomb|{energy}");

                    //input.Insert(input.Count-1,$"Bomb|{energy}");
                }
            }
        }
    }
}
