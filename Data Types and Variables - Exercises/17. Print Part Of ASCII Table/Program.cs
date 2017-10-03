using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            char start = (char)first;
            char end = (char)last;
            for (char i = start; i <= end; i++)
            {
                Console.Write(i+" ");

            }
            Console.WriteLine();
        }
    }
}
