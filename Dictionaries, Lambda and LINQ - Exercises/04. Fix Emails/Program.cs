using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string name = Console.ReadLine();
            string email = Console.ReadLine();
            while (name != "stop")
            {
                if (!email.EndsWith("us") || email.EndsWith("uk"))
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, email);
                    }
                }
                name = Console.ReadLine();
                email = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
