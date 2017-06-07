using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class ASCII_String
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                char letter = Convert.ToChar(num);
                word += letter;
            }
            Console.WriteLine(word);
        }
    }
}
