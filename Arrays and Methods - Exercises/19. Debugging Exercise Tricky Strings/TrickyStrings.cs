using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Debugging_Exercise_Tricky_Strings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < numberOfStrings; i++)
            {
                string currentString = Console.ReadLine();
                if (i == 0)
                    result += currentString;
                else
                    result += delimiter + currentString;
            }
            Console.WriteLine(result);
        }
    }
}
