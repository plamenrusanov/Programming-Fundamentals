using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            List<Exercise> lab1 = new List<Exercise>();
            string input = Console.ReadLine();
            while (input != "go go go")
            {
                lab1.Add(new Exercise(input));             
                input = Console.ReadLine();
            }
            foreach (var item in lab1)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");             
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                for (int i = 1; i <= item.Problems.Count; i++)
                {
                    Console.WriteLine($"{i}. {item.Problems[i - 1]}");
                }
            }
            
        }
    }
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercise(string input)
        {
            string[] inpitToken = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            this.Topic = inpitToken[0];
            this.CourseName = inpitToken[1];
            this.JudgeContestLink = inpitToken[2];
            this.Problems = inpitToken[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }           
    }
}
