using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.String_Commander
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string[] commandToken = command.Split(' ').ToArray();
                switch (commandToken[0])
                {
                    case "Left":
                        result = LeftTurn(result, commandToken[1]);
                        break;
                    case "Right":
                        result = RightTurn(result, commandToken[1]);
                        break;
                    case "Insert":
                        result = Insert(result, commandToken[1], commandToken[2]);
                        break;
                    case "Delete":
                        result = Delete(result, commandToken[1], commandToken[2]);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(result);
        }

        private static StringBuilder Delete(StringBuilder result, string v1, string v2)
        {
            int begining = int.Parse(v1);
            int lenght = int.Parse(v2) +1;
            return result.Remove(begining, lenght);
        }

        private static StringBuilder Insert(StringBuilder result, string v1, string v2)
        {
            int index = int.Parse(v1);
            return result.Insert(index, v2);
        }

        private static StringBuilder RightTurn(StringBuilder input, string v)
        {
            int turn = int.Parse(v) % input.Length;
            for (int i = 0; i < turn; i++)
            {
                string temp = input[input.Length - 1].ToString();
                input = input.Remove(input.Length - 1, 1);
                input = input.Insert(0, temp);
            }
            return input;
        }

        private static StringBuilder LeftTurn(StringBuilder input, string v)
        {
            int turn = int.Parse(v) % input.Length;
            for (int i = 0; i < turn; i++)
            {
                string temp = input[0].ToString();
                input = input.Remove(0, 1);
                input.Append(temp);
            }
            return input;
        }
    }
}
