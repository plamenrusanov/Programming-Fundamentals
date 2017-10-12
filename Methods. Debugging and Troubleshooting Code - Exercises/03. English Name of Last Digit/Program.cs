using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string result = EnglishName(n);
            Console.WriteLine(result);
        }

        private static string EnglishName(string n)
        {
            string result = null;
            if (n.EndsWith("0"))
            {
                result = "zero";
            }
            else if (n.EndsWith("1"))
            {
                result = "one";
            }
            else if (n.EndsWith("2"))
            {
                result = "two";
            }
            else if (n.EndsWith("3"))
            {
                result = "three";
            }
            else if (n.EndsWith("4"))
            {
                result = "four";
            }
            else if (n.EndsWith("5"))
            {
                result = "five";
            }
            else if (n.EndsWith("6"))
            {
                result = "six";
            }
            else if (n.EndsWith("7"))
            {
                result = "seven";
            }
            else if (n.EndsWith("8"))
            {
                result = "eight";
            }
            else if (n.EndsWith("9"))
            {
                result = "nine";
            }                             
            return result;
        }
    }
}
