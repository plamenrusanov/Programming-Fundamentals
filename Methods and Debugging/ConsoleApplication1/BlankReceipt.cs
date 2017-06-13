using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlancReceipt
{
    class BlankReceipt
    {
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to" + new string('_', 20));
            Console.WriteLine("Received by" + new string('_', 19));
        }
        static void PrintFooter()
        {

            Console.WriteLine(new string('-', 30));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\u00a9 SoftUni");
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
