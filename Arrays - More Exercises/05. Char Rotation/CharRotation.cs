using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string[] SecondString = Console.ReadLine().Split();

            string result = "";
          
            for (int i = 0; i < firstString.Length; i++)
            {
                int firstNum = (int)firstString[i];
                int secondNum = int.Parse(SecondString[i]);
                if (i % 2 == 0)
                {
                    int numResult = firstNum + secondNum;
                    result += (char)numResult;
                }
                else
                {
                    int numResult = firstNum - secondNum;
                    result += (char)numResult;
                }
            }
            Console.WriteLine(result);
        }
    }
}
