using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string inputName = "";

            do
            {
                inputName = Console.ReadLine();
                for (int i = 0; i < names.Length; i++)
                {
                    if (inputName == names[i])
                    {
                        Console.WriteLine($"{inputName} -> {phoneNumbers[i]}");
                    }
                }
            } while (inputName != "done");
        }
    }
}
