using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Variable_in_Hexadecimal_Format
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            int number = Convert.ToInt32(inputNumber, 16);
           // string hexadecimal = Convert.ToString(number, 16);
           // Console.WriteLine("0x"+hexadecimal);

            Console.WriteLine(number);
        }
    }
}
