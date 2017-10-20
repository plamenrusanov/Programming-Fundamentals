using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Aray_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            List<string> commandArgs;
            while (command != "print")
            {
                commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "addMany")
                {
                    int position = int.Parse(commandArgs[1]);
                    List<int> temp = commandArgs.Skip(2).Select(int.Parse).ToList();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == position)
                        {
                            for (int j = 0; j < temp.Count; j++)
                            {
                                numbers.Insert(i + j, temp[j]);
                            }
                        }
                    }
                   // numbers.InsertRange(int.Parse(commandArgs[1]),
                   //     commandArgs.Skip(2).Select(int.Parse).ToList());
                }
                else if (commandArgs[0] == "contains")
                {
                    int number = int.Parse(commandArgs[1]);
                    Console.WriteLine(numbers.IndexOf(number));
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    int number = int.Parse(commandArgs[1]);
                    number = number % numbers.Count;
                    int temp;
                    for (int i = 0; i < number; i++)
                    {
                        temp = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(temp);


                    }
                    /*
                    var rem = numbers.Take(number).ToList();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(rem); */
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    int sum;
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}