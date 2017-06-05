using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.From_Terabytes_to_Bits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            double teraBit = double.Parse(Console.ReadLine());

            long tb = (long)1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine((tb * teraBit));
        }
    }
}
