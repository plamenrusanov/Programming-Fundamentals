using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
    class Program
    {      
        static void Main(string[] args)
        {
            Dictionary<string, Visitors> data = new Dictionary<string, Visitors>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputToken = input.Split();
                if (!data.ContainsKey(inputToken[0]))
                {
                    data.Add(inputToken[0], new Visitors(inputToken[1], inputToken[2]));
                }
                else 
                {
                    data[inputToken[0]].CamperName.Add(inputToken[1]);
                    data[inputToken[0]].Stay += int.Parse(inputToken[2]);
                }

                input = Console.ReadLine();
            }
           
            foreach (var item in data.OrderByDescending(d => d.Value.CamperName.Count).ThenBy(c => c.Key.Length))
            {
                string gest = item.Key;               
                List<string> campers = item.Value.CamperName;
                int stay = item.Value.Stay;
                Console.WriteLine($"{gest}: {campers.Count}");
                Console.WriteLine(string.Join("\n",campers.Select(c => string.Format("***"+c))));
                Console.WriteLine($"Total stay: {stay} nights");
            }
        }
    }
    class Visitors
    {
       // public string GestName { get; set; }
        public List<string> CamperName { get; set; }
        public int Stay { get; set; }
        public Visitors(string camper, string days)
        {

            //GestName = inputToken[0];
            CamperName = new List<string> { camper };
            Stay += int.Parse(days);
        }
    }

}
