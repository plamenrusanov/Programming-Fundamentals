using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char ascii = char.Parse(Console.ReadLine());
                int numOfAscii = (int)ascii;
                int firstNum = 0;
                int lastNum = 0;
                lastNum = numOfAscii % 10;
                if (numOfAscii >= 100)
                {
                    firstNum = numOfAscii / 100;
                }
                else
                {
                    firstNum = numOfAscii / 10;
                }
                char firstChar = (char)(numOfAscii + lastNum);
                char lastChar = (char)(numOfAscii - firstNum);
                result += $"{firstChar}{firstNum}{lastNum}{lastChar}";
            }
            Console.WriteLine(result);
        }
    }
}
