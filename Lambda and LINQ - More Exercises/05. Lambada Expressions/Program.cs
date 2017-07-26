using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, string>>();
            string input = Console.ReadLine();
            while (input != "lambada")
            {
                string[] inputToken = input.Split(new string[] { " => ", "." }, StringSplitOptions.RemoveEmptyEntries);
              
                if (input == "dance")
                {
                    data = data.ToDictionary(skey => skey.Key,
                                             svalue => svalue.Value
                                             .ToDictionary(kvp => kvp.Key, 
                                             kvp => kvp.Key + "." + kvp.Value));

                }
                else
                {
                    string selector = inputToken[0];
                    string selectorObject = inputToken[1];
                    string selectorProperty = inputToken[2];
                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Dictionary<string, string>());
                    }
                    data[selector][selectorObject] = selectorProperty;                 
                }
                input = Console.ReadLine();
            }
            foreach (var item in data)
            {
                string selector = item.Key;
                Dictionary<string, string> selectorObjectData = item.Value;
                foreach (var kvp in selectorObjectData)
                {
                    string selectorObject = kvp.Key;
                    string selectorProperty = kvp.Value;
                    Console.WriteLine($"{selector} => {selectorObject}.{selectorProperty}");
                }
            }
        }
    }
}
