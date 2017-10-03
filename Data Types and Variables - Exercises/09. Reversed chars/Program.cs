using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Append(c);
            sb.Append(b);
            sb.Append(a);
            Console.WriteLine(sb);

        }
    }
}
