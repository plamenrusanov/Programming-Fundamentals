using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main(string[] args)
        {
            string[] ArrayOfDoules = Console.ReadLine().Split(' ');
            double p = double.Parse(Console.ReadLine());

            double[] Arr = new double[ArrayOfDoules.Length];


            for (int i = 0; i < ArrayOfDoules.Length; i++)
            {
                Arr[i] = Convert.ToDouble(ArrayOfDoules[i]) * p;
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
