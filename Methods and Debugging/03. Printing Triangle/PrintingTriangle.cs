using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class PrintingTriangle
    {

        static void PrintTrianle(int start, int end)
        {


            for (int row = start; row <= end; row++)
            {
                for (int col = start; col <= end; col++)
                {
                    if (col <= row)
                    {
                        Console.Write(col + " ");
                    }
                }
                Console.WriteLine();
            }
            for (int row = end - 1; row >= start; row--)
            {
                for (int col = start; col <= end - 1; col++)
                {
                    if (col <= row)
                    {
                        Console.Write(col + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            PrintTrianle(1, end);
        }
    }
}
