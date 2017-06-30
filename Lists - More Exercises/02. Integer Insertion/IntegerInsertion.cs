using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class IntegerInsertion
    {
        static int FirstDigit()
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                firstDigit = inputString[0] - 48;
            }
            return firstDigit;
        }
        static int firstDigit = 0;
        static string inputString = "";
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine().Split().Select(int.Parse).ToList();
            inputString = Console.ReadLine();
            while (inputString != "end")
            {
                int inputNumber = int.Parse(inputString);
                FirstDigit();
                List.Insert(firstDigit, inputNumber);
                inputString = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", List));
        }
    }
}
