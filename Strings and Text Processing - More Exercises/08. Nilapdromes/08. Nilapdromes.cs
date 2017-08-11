using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string result = Nilapdrom(input);
                if (result != "")
                {
                    Console.WriteLine(result);
                }
                input = Console.ReadLine();
            }
        }

        private static string Nilapdrom(string input)
        {
            string result = "";
            int midlle = input.Length / 2;
            int count = 0;
            string border = "";
            for (int i = midlle + 1; i < input.Length; i++)
            {
                if (input[count] == input[i])
                {
                    border += input[i];
                    count++;
                }
                else
                {
                    count = 0;
                    border = "";
                    if (input[count] == input[i])
                    {
                        border += input[count];
                        count++;
                    }
                }
            }
            
            if (border != "" )
            {
                // string core = input.Replace(border, "");
                int leftIndex = input.IndexOf(border);
                //Console.WriteLine(leftIndex);
                int rightIndex = input.LastIndexOf(border);
                //Console.WriteLine(rightIndex);
                string core = input.Substring(leftIndex + border.Length, rightIndex - border.Length);
                if (core != "" )
                {
                    return result = core + border + core;
                }
                
            }
            return result;
        }
    }
}
