using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    class CitiesContinentAndCountry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var Continent = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string continent = input[0];
                string country = input[1];
                string sity = input[2];
                if (!Continent.ContainsKey(continent))
                {
                    Continent.Add(continent, new Dictionary<string, List<string>>());
                    Continent[continent].Add(country, new List<string>());
                    Continent[continent][country].Add(sity);
                }
                else if (Continent.ContainsKey(continent))
                {
                    if (Continent[continent].ContainsKey(country))
                    {
                        Continent[continent][country].Add(sity);
                    }
                    else if (!Continent[continent].ContainsKey(country))
                    {
                        Continent[continent].Add(country, new List<string>());
                        Continent[continent][country].Add(sity);
                    }
                }             
            }
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> item in Continent)
            {
                string cont = item.Key;
                Console.WriteLine($"{cont}: ");
                foreach (KeyValuePair<string, List<string>> cnt in Continent[cont])
                {
                    string coun = cnt.Key;
                    List<string> result = cnt.Value;
                    Console.WriteLine("{0} -> {1}", coun, string.Join(", ", result));
                }
            }
        }
    }
}
