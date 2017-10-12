using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string result = Reverse(num);
            Console.WriteLine(result);
        }

        private static string Reverse(string num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = num.Length -1; i >= 0; i--)
            {
                sb.Append(num[i]);
            }
            return sb.ToString();
        }
    }
}
