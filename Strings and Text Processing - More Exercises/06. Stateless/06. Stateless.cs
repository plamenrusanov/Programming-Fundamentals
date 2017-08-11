using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = Console.ReadLine();
            string function = Console.ReadLine();
            while (state != "collapse")
            {
                while (function.Length > 0)
                {
                    if (state.Contains(function))
                    {
                        state = state.Replace(function, "");
                    }
                    if (function.Length >= 2)
                    {
                        function = Reduce(function);
                    }
                    else
                    {
                        break;
                    }
                }
                if (state.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(state.Trim());
                }
                
                state = Console.ReadLine();
                function = Console.ReadLine();
            }

        }

        private static string Reduce(string function)
        {
            function = function.Remove(function.Length - 1, 1);
            function = function.Remove(0, 1);
            return function;
        }
    }
}
