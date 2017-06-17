using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class IntegerToBase
    {
        static string IntToBase(int number, int toBase)
        {
            string result = string.Empty;
            while (number > 0)
            {
                int num = number % toBase;
                result = num + result;
                number = number / toBase;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntToBase(number, toBase));
        }
    }
}
