using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string text = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (i != n)
                {
                    text += word + delimeter;
                }
                else
                {
                    text += word;
                }
            }
            Console.WriteLine(text.Trim());
        }
    }
}
