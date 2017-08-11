using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var broadcast = new Dictionary<string, List<string>>();
            var message = new Dictionary<string, List<string>>();
            while (input != "Hornet is Green")
            {

                string[] inputtoken = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                string first = inputtoken[0];
                string second = inputtoken[1];
                if (!IsOnlyDigits(first))
                {
                    if (!IsDigitsLetters(second))
                    {
                        if (!broadcast.ContainsKey(second))
                        {
                            broadcast.Add(second, new List<string>());
                        }
                        broadcast[second].Add(first);
                    }
                }
                if (IsOnlyDigits(first))
                {
                    if (IsDigitsLetters(second))
                    {
                        var alfa = first.Reverse();
                        string beta = alfa.ToString();
                        Console.WriteLine(alfa);
                        if (!message.ContainsKey(alfa))
                        {
                            message.Add(alfa, new List<string>());
                        }
                        message[alfa].Add(second);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var broad in broadcast)
            {
                string key = broad.Key;
                List<string> value = broad.Value;
                foreach (string item in value)
                {
                    Console.WriteLine($"{key} -> {item}");
                }
                
            }
            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var mess in message)
            {
                string key = mess.Key;
                List<string> value = mess.Value;
                foreach (string item in value)
                {
                    Console.WriteLine($"{key} -> {item}");
                }
               
            }

        }

        static bool IsOnlyDigits(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!(input[i] >= 48 && input[i] <= 57))
                {
                    return false;
                }
            }

            return true;
        }
        static bool IsDigitsLetters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122) || (input[i] >= 48 && input[i] <= 57)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
