using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            string[] input = Console.ReadLine().Split(new char[]{ ' ', ':'}, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Over")
            {
                string inputKey = input[0];
                string inputValue = input[1];
                long number = 0;
                if (long.TryParse(input[1],out number))
                {
                    phonebook[inputKey] = number;
                }
                else if(long.TryParse(input[0],out number))
                {
                    if(!phonebook.ContainsKey(inputValue))
                    {
                        phonebook[inputValue] = number;
                    }
                }
                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (KeyValuePair<string, long> item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }



        }
    }
}
