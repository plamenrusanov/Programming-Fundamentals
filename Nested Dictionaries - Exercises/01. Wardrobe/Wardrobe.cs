using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                string color = input[0];
                List<string> clothes = input[1].Split(',').ToList();
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color,new Dictionary<string, int>());
                    
                }
                foreach (var cloth in clothes)
                {
                    Dictionary<string, int> CLOTH = wardrobe[color];
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        CLOTH.Add(cloth, 0);
                    }                                   
                    CLOTH[cloth]++;                 
                }
            }
            string[] searchToken = Console.ReadLine().Split();
            string searchColor = searchToken[0];
            string searchCloth = searchToken[1];

            foreach (var item in wardrobe)
            {
                string color = item.Key;
                Console.WriteLine($"{color} clothes:");
                Dictionary<string, int> clothes = item.Value;
                foreach (KeyValuePair<string, int> cloth in clothes)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (searchColor == color && searchCloth == cloth.Key)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
