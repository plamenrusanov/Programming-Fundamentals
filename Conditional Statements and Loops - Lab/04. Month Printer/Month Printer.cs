using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var mount = int.Parse(Console.ReadLine());

            string abc = null;
            switch (mount)
            {
                case 1: abc = "January"; break;
                case 2: abc = "February"; break;
                case 3: abc = "March"; break;
                case 4: abc = "April"; break;
                case 5: abc = "May"; break;
                case 6: abc = "June"; break;
                case 7: abc = "July"; break;
                case 8: abc = "August"; break;
                case 9: abc = "September"; break;
                case 10: abc = "October"; break;
                case 11: abc = "November"; break;
                case 12: abc = "Desember"; break;
                default:
                    abc = "Error!";
                    break;
            }
            Console.WriteLine(abc);
        }
    }
}
