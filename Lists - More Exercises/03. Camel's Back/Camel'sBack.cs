using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Sity = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int loop = (Sity.Count - n) / 2;
            for (int i = 0; i < loop; i++)
            {
                Sity.RemoveAt(Sity.Count - 1);
                Sity.RemoveAt(0);
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine($"already stable: " + string.Join(" ", Sity));
            }
            else
            {
                Console.WriteLine($"{count} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", Sity));
            }
        }
    }
}
