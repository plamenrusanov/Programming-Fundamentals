using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            byte count = 0;
            byte overflow = 0;

            for (int i = 0; i < num; i++)
            {
                if (count == 255)
                {
                    overflow++;
                }
                count++;
            }
            if (overflow != 0)
            {
                Console.WriteLine($"{count}");
                Console.WriteLine($"Overflowed {overflow} times");
            }
            else
            {
                Console.WriteLine(count);
            }

        }
    }
}
