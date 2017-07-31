using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputToken = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> result = new SortedSet<string>(); 
            foreach (string token in inputToken)
            {
                string reversed = new string(token.Reverse().ToArray());
                if (reversed == token)
                {
                    result.Add(token);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
