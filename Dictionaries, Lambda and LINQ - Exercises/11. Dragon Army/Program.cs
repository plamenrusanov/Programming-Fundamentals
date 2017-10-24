using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    
    class Program
    {
        static Dictionary<string, Dictionary<string, Dragon>> data = new Dictionary<string, Dictionary<string, Dragon>>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (!data.ContainsKey(input[0]))
                {
                    data.Add(input[0], new Dictionary<string, Dragon>());
                }
                if (!data[input[0]].ContainsKey(input[1]))
                {
                    data[input[0]].Add(input[1], new Dragon(input));
                }
                else 
                {
                    data[input[0]][input[1]] = new Dragon(input);
                }
                
            }
            
            foreach (var item in data)
            {
                Dictionary<string, Dragon> data1 = item.Value;
                double armor = 0;
                double damage = 0;
                double health = 0;
                foreach (var kvp in data1)
                {
                    armor += kvp.Value.Armor;
                    damage += kvp.Value.Damage;
                    health += kvp.Value.Health;
                    
                }
                armor = armor / data1.Count;
                damage = damage / data1.Count;
                health = health / data1.Count;
                Console.WriteLine($"{item.Key}::({damage:f2}/{health:f2}/{armor:f2})");
                foreach (var kvp in data1.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"-{kvp.Key} -> damage: {kvp.Value.Damage}, health: {kvp.Value.Health}, armor: {kvp.Value.Armor}");
                }
            }
        }
        
    }
    public class Dragon
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public Dragon(string[] input)
        {
            Damage = input[2].Equals("null") ? 45 : int.Parse(input[2]);
            Health = input[3].Equals("null") ? 250 : int.Parse(input[3]);
            Armor = input[4].Equals("null") ? 10 : int.Parse(input[4]);
        }
    }
}
