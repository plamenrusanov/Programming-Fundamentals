using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02.Hornet_Comm
{
    class Program
    {
        // string.All(char.IsDigit && char.IsletterOrDigit)
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var broadcast = new Dictionary<string, List<string>>();
            var message = new Dictionary<string, List<string>>();
            Regex mes = new Regex(@"^([0-9]+) <-> ([A-Za-z0-9]+)$");
            Regex broa = new Regex(@"^([^0-9]+) <-> ([A-Za-z0-9]+)$");
            while (input != "Hornet is Green")
            {

                string[] inputtoken = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (broa.IsMatch(input))
                {
                    Match b = broa.Match(input);

                    string first = b.Groups[1].Value;
                    string second = b.Groups[2].Value;
                    second = Letters(second);
                   

                    if (!broadcast.ContainsKey(second))
                        {
                            broadcast.Add(second, new List<string>());
                        }
                        broadcast[second].Add(first);                    
                }
                if (mes.IsMatch(input))
                {
                    Match m = mes.Match(input);


                    string first = m.Groups[1].Value;
                    string second = m.Groups[2].Value;
                    char[] temp = first.ToCharArray();
                    Array.Reverse(temp);
                    first =  new string(temp);

                    if (!message.ContainsKey(first))
                    {
                        message.Add(first, new List<string>());
                    }
                    message[first].Add(second);

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
        static string Letters(string input)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int c = input[i];
                if (c >= 65 && c <= 90)
                {
                    char cc =(char)( c + 32);
                    temp.Append(cc);
                }
                else if (c >= 97 && c <= 122)
                {
                    char cc = (char)(c - 32);
                    temp.Append(cc);
                }
                else
                {
                    temp.Append(input[i]);
                }
            }       
            return temp.ToString();
        }

    }
}
