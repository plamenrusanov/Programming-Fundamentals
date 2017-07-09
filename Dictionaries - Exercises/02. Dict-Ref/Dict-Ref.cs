using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();

            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "end")
            {
                string inputKey = tokens[0];
                string inputValue = tokens[1];
                int numberValue = 0;
                if (int.TryParse(inputValue, out numberValue))
                {
                    values[inputKey] = numberValue;
                }
                else
                {
                    if (values.ContainsKey(inputValue))
                    {
                        values[inputKey] = values[inputValue];
                    }
                }
                tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> item in values)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
