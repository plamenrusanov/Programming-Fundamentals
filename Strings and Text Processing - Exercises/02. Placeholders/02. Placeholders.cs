using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputToken = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string text = inputToken[0];
                List<string> replaceWords = inputToken[1].Split(new string[] { ", " }
                                            , StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = 0; i < replaceWords.Count; i++)
                {                               
                    string match = "{" + i + "}";
                    text = text.Replace(match, replaceWords[i]);                 
                }
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
        }
    }
}
