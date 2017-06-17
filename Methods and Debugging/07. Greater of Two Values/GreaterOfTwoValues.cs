using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class GreaterOfTwoValues
    {
        static int GetIntMax()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = Math.Max(first, second);
            return max;
        }
        static char GetCharMax()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int max = Math.Max((int)first, (int)second);
            return (char)max;
        }
        static string GetStringMax()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    Console.WriteLine(GetIntMax());
                    break;
                case "string":
                    Console.WriteLine(GetStringMax());
                    break;
                case "char":
                    Console.WriteLine(GetCharMax());
                    break;
                default:
                    break;
            }
        }
    }
}
