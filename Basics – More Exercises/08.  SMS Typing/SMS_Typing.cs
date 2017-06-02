using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class SMS_Typing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int mainDigit = num % 10;
                int numberDigits = 0;
                do
                {
                    numberDigits++;
                    num = num / 10;
                } while (num != 0);
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }
                var letterIndex = (offset + numberDigits - 1) + 97;
                if (letterIndex < 97)
                {
                    letterIndex = 32;
                }
                char letter = (char)letterIndex;

                Console.Write(letter);
            }
        }
    }
}
