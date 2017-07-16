using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_Continents__Countries_and_Cities
{
    class GroupContinentsCountriesAndCities
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var Continent = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string continent = input[0];
                string country = input[1];
                string sity = input[2];
                if (!Continent.ContainsKey(continent))
                {
                    Continent.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                    Continent[continent].Add(country, new SortedSet<string>());
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
                        Continent[continent].Add(country, new SortedSet<string>());
                        Continent[continent][country].Add(sity);
                    }
                }
            }
            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> item in Continent)
            {
                string cont = item.Key;
                Console.WriteLine($"{cont}: ");
                foreach (KeyValuePair<string, SortedSet<string>> cnt in Continent[cont])
                {
                    string coun = cnt.Key;
                    SortedSet<string> result = cnt.Value;
                    Console.WriteLine("{0} -> {1}", coun, string.Join(", ", result));
                }
           }
        }
    }
}
