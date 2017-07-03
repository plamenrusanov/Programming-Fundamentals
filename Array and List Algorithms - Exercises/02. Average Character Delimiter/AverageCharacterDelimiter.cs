using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split(); 
            string input = "";
            for (int i = 0; i < Input.Length; i++)
            {
                input += Input[i];
            }
            int sumOfLetters = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sumOfLetters += (int)input[i];
            }
            int numOfDelimeter = sumOfLetters / input.Length;
            if (numOfDelimeter >= 97 && numOfDelimeter <= 122)
            {
                numOfDelimeter -= 32;
            }
            char delimeter = (char)numOfDelimeter;
            Console.WriteLine(string.Join("{0}",Input),delimeter);
        }
    }
}
