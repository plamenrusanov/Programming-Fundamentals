using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            while (input != "It's Training Men!")
            {
                string[] tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 5)
                {
                    if (!data.ContainsKey(tokens[0]))
                    {
                        data.Add(tokens[0], new Dictionary<string, int>());
                    }
                    data[tokens[0]].Add(tokens[2], int.Parse(tokens[4]));
                }
                else if (tokens[1] == "->")
                {
                    if (!data.ContainsKey(tokens[0]))
                    {
                        data.Add(tokens[0], new Dictionary<string, int>());
                    }
                    AddWagons(tokens[0], tokens[2]);
                }
                else if (tokens[1] == "=")
                {
                    if (!data.ContainsKey(tokens[0]))
                    {
                        data.Add(tokens[0], new Dictionary<string, int>());
                    }
                    CopyWagons(tokens[0], tokens[2]);
                }
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,Dictionary<string, int>> item in data.OrderByDescending(d => d.Value.Values.Sum()).ThenBy(d => d.Value.Count))
            {
                string train = item.Key;
                var wagon = item.Value;
                Console.WriteLine($"Train: {train}");
                foreach (var kvp in wagon.OrderByDescending(d => d.Value))
                {

                    string w = kvp.Key;
                    int power = kvp.Value;
                    Console.WriteLine($"###{w} - {power}");
                }
               
            } 
        }

        private static void CopyWagons(string first, string last)
        {
            data[first].Clear();
            foreach (var item in data[last])
            {
                string wag = item.Key;
                int power = item.Value;
                data[first].Add(wag, power);
            }
        }

        private static void AddWagons(string first, string last)
        {
            foreach (var item in data[last])
            {
                string w = item.Key;
                int power = item.Value;
                data[first].Add(w, power);
            }                  
            data.Remove(last);
        }
    }
    class Wagon
    {
        public string WagonName { get; set; }
        public int WagonPower { get; set; }
        public Wagon(string name, string power)
        {
            this.WagonName = name;
            this.WagonPower = int.Parse(power);
        }
    }
}
