using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int take = command[0];
            int delete = command[1];
            int search = command[2];
            input = input.Take(take).ToList();
            Console.WriteLine(string.Join(" ",input));
            try
            {
                input.RemoveAt(delete - 1);
            }
            catch (Exception)
            {

                
            }
           
            bool result = input.Any(i => i == search);
            if (result)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
