using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    break;
                }
            } while (true);
            Console.WriteLine(count);
        }
    }
}
