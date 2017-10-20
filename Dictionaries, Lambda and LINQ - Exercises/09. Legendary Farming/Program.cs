using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items.Add("shards", 0);
            items.Add("motes", 0);
            items.Add("fragments", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string[] materials;// = Console.ReadLine().Split(' ');
            bool isObtained = false;
            int quantity = 0;
            string material = "";
            while (!isObtained)
            {
                materials = Console.ReadLine().Split(' ');
                for (int i = 0; i < materials.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(materials[i]);
                    }
                    else
                    {
                        material = materials[i].ToLower();
                    }
                    if (i % 2 != 0)
                    {
                        if (items.ContainsKey(material))
                        {
                            items[material] += quantity;
                        }
                        else if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, quantity);
                        }
                        else
                        {
                            junk[material] += quantity;
                        }
                        isObtained = items.Any(it => it.Value >= 250);
                        if (isObtained)
                        {
                            break;
                        }
                    }
                }
            }
            if (items["shards"] >= 250)
            {
                items["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (items["motes"] >= 250)
            {
                items["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (items["fragments"] >= 250)
            {
                items["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            foreach (var item in items.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
        }
    }
}
