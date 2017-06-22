using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            string[] equalstrings = Console.ReadLine().Split();

            string last3Strings = "";

            for (int i = 0; i < equalstrings.Length; i++)
            {
                if (i >= 2)
                {
                    if (equalstrings[i] == equalstrings[i - 1] && equalstrings[i] == equalstrings[i - 2])
                    {
                        last3Strings = $"{equalstrings[i]} { equalstrings[i - 1] } {equalstrings[i - 2]}";
                    }
                }
            }
            Console.WriteLine(last3Strings);
        }
    }
}
