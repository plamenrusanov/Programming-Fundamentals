using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class StringRepeater
    {
        static string StringRepeat(string str, int count)
        {
            string repeatStr = String.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatStr += str;
            }
            return repeatStr;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeat(str, count));
        }
    }
}
