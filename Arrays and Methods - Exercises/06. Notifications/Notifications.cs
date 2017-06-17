using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Notifications
    {
        static void PrintShowSuccess()
        {
            string operation = Console.ReadLine();
            string message = Console.ReadLine();
            Console.WriteLine($"Successfully executed { operation}.");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"Message: { message}.");
        }
        static void PrintShowError()
        {
            string operation = Console.ReadLine();
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"Error Code: {code}.");
            if (code < 0)
            {
                Console.WriteLine("Reason: Internal System Failure.");
            }
            else
            {
                Console.WriteLine("Reason: Invalid Client Data.");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine().ToLower();
                if (result == "success")
                {
                    PrintShowSuccess();
                }
                else if (result == "error")
                {
                    PrintShowError();
                }
            }
        }
    }
}
