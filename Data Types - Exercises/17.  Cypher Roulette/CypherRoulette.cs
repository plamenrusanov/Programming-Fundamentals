using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spinCount = 0;
            string totalString = string.Empty;
            string lastString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string newInputString = Console.ReadLine();


                if (newInputString == "spin")
                {
                    spinCount++;
                    i--;
                }
                if (spinCount % 2 == 0 && newInputString != "spin")
                {
                    totalString = totalString + newInputString;
                }
                else if (spinCount % 2 == 1 && newInputString != "spin")
                {
                    totalString = newInputString + totalString;
                }
                if (newInputString == lastString)
                {
                    totalString = string.Empty;
                    if (newInputString == "spin")
                    {
                        spinCount++;
                    }
                }
                lastString = newInputString;

            }
            Console.WriteLine(totalString);
        }
    }
}
