using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, string>>();
            var flatten = new Dictionary<string, Dictionary<string, string>>();
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "end")
            {
                string key = input[0];
                string inerkey = input[1];

                if (key == "flatten")
                {
                    flatten.Add(inerkey, new Dictionary<string, string>());
                    flatten[inerkey] =
                        data[inerkey].ToDictionary(kvp => kvp.Key + kvp.Value, kvp => "");

                    data[inerkey].Clear();
                }
                else
                {
                    string inervalue = input[2];
                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new Dictionary<string, string>());
                    }
                    if (!data[key].ContainsKey(inerkey))
                    {
                        data[key].Add(inerkey, inervalue);
                    }
                    data[key][inerkey] = inervalue;
                }

                input = Console.ReadLine().Split(' ');
            }
            foreach (var item in data.OrderByDescending(n => n.Key.Length))
            {
                string key = item.Key;
                Dictionary<string, string> inerDictionary = item.Value;
                Console.WriteLine(key);
                int count = 1;
                foreach (var iner in inerDictionary.OrderBy(n => n.Key.Length))
                {
                    string inerkey = iner.Key;
                    string inervalue = iner.Value;
                    Console.WriteLine($"{count}. {inerkey} - {inervalue}");
                    count++;
                }
                if (flatten.ContainsKey(key))
                {
                    foreach (KeyValuePair<string, Dictionary<string, string>> flat in flatten)
                    {
                        Dictionary<string, string> inerkey = flat.Value;
                        foreach (var fl in inerkey)
                        {
                            string result = fl.Key;
                            Console.WriteLine($"{count}. {result}");
                            count++;
                        }
                    }
                }
            }
        }
    }
}
