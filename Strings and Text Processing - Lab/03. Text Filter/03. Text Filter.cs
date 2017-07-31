using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string replacment = new string('*', word.Length);
                text = text.Replace(word, replacment);
            }
            Console.WriteLine(text);
        }
    }
}
