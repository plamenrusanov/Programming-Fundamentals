using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _01.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = Console.ReadLine();
            bool shake = true;
            while (shake)
            {
                shake = false;
                
                int firstIndex = input.IndexOf(patern);
                int lastIndex = input.LastIndexOf(patern);
                if (firstIndex != lastIndex && (lastIndex != -1 || firstIndex != -1))
                {
                    input = input.Remove(lastIndex, patern.Length);
                    input = input.Remove(firstIndex, patern.Length);
                    shake = true;
                }               
                if (shake)
                {
                    Console.WriteLine("Shaked it.");

                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                if (patern.Length > 0 )
                {
                    patern = patern.Remove(patern.Length / 2 ,1);                    
                }             
                if(patern.Length == 0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                
#if DEBUG

                Console.WriteLine("input: " + input);
                Console.WriteLine("patern: " + patern);
#endif

            }
            Console.WriteLine(input);
        }
    }
}
