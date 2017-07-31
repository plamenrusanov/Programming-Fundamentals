using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> data = new List<Website>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                data.Add(new Website(input));
                input = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.Write($"https://www.{item.Host}.{item.Domain}");
                if (item.Queries.Count > 0)
                {
                    Console.Write("/query?=[{0}]", string.Join("]&[", item.Queries));
                }
                Console.WriteLine();
            }
        }
    }   
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public Website(string input)
        {
            string[] inputToken = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            this.Host = inputToken[0];
            this.Domain = inputToken[1];
            if (inputToken.Length > 2)
            {
                this.Queries = inputToken[2].Split(new char[] { ',' }).ToList();
            }
            else
            {
                this.Queries = new List<string>();
            }
        }
    }
}
