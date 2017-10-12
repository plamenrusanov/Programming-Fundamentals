using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrFirst = Console.ReadLine().Split();
            string[] arrSecond = Console.ReadLine().Split();
            int startResult = 0;
            for (int i = 0; i < Math.Min(arrFirst.Length, arrSecond.Length); i++)
            {
                if (arrFirst[i].Equals(arrSecond[i]))
                {
                    startResult++;
                }
                else
                {
                    break;
                }
            }
            arrFirst = arrFirst.Reverse().ToArray();
            arrSecond = arrSecond.Reverse().ToArray();
            int endResult = 0;
            for (int i = 0; i < Math.Min(arrFirst.Length, arrSecond.Length); i++)
            {
                if (arrFirst[i].Equals(arrSecond[i]))
                {
                    endResult++;
                }
                else
                {
                    break;
                }
            }
            if (startResult >= endResult)
            {
                Console.WriteLine(startResult);
            }
            else
            {
                Console.WriteLine(endResult);
            }



        }
    }
}
