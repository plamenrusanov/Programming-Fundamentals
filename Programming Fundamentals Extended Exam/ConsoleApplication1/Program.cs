using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"<[*/*].";
            string r = Regex.Escape(input);
            Console.WriteLine(r);
        }
    }
}
//“<[*/*].”, “<[---].”, “<[.;[].”... Invalid locomotives: “[//].”, “<[*-*]”, “<[asd1].”