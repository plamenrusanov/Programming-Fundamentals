using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
               // string[] sentences = input.Split(new string[] { "!", "?" }, StringSplitOptions.RemoveEmptyEntries);
               
                    string[] inputToken = input.Split(new char[] {  '.', ',', '-', '_', '!'
                                           , '"', '?', ':', ';', '(', ')', '{', '}', '[', ']', '§'
                                           , '$', '%', '&', '/', '\\', '=', '|', '^', '°', '*', '#'
                                           , '+', '~', '²', '³', '<', '>', ' '}, StringSplitOptions.RemoveEmptyEntries);
                    for (int word = 0; word < inputToken.Length; word++)
                    {
                        string lower = inputToken[word].ToLower();
                        char[] charArr = lower.ToCharArray();
                        int Acode = charArr[0];
                        if (Acode >= 97 && Acode <= 122)
                        {
                            Acode -= 32;
                        }
                        char first = (char)Acode;
                        charArr[0] = first;
                        inputToken[word] = new string(charArr);
                    }
                    Console.WriteLine(string.Join(", ", inputToken));
                
              
                input = Console.ReadLine();
            }
        }    
    }
}
