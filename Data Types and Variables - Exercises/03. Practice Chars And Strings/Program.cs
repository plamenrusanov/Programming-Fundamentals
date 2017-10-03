using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());
            string str2 = Console.ReadLine();
            Console.WriteLine($"{str1}\n{ch1}\n{ch2}\n{ch3}\n{str2}");
        }
    }
}
