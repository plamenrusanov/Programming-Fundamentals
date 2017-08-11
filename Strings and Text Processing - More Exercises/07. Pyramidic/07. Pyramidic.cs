using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputStrings = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                inputStrings.Add(Console.ReadLine());
            }
            List<string> piramids = new List<string>();
            for (int i = 0; i < inputStrings.Count; i++)
            {
                string line = inputStrings[i];
                for (int j = 0; j < line.Length; j++)
                {
                    char @char = line[j];
                    piramids.Add(IsPiramid(inputStrings, @char, i));
                    
                }
            }
            Console.WriteLine(piramids.OrderByDescending(p => p.Length).First());
        }

        private static string IsPiramid(List<string> inputStrings, char @char, int i)
        {
            string result = "";
            int count = 1;           
            for (int line = i; line < inputStrings.Count; line++)
            {
                string ToFind = new string(@char, count);
                if (inputStrings[line].Contains(ToFind))
                {
                    result += ToFind + "\n";
                    count += 2;
                }
                else
                {
                    return result;
                }
            }
            return result;
        }
    }
}
