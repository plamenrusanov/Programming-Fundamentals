using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static List<int> inputNumbers = new List<int>();
        static void Main(string[] args)
        {
            inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (!command[0].Equals("Odd") && !command[0].Equals("Even"))
            {
                switch (command[0])
                {
                    case "Delete":
                        Delete(command);
                        break;
                    case "Insert":
                        Insert(command);
                        break;                 
                }
                command = Console.ReadLine().Split();
            }
            switch (command[0])
            {
                case "Odd":
                    inputNumbers = inputNumbers.Where(i => i % 2 != 0).ToList();
                    break;
                case "Even":
                    inputNumbers = inputNumbers.Where(i => i % 2 == 0).ToList();
                    break;
            }
            Console.WriteLine(string.Join(" ",inputNumbers));
        }

        private static void Insert(string[] command)
        {
            int element = int.Parse(command[1]);
            int position = int.Parse(command[2]);
            inputNumbers.Insert(position, element);
        }

        private static void Delete(string[] command)
        {
            int element = int.Parse(command[1]);
            inputNumbers = inputNumbers.Where(i => i != element).ToList();
        }
    }
}
