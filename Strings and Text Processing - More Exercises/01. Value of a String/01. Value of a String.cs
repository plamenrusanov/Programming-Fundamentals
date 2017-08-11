using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Value_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string Case = Console.ReadLine();
            int sumSimbols = 0;
            if (Case == "UPPERCASE")
            {
               // input = input.ToUpper();
                for (int i = 0; i < input.Length; i++)
                {
                    int temp = (int)input[i];
                    if (temp >= 65 && temp <= 90)
                    {
                        sumSimbols += temp; 
                    }
                }
            }
            else
            {

               // input = input.ToLower();
                for (int i = 0; i < input.Length; i++)
                {
                    int temp = (int)input[i];
                    if (temp >= 97 && temp <= 122)
                    {
                        sumSimbols += temp;
                    }
                }
            }
            Console.WriteLine($"The total sum is: {sumSimbols}");
        }
    }
}
